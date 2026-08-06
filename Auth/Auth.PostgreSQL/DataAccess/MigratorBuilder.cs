using Auth.PostgreSQL.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auth.PostgreSQL;

internal class MigratorBuilder : IMigrationBuilder
{
    private readonly AuthDbContext _authDbContext;
    
    public async Task MigrateAsync()
        => await _authDbContext.Database.MigrateAsync();

    public MigratorBuilder(AuthDbContext authDbContext)
    {
        _authDbContext = authDbContext;
    }
}