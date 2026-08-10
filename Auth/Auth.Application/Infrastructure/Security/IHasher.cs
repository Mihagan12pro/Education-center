namespace Auth.Application.Infrastructure.Security;

public interface IHasher
{
    public string Hash(string str);
}