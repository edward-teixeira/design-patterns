using System.Security.Cryptography;
using System.Text;
using FluentInterfaceExample.Security.Enums;
using FluentInterfaceExample.Security.Interfaces;

namespace FluentInterfaceExample.Security;

public class FluentAes : IAesKey, IAesMode, IAesPadding, IAesExecute
{
    private readonly ActionType actionType;
    private readonly string text;
    private CipherMode cipherMode;
    private string key;
    private PaddingMode paddingMode;

    private FluentAes(ActionType actionType, string text)
    {
        this.actionType = actionType;
        this.text = text;

        cipherMode = CipherMode.ECB;
        paddingMode = PaddingMode.PKCS7;
    }

    public IAesMode WithKey(string key)
    {
        this.key = key;

        return this;
    }

    public IAesPadding WithCipherMode(CipherMode cipherMode)
    {
        this.cipherMode = cipherMode;

        return this;
    }

    public string Execute()
    {
        switch (actionType)
        {
            case ActionType.Encrypt:
                return Encrypt();
            case ActionType.Decrypt:
                return Decrypt();
            default:
                throw new InvalidOperationException();
        }
    }

    public IAesExecute WithPaddingMode(PaddingMode paddingMode)
    {
        this.paddingMode = paddingMode;

        return this;
    }

    public static IAesKey Initialize(ActionType action, string text)
    {
        return new FluentAes(action, text);
    }

    private string Encrypt()
    {
        var textAsBites = Encoding.UTF8.GetBytes(text);
        var keyAsBites = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));

        var aes = new AesCryptoServiceProvider {Key = keyAsBites, Mode = cipherMode, Padding = paddingMode};

        var encryptedText = aes
            .CreateEncryptor()
            .TransformFinalBlock(textAsBites, 0, textAsBites.Length);
        aes.Clear();

        return Convert.ToBase64String(encryptedText, 0, encryptedText.Length);
    }

    private string Decrypt()
    {
        var textAsBites = Convert.FromBase64String(text);
        var keyAsBites = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));

        var aes = new AesCryptoServiceProvider {Key = keyAsBites, Mode = cipherMode, Padding = paddingMode};

        var decryptedText = aes
            .CreateDecryptor()
            .TransformFinalBlock(textAsBites, 0, textAsBites.Length);
        aes.Clear();

        return Encoding.UTF8.GetString(decryptedText);
    }
}
