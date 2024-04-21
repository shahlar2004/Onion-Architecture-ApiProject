using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Persistence.Context;
using ApiProject.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence
{
    public static class Registration
    {

        public static void AddPersistence(this IServiceCollection service, IConfiguration config)
        {
            service.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            service.AddScoped(typeof(IReadRepoitory<>),typeof(ReadRepository<>));
        }
    }
}
