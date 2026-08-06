using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;

namespace Auth.Application.Abstraction.Repositories;

public interface IWriteUsersRepository
{
    Task<SuccessRegisterDto> RegisterAsync(
        FullName fullName,
        HashedPassport passport,
        string password,
        string login,
        CancellationToken ct);
}