using System.Security.Cryptography;

namespace FluentInterfaceExample.Security.Interfaces;

public interface IRsaPadding : IRsaExecute
{
    IRsaExecute WithPadding(RSAEncryptionPadding rsaPadding);
}
