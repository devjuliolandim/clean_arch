using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistence
{
    public static class ServicesExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
