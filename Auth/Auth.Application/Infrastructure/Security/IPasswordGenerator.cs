using Auth.Domain.Enums;
using Auth.Domain.ValueObjects;

namespace Auth.Application.Infrastructure.Security;

public interface IPasswordGenerator
{
    string Generate(
        Passport passport,
        Roles role);
}