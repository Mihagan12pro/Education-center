using Auth.Domain.ValueObjects;
using Auth.Domain.Enums;

namespace Auth.Application.Infrastructure.Security;

public interface ILoginGenerator
{
    string Generate(
        FullName fullName,
        Roles role);
}