namespace FluentInterfaceExample.Security.Interfaces;

public interface IRsaKeySize : IRsaExecute
{
    IRsaPadding WithKeySize(int keySize);
}
