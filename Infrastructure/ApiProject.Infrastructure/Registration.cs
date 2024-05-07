using ApiProject.Infrastructure.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        }   
    }
}
