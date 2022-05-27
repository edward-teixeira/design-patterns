// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace BuilderStructure.Interfaces;

/// <summary>
///     The IBuilder interface declares product construction steps that
///     are common to all types of builders
/// </summary>
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    void Reset();
}
