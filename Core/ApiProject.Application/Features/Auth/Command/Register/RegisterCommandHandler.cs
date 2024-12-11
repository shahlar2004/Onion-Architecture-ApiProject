using ApiProject.Application.Bases;
using ApiProject.Application.Features.Auth.Rules;

//using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Auth.Command.Register
{
    internal class RegisterCommandHandler :BaseHandler,IRequestHandler<RegisterCommandRequest, Unit>
    {
        private readonly AuthRules authRules;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;

        public RegisterCommandHandler(AuthRules authRules,UserManager<User> userManager, RoleManager<Role> roleManager,IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.authRules = authRules;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

       

        public async Task<Unit> Handle(RegisterCommandRequest request,  CancellationToken cancellationToken)
        {
            await authRules.UserShouldNotBeExis(await userManager.FindByEmailAsync(request.Email));
            var map = mapper.Map<User>(request);
            map.UserName = request.Email;
            map.SecurityStamp = Guid.NewGuid().ToString();

            IdentityResult result = await userManager.CreateAsync(map, request.Password);

            if (result.Succeeded)
            {
                await roleManager.CreateAsync(new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "user",
                    NormalizedName = "USER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                });
            }


            return Unit.Value;

           
        }
    }
}
