using AbstractFactoryStructural.Products;

namespace AbstractFactoryStructural.Factories;

/// <summary>
///     The 'ConcreteFactory' class implements the operations to create concrete product objects;
/// </summary>
public class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}
