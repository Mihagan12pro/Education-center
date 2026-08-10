using Auth.Application.Abstraction.Repositories;
using Auth.Infrastructure.DataAccess.Repositories;
using Auth.Infrastructure.DataAccess;
using Auth.PostgreSQL.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Auth.Infrastructure.DataAccess;

public static class DependenciesInjection
{
    public static IServiceCollection AddDbServices(
        this IServiceCollection services,
        IConfigurationSection dbSection)
    {
        services.AddDbContext<AuthDbContext>((options) =>
        {
            options.UseNpgsql(dbSection.GetConnectionString("DefaultConnection"));
        });
        
        services.AddScoped<IMigrationBuilder, MigratorBuilder>();

        services.AddScoped<IWriteUsersRepository, PostgresWriteUsersRepository>();
        services.AddScoped<IReadUsersRepository, PostgresReadUsersRepository>();
        
        return services;
    }
}