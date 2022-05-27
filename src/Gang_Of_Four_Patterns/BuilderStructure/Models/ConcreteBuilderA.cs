// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
using BuilderStructure.Interfaces;

namespace BuilderStructure.Models;

/// <summary>
/// Concrete Builders provide different implementations of the
/// construction steps. Concrete builders may produce products
// that don’t follow the common interface.
/// </summary>
public class ConcreteBuilderA : IBuilder
{
    public ProductA Result { get; private set; } = new();

    public void BuildPartA()
    {
        Result.AddPart("PartA");
    }

    public void BuildPartB()
    {
        Result.AddPart("PartB");
    }

    public void BuildPartC()
    {
        Result.AddPart("PartC");
    }

    public void Reset()
    {
        Result = new ProductA();
    }
}
