using AbstractFactoryStructural.Factories;

namespace AbstractFactoryStructural.Products;

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
