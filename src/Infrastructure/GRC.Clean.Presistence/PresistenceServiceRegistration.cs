using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GRC.Clean.Presistence;
public static class Class1
{
    public static IServiceCollection PresistenceServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
