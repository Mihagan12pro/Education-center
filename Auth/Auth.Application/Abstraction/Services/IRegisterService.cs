using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;

namespace Auth.Application.Abstraction
{
    public interface IRegisterService
    {
        Task<SuccessRegisterDto> TryToRegister(
            FullName FullName,
            Passport passport,
            CancellationToken token);
    }
}
