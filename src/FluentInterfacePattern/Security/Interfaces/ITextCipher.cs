namespace FluentInterfaceExample.Security.Interfaces;

public interface ITextCipher
{
    ISecurityAlgorithm CipherText(string text);
}
