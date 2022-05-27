namespace FluentInterfaceExample.Security.Interfaces;

public interface IAesKey
{
    IAesMode WithKey(string key);
}
