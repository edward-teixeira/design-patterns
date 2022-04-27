// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace BuilderStructure.Models;

/// <summary>
///     Products are resulting objects. Products constructed by differ-
///     ent builders don’t have to belong to the same class hierarchy
///     or interface.
/// </summary>
public record ProductB
{
    private readonly IList<string> _parts = new List<string>();

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("ProductB Parts:");
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}
