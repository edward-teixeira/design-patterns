using FluentInterfaceExample.Security.Enums;
using FluentInterfaceExample.Security.Interfaces;

namespace FluentInterfaceExample.Security;

public class FluentSecurity : ITextPlain, ITextCipher, ISecurityAlgorithm
{
    private readonly ActionType actionType;
    private string text;

    private FluentSecurity(ActionType actionType)
    {
        this.actionType = actionType;
    }

    public IAesKey UsingAes()
    {
        return FluentAes.Initialize(actionType, text);
    }

    public IRsaKey UsingRsa()
    {
        return FluentRsa.Initialize(actionType, text);
    }

    public ISecurityAlgorithm CipherText(string text)
    {
        this.text = text;

        return this;
    }

    public ISecurityAlgorithm PlainText(string text)
    {
        this.text = text;

        return this;
    }

    public static ITextPlain Encrypt()
    {
        return new FluentSecurity(ActionType.Encrypt);
    }

    public static ITextCipher Decrypt()
    {
        return new FluentSecurity(ActionType.Decrypt);
    }
}
