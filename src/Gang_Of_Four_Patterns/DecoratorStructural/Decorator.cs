// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace DecoratorStructural;

/// <summary>
///     Define extra behaviors that can be added to components dynamically.
///     Concrete decorators override methods of the base decorator and execute\
///     their behavior either before or after calling the parent method.
/// </summary>

#region ConcreteDecorators
public class DecoratorA : BaseDecorator
{
    public DecoratorA(IComponent component) : base(component)
    {
    }

    public override void Execute()
    {
        base.Execute();
        ExtraBehaviour();
    }

    private static void ExtraBehaviour()
    {
        Console.WriteLine("DecoratorA.ExtraBehaviour()");
    }
}

public class DecoratorB : BaseDecorator
{
    public DecoratorB(IComponent component) : base(component)
    {
    }

    public override void Execute()
    {
        base.Execute();
        ExtraBehaviour();
    }

    private static void ExtraBehaviour()
    {
        Console.WriteLine("DecoratorB.ExtraBehaviour()");
    }
}

public class DecoratorC : BaseDecorator
{
    public DecoratorC(IComponent component) : base(component)
    {
    }

    public override void Execute()
    {
        base.Execute();
        ExtraBehaviour();
    }

    private static void ExtraBehaviour()
    {
        Console.WriteLine("DecoratorC.ExtraBehaviour()");
    }
}

#endregion
