using AbstractFactoryStructural.Factories;

namespace AbstractFactoryStructural.Products;
/*
 * defines a product objects to be created by the corresponding
 * concrete factory implements the AbstractProduct interface;
 */

/// <summary>
///     The 'ProductA1' class
/// </summary>
public class ProductA1 : AbstractProductA
{
}

/// <summary>
///     The 'ProductA2' class
/// </summary>
public class ProductA2 : AbstractProductA
{
}

/// <summary>
///     The 'ProductB1' class
/// </summary>
public class ProductB1 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(GetType().Name +
                          " interacts with " + a.GetType().Name);
    }
}

/// <summary>
///     The 'ProductB2' class defines a product object to be created by the corresponding concrete factory implements the
///     AbstractProduct interface;
/// </summary>
public class ProductB2 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(GetType().Name +
                          " interacts with " + a.GetType().Name);
    }
}
