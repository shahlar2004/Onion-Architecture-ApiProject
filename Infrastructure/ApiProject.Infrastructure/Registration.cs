using ApiProject.Application.Interfaces.Tokens;
using ApiProject.Infrastructure.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Infrastructure
{
    public static class Registration
    {

        public static void AddInfrastructure(this IServiceCollection service, IConfiguration config)
        {
            service.Configure<TokenSettings>(config.GetSection("JWT"));
            service.AddTransient<ITokenService, TokenService>();
            service.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt =>
            {
                opt.SaveToken = true;
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Secret"])),
                    ValidateLifetime = false,
                    ValidIssuer = config["JWT:Secret"],
                    ValidAudience = config["JWT:Secret"],
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
    }
}
