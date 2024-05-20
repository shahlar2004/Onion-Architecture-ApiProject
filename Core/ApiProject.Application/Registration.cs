using ApiProject.Application.Bases;
using ApiProject.Application.Behaviors;
using ApiProject.Application.Exceptions;
using ApiProject.Application.Features.Auth.Rules;
using ApiProject.Application.Features.Products.Rules;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
            services.AddValidatorsFromAssembly(assembly);
            services.AddRulesFromAssemblyContaining(assembly,typeof(BaseRules));
            services.AddTransient<ProductRules>();
            services.AddTransient<AuthRules>();
            ValidatorOptions.Global.LanguageManager.Culture= new CultureInfo("az");
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehavior<,>));


   
        }

        private static IServiceCollection AddRulesFromAssemblyContaining(this IServiceCollection services, Assembly assembly,Type type)
        {
            var types= assembly.GetTypes().Where(t=>t.IsSubclassOf(type) && type!=t).ToList();
            foreach (var item in types)
                services.AddTransient(item);
            return services;
        }
    }
}
