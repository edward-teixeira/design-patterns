namespace FluentInterfaceExample.Security.Interfaces;

public interface ISecurityKey
{
    ISecurityAlgorithm WithKey(string key);
}
