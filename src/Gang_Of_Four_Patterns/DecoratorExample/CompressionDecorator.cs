// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorExample;

/// <summary>
///     Concrete Decorator
/// </summary>
public record CompressionDecorator : DataSourceDecorator
{
    public CompressionDecorator(DataSource dataSource) : base(dataSource) { }

    public override void Write(string data)
    {
        // 1. Compress passed data
        var compressedData = Compress(data);
        // 2. Pass compressed data to the wrappee's writeData method
        base.Write(compressedData);
    }

    public override string Read()
    {
        // 1. Get data from the wrappee's readData method.
        var data = base.Read();
        // 2. Try to decompress it if it's compressed
        var decompressedData = Decompress(data);
        // 3. Return the result.
        return decompressedData;
    }

    private static string Decompress(string data)
    {
        Console.WriteLine("CompressionDecorator.Decompress(data)");
        return data;
    }

    private static string Compress(string data)
    {
        Console.WriteLine("CompressionDecorator.Compress(data)");
        return data;
    }
}
