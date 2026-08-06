using AuthDomain;
using Microsoft.EntityFrameworkCore;

namespace Auth.PostgreSQL;

public class AuthDbContext : DbContext
{
    public User User { get; set; }
}