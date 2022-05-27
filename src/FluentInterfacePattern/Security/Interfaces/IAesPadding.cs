using System.Security.Cryptography;

namespace FluentInterfaceExample.Security.Interfaces;

public interface IAesPadding : IAesExecute
{
    IAesExecute WithPaddingMode(PaddingMode paddingMode);
}
