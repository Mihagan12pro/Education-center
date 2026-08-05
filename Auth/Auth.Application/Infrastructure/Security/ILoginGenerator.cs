using Auth.Domain.ValueObjects;

namespace Auth.Application.Infrastructure.Security;

public interface ILoginGenerator
{
    Task<string> GenerateAsync(
        FullName fullName,
        CancellationToken token);
}