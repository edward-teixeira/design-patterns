using AbstractFactoryStructural.Factories;

namespace AbstractFactoryStructural.Products;

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
