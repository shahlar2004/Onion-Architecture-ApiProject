using ApiProject.Application.Bases;
using ApiProject.Application.Features.Auth.Rules;
using ApiProject.Application.Interfaces.Tokens;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandHandler : BaseHandler, IRequestHandler<RefreshTokenCommandRequest, RefreshTokenCommandResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;
        private readonly ITokenService tokenService;


        public RefreshTokenCommandHandler(UserManager<User> userManagerç,AuthRules authRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, ITokenService tokenService) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
            this.authRules = authRules;
            this.tokenService = tokenService;
        }

        public async Task<RefreshTokenCommandResponse> Handle(RefreshTokenCommandRequest request, CancellationToken cancellationToken)
        {
            var prinsipal=   tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
            string email = prinsipal.FindFirstValue(ClaimTypes.Email);

            var user= await userManager.FindByEmailAsync(email);
            var roles= await userManager.GetRolesAsync(user);

          await authRules.RefreshTokenShouldNotBeExpired(user.RefreshTokenExpiryTime);

            JwtSecurityToken newAccessToken = await tokenService.CreateToken(user,roles);

            string newRefreshToken = tokenService.GenerateRefreshToken();


            user.RefreshToken= newRefreshToken;

            await userManager.UpdateAsync(user);

            return new()
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
                RefreshToken = newRefreshToken,
            };




        }
    }
}
