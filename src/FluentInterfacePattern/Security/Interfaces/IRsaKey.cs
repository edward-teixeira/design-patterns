using System.Security.Cryptography;

namespace FluentInterfaceExample.Security.Interfaces;

public interface IRsaKey
{
    IRsaKeySize WithKey(RSAParameters key = default);
}
