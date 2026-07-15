namespace AuthDomain
{
    public class User
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string? Patronymic { get; set; }

        public required string Password { get; set; }

        public required string Login { get; set; }
    }
}
