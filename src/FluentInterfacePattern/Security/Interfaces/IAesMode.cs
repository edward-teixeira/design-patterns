using System.Security.Cryptography;

namespace FluentInterfaceExample.Security.Interfaces;

public interface IAesMode : IAesExecute
{
    IAesPadding WithCipherMode(CipherMode cipherMode);
}
