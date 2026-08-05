using Auth.Domain.ValueObjects;

namespace Auth.Application.Infrastructure.Security;

public interface IPasswordGenerator
{
    Task<string> GenerateAsync(
        Passport passport,
        CancellationToken token);
}