
using ApiProject.Persistence;
using ApiProject.Mapper;
using ApiProject.Application;
using ApiProject.Infrastructure;
using ApiProject.Application.Exceptions;
using Microsoft.OpenApi.Models;
using ApiProject.Application.Interfaces.Tokens;
using ApiProject.Infrastructure.Tokens;
using Microsoft.AspNetCore.Identity;
using ApiProject.Domain.Entities;
using ApiProject.Persistence.Context;


namespace ApiProject.Api

{
    public class Program
    { 
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();


            var env = builder.Environment;

            builder.Configuration.SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);


            builder.Services.AddPersistence(builder.Configuration);
            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddApplication();

            builder.Services.AddIdentity<User, Role>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            builder.Services.AddCustomerMapper();

            builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project API", Version = "v1", Description = "Project API swagger client" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = @"'Bearer' yazıb boşluq buraxdıqdan sonra Token'i girəbilərsiz "
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference= new OpenApiReference
                                {
                                    Type= ReferenceType.SecurityScheme,
                                    Id="Bearer"
                                }
                            },

                            Array.Empty<string>()
                        }
                    });
            });



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.ConfigureExceptionHandlingMiddleware();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
