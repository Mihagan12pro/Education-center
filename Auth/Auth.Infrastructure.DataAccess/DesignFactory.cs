using Microsoft.EntityFrameworkCore.Design;

namespace Auth.Infrastructure.DataAccess;

internal class DesignFactory
    : IDesignTimeDbContextFactory<AuthDbContext>
{
    public AuthDbContext CreateDbContext(string[] args)
    {
        throw new NotImplementedException();
    }
}