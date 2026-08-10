using Auth.Application.Abstraction;
using Auth.Application.Abstraction.Repositories;
using Auth.Application.Dtos.Register;
using Auth.Application.Infrastructure.Security;
using Auth.Domain.Enums;
using Auth.Domain.ValueObjects;

namespace Auth.Application.Implementations
{
    internal class RegisterService : IRegisterService
    {
        private readonly IWriteUsersRepository _writeUsersRepository;  
        private readonly IPasswordGenerator _passwordGenerator;
        private readonly ILoginGenerator _loginGenerator;
        private readonly IHasher _hasher;

        public async Task<SuccessRegisterDto> TryToRegister(
            FullName fullName, 
            Passport passport,
            CancellationToken token)
        {
            var seria = _hasher.Hash(passport.Seria);
            var number = _hasher.Hash(passport.Number);

            string password = _passwordGenerator.Generate(
                passport, 
                Roles.Admin);

            string hashedPassword = _hasher.Hash(password);
            
            string login = _loginGenerator.Generate(
                fullName,
                Roles.Admin);
            
            HashedPassport hashedPassport = new HashedPassport(
                seria,
                number);

            var result = await _writeUsersRepository.RegisterAsync(
                fullName, 
                login,
                hashedPassword,
                token);

            return result;
        }

        public RegisterService(
            IWriteUsersRepository  writeUsersRepository,
            IPasswordGenerator passwordGenerator,
            ILoginGenerator loginGenerator,
            IHasher hasher)
        {
            _writeUsersRepository = writeUsersRepository;
            _passwordGenerator = passwordGenerator;
            _loginGenerator = loginGenerator;
            _hasher = hasher;
        }
    }
}
