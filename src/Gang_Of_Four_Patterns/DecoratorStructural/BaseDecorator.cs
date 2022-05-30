// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorStructural;

/// <summary>
///     Maintains a reference to a Component object and defines an interface that conforms to Component's
///     interface The base decorator delegates all operations to the wrapped object.
/// </summary>
public abstract class BaseDecorator : IComponent
{
    private IComponent _componentRef;

    protected BaseDecorator(IComponent component)
    {
        _componentRef = component;
    }

    public IComponent ComponentRef
    {
        set => _componentRef = value;
    }

    public virtual void Execute()
    {
        if (_componentRef is not null)
        {
            _componentRef.Execute();
        }
    }
}
