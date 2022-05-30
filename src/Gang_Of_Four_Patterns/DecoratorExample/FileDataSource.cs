// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorExample;

/// <summary>
///     Concrete Component
/// </summary>
public record FileDataSource : DataSource
{
    private readonly string _filename;

    public FileDataSource(string filename)
    {
        _filename = filename;
    }

    public override void Write(string data)
    {
        Console.WriteLine(data);
        Console.WriteLine("FileDataSource.Write()");
        Console.WriteLine("-------------------------");
    }

    public override string Read()
    {
        Console.WriteLine("FileDataSource.Read()");
        return "FileDataSource.Read()";
    }
}
