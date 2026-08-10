using Auth.Application.Infrastructure.Security;
using Auth.Domain.Enums;
using Auth.Domain.ValueObjects;

namespace Auth.Infrastructure.Security;

public class PasswordGeneratorV1 : IPasswordGenerator
{
    public string Generate(
        Passport passport,
        Roles role)
    {
        string password = string.Format(
            "{0}!{1}_{2}", 
            role,
            passport.Seria, 
            passport.Number);
        
        return password;
    }
}