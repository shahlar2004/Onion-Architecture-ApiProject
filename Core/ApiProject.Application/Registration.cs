using ApiProject.Application.Behaviors;
using ApiProject.Application.Exceptions;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            services.AddAutoMapper(assembly);
            services.AddTransient<ExceptionMiddleware>();
            services.AddAutoMapper(assembly);
            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture= new CultureInfo("az");
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehavior<,>));
        }
    }
}
