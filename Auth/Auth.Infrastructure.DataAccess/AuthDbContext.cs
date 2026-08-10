using AuthDomain;
using Microsoft.EntityFrameworkCore;

namespace Auth.Infrastructure.DataAccess;

public class AuthDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
        
    }
}