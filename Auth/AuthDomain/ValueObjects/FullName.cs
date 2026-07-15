using System.ComponentModel.DataAnnotations;

namespace Auth.Domain.ValueObjects
{
    public record FullName(
        [RegularExpression("^[А-ЯЁа-яё]{3,}$")] string FirstName,

        [RegularExpression("^[А-ЯЁа-яё]{3,}$")] string LastName,

        [RegularExpression("^[А-ЯЁа-яё]{5,}$")] string? Patronymic
    );
}
