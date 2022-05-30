// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorStructural;

/// <summary>
///     Declares the common interface for both wrappers and wrapped objects;
/// </summary>
public interface IComponent
{
    void Execute();
}
