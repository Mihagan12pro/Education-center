using Auth.Application.Infrastructure.Security;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.Infrastructure.Security;

public static class DependecniesInjection
{
    public static IServiceCollection AddSecurityServices(this IServiceCollection services)
    {
        services.AddTransient<ILoginGenerator, LoginGeneratorV1>();
        services.AddTransient<IPasswordGenerator, PasswordGeneratorV1>();
        services.AddTransient<IHasher, HasherSha256V1>();
        
        return services; 
    }
}