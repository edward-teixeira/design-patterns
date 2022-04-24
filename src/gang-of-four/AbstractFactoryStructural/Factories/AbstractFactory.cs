namespace AbstractFactoryStructural.Factories;

/// <summary>
///     The 'AbstractFactory' declares an interface for operations that create abstract products
/// </summary>
public abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}
