using Core;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<CourseDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("SqlCon"));
            });

            services.AddScoped<CourseDbContext>();

            services.AddScoped<IUnitOfWork,UnitOfWork>();

            return services;
        }
    }
}
