namespace FluentInterfaceExample.Security.Interfaces;

public interface ITextPlain
{
    ISecurityAlgorithm PlainText(string text);
}
