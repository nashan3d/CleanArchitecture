using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

//using MediatR;

namespace Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            

            return services;
        }
    }
}
