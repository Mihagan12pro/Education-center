using System.Security.Cryptography;
using System.Text;
using Auth.Application.Abstraction;
using Auth.Application.Abstraction.Repositories;
using Auth.Application.Dtos.Register;
using Auth.Application.Infrastructure.Security;
using Auth.Domain.ValueObjects;

namespace Auth.Application.Implementations
{
    internal class RegisterService : IRegisterService
    {
        private readonly IWriteUsersRepository _writeUsersRepository;  
        private readonly IPasswordGenerator _passwordGenerator;
        private readonly ILoginGenerator _loginGenerator;

        public async Task<SuccessRegisterDto> TryToRegister(
            FullName fullName, 
            Passport passport,
            CancellationToken token)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] seria = sha256.ComputeHash(Encoding.UTF8.GetBytes(passport.Seria));
            byte[] number = sha256.ComputeHash(Encoding.UTF8.GetBytes(passport.Number));

            string password = await _passwordGenerator.GenerateAsync(passport, token);
            string login = await _loginGenerator.GenerateAsync(fullName, token);
            
            HashedPassport hashedPassport = new HashedPassport(seria, number);

            var result = await _writeUsersRepository.RegisterAsync(
                fullName, 
                hashedPassport,
                login,
                password,
                token);

            return result;
        }

        public RegisterService(
            IWriteUsersRepository  writeUsersRepository,
            IPasswordGenerator passwordGenerator,
            ILoginGenerator loginGenerator)
        {
            _writeUsersRepository = writeUsersRepository;
            _passwordGenerator = passwordGenerator;
            _loginGenerator = loginGenerator;
        }
    }
}
