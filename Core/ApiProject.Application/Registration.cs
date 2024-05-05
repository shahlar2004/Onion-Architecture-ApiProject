using ApiProject.Application.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly= Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg=>cfg.RegisterServicesFromAssembly(assembly));
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
            services.AddAutoMapper(assembly);
            services.AddTransient<ExceptionMiddleware>();
>>>>>>> Stashed changes
=======
            services.AddAutoMapper(assembly);
>>>>>>> 8fba26498a90775508bd2bc25a569296d68046dc
        }
    }
}
