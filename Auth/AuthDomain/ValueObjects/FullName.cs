using System.ComponentModel.DataAnnotations;

namespace Auth.Domain.ValueObjects
{
    public record FullName(
        [RegularExpression("^[А-ЯЁа-яё]{3,}$"), MinLength(3), Required] string FirstName,

        [RegularExpression("^[А-ЯЁа-яё]{3,}$"), MinLength(3), Required] string LastName,

        [RegularExpression("^[А-ЯЁа-яё]{5,}$"), MinLength(5)] string? Patronymic
    );
}
