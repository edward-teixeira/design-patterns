// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorExample;

/// <summary>
///     Base Decorator
/// </summary>
public abstract record DataSourceDecorator : DataSource
{
    private readonly DataSource _dataSource;

    protected DataSourceDecorator(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public override void Write(string data)
    {
        _dataSource.Write(data);
    }

    public override string Read()
    {
        return _dataSource.Read();
    }
}
