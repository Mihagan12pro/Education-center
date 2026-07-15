using Auth.Domain.ValueObjects;

namespace Auth.Application.Dtos
{
    public record RegisterDto(
        FullName FullName, 
        Passport Passport);
}
