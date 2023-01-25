using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GRC.Clean.Infrastructure
{
    public static class InfrastructureApplicationRegistration
    {
        public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

    }
}
