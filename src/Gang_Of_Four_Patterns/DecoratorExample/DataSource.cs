// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorExample;

/// <summary>
///     Component
/// </summary>
public abstract record DataSource
{
    public abstract void Write(string data);
    public abstract string Read();
}
