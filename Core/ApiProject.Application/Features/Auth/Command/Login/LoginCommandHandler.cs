using ApiProject.Application.Bases;
using ApiProject.Application.Interfaces.Tokens;
using ApiProject.Application.Features.Auth.Rules;
using ApiProject.Application.Interfaces.Tokens;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ApiProject.Application.Features.Auth.Command.Login
{
    public class LoginCommandHandler : BaseHandler, IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly AuthRules authRules;
        private readonly IConfiguration configuration;
        private readonly ITokenService tokenService;

        public LoginCommandHandler( UserManager<User> userManager, RoleManager<Role> roleManager, AuthRules authRules, IConfiguration configuration, ITokenService tokenService, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor):base(mapper,unitOfWork,httpContextAccessor)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.authRules = authRules;
            this.configuration = configuration;
            this.tokenService = tokenService;
        }
        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
           User user= await userManager.FindByEmailAsync(request.Email);
            bool checkPassword = await userManager.CheckPasswordAsync(user, request.Password);

            await authRules.EmailOrPasswordShouldNotBeInvalid(user,checkPassword );
            IList<string> roles= await userManager.GetRolesAsync(user);
            JwtSecurityToken token= await tokenService.CreateToken(user,roles);

            string refreshToken = tokenService.GenerateRefreshToken();

            _ = int.TryParse(configuration["RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime= DateTime.Now.AddDays(refreshTokenValidityInDays);

            await userManager.UpdateAsync(user);
            await userManager.UpdateSecurityStampAsync(user);

            string _token= new JwtSecurityTokenHandler().WriteToken(token);
                
            await userManager.SetAuthenticationTokenAsync(user,"Default","AccessToken",_token);

            return new()
            {
                Token = _token,
                RefreshToken=refreshToken,
                Expiration=token.ValidTo

            };


            
        }
    }
}
