using Auth.Application.Abstraction.Repositories;
using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;

namespace Auth.PostgreSQL.Repositories;

public class PostgresWriteUsersRepository : IWriteUsersRepository
{
    public Task<SuccessRegisterDto> RegisterAsync(
        FullName fullName,
        HashedPassport passport,
        string password,
        string login, 
        CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}