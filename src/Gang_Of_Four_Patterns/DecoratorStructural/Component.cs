// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorStructural;

/// <summary>
///     Class of objects being wrapped. It defines the basic behavior,
///     which can be altered by decorators;
/// </summary>
public class Component : IComponent
{
    public void Execute()
    {
        Console.WriteLine("Component.Execute()");
    }
}
