using System.ComponentModel.DataAnnotations;

namespace Auth.Domain.ValueObjects
{
    public record FullName(
        [RegularExpression("^[А-ЯЁа-яё]{3,}$"), MinLength(3), Required] string FirstName,
        [RegularExpression("^[А-ЯЁа-яё]{3,}$"), MinLength(3), Required] string LastName,
        [RegularExpression("^[А-ЯЁа-яё]{5,}$"), MinLength(5)] string? Patronymic)
    {
        public string ShortForm
        {
            get
            {
                char name = FirstName[0];

                if (Patronymic != null)
                {
                    char  patronymic = Patronymic[0];

                    return string.Format("{0} {1}.{2}", LastName, name, patronymic);
                }
                
                return string.Format("{0} {1}", LastName, name);
            }
        }
    }
}
