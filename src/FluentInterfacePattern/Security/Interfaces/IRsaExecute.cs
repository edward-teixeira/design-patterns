using System.Security.Cryptography;

namespace FluentInterfaceExample.Security.Interfaces;

public interface IRsaExecute
{
    string ExecuteEncrypt(out RSAParameters privateKey);
    string ExecuteDecrypt();
}
