using Auth.Application.Abstraction.Repositories;
using Auth.PostgreSQL.DataAccess;
using Auth.PostgreSQL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Auth.PostgreSQL;

public static class DependenciesInjection
{
    public static IServiceCollection AddDbServices(
        this IServiceCollection services, IConfiguration  configuration)
    {
        services.AddDbContext<AuthDbContext>();
        
        services.AddScoped<IMigrationBuilder, MigratorBuilder>();

        services.AddScoped<IWriteUsersRepository, PostgresWriteUsersRepository>();
        services.AddScoped<IReadUsersRepository, PostgresReadUsersRepository>();
        
        return services;
    }
}