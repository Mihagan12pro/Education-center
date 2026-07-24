using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;
using CSharpFunctionalExtensions;

namespace Auth.Application.Abstraction
{
    public interface IRegisterService
    {
        Task<HashedPassport> HashPassportAsync(
            Passport passport, 
            CancellationToken token);

        Task<Result<SuccessRegisterDto>> TryToRegister(
            FullName FullName,
            HashedPassport passport,
            CancellationToken token);
    }
}
