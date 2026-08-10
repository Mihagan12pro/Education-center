using System.Security.Cryptography;
using System.Text;
using Auth.Application.Infrastructure.Security;

namespace Auth.Infrastructure.Security;

internal class HasherSha256V1 : IHasher
{
    public string Hash(string str)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(str));

        return Convert.ToHexString(bytes);
    }
}