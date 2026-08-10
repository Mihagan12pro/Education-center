using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;

namespace Auth.Application.Abstraction.Repositories;

public interface IWriteUsersRepository
{
    Task<SuccessRegisterDto> RegisterAsync(
        FullName fullName,
        string password,
        string login,
        CancellationToken ct);
}