using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GRC.Clean.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    
    }
}
