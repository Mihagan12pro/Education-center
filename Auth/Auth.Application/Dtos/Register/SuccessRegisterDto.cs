namespace Auth.Application.Dtos.Register
{
    /// <summary>
    /// Contains the login and a message describing the password
    /// </summary>
    /// <param name="Login"></param>
    /// <param name="PasswordMessage"></param>
    public record SuccessRegisterDto(
        string Login, 
        string PasswordMessage);
}
