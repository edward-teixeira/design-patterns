// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorExample;

/// <summary>
///     Concrete Decorators
/// </summary>
public record EncryptionDecorator : DataSourceDecorator
{
    public EncryptionDecorator(DataSource dataSource) : base(dataSource) { }

    public override void Write(string data)
    {
        // 1. Encrypt passed data.
        var encryptedData = Encrypt(data);
        // 2. Pass encrypted data to the wrappee's writeData method
        base.Write(encryptedData);
    }

    public override string Read()
    {
        // 1. Get data from the wrappee's readData method.
        var data = base.Read();
        // 2. Try to decrypt it if it's encrypted.
        var decryptedData = Decrypt(data);
        // 3. Return the result
        return decryptedData;
    }

    private static string Encrypt(string data)
    {
        Console.WriteLine("EncryptionDecorator.Encrypt(data)");
        return data;
    }

    private static string Decrypt(string data)
    {
        Console.WriteLine("EncryptionDecorator.Decrypt(data)");
        return data;
    }
}
