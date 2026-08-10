using Auth.Application.Abstraction.Repositories;
using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;
using AuthDomain;

namespace Auth.Infrastructure.DataAccess.Repositories;

public class PostgresWriteUsersRepository : IWriteUsersRepository
{
    private readonly AuthDbContext _context;
    
    public async Task<SuccessRegisterDto> RegisterAsync(
        FullName fullName,
        string password,
        string login, 
        CancellationToken ct)
    {
        User user = new User()
        {
            FirstName = fullName.FirstName,
            
            LastName = fullName.LastName,
            
            Patronymic = fullName.Patronymic,
            
            Password =  password,
            
            Login = login
        };
        
        await _context.Users.AddAsync(user, ct);

        return new SuccessRegisterDto(login, "");
    }

    public PostgresWriteUsersRepository(AuthDbContext context)
    {
        _context = context;
    }
}