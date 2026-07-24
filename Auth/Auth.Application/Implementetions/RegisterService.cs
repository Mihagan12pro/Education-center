using Auth.Application.Abstraction;
using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;
using CSharpFunctionalExtensions;
using System.Security.Cryptography;
using System.Text;

namespace Auth.Application.Implementetions
{
    internal class RegisterService : IRegisterService
    {
        public async Task<HashedPassport> HashPassportAsync(
            Passport passport, 
            CancellationToken token)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] seria = sha256.ComputeHash(Encoding.UTF8.GetBytes(passport.Seria));
            byte[] number = sha256.ComputeHash(Encoding.UTF8.GetBytes(passport.Number));

            HashedPassport hashedPassport = new HashedPassport(seria, number);

            return hashedPassport;
        }

        public async Task<Result<SuccessRegisterDto>> TryToRegister(
            FullName FullName, 
            HashedPassport passport,
            CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
