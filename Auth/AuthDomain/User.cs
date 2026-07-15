using System.ComponentModel.DataAnnotations;

namespace AuthDomain
{
    public class User
    {
        public int Id { get; set; }

        [MinLength(3)]
        [Required(AllowEmptyStrings = false)]
        public required string FirstName { get; set; }

        [MinLength(3)]
        [Required(AllowEmptyStrings = false)]
        public required string LastName { get; set; }

        public string? Patronymic { get; set; }

        public required string Password { get; set; }

        public required string Login { get; set; }
    }
}
