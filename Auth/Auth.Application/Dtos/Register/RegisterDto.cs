using Auth.Domain.ValueObjects;

namespace Auth.Application.Dtos.Register
{
    public record RegisterDto(
        FullName FullName, 
        Passport Passport);
}
