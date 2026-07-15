using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Auth.Domain.ValueObjects
{
    public record Passport(
        [RegularExpression(@"^\d{4}$")] string Seria,

        [RegularExpression(@"^\d{8}$")] string Number
    );
}
