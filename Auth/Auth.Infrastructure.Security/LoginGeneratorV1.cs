using Auth.Application.Infrastructure.Security;
using Auth.Domain.Enums;
using Auth.Domain.ValueObjects;
using Cyrillic.Convert;

namespace Auth.Infrastructure.Security;

public class LoginGeneratorV1 : ILoginGenerator
{
    public string Generate(
        FullName fullName,
        Roles role)
    {
        Random random = new Random();

        string uniqueSequence = string.Format(
            "{0}{1}{2}{3}", 
            random.Next(9),
            random.Next(9),
            random.Next(9), 
            random.Next(9));
        
        string login = string.Format(
            "{0}!{1}_{2}",
            role,
            fullName.ShortForm.ToRussianLatin(),
            uniqueSequence);

        return login;
    }
}