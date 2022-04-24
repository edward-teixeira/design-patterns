using AbstractFactoryStructural.Factories;

namespace AbstractFactoryStructural;

/// <summary>
///     The 'Client' class. Interaction environment for the products.
///     uses interfaces declared by AbstractFactory and AbstractProduct classes;
/// </summary>
public class Client
{
    private readonly AbstractProductA _abstractProductA;
    private readonly AbstractProductB _abstractProductB;

    #region ctor

    public Client(AbstractFactory factory)
    {
        _abstractProductB = factory.CreateProductB();
        _abstractProductA = factory.CreateProductA();
    }

    #endregion

    public void Run()
    {
        _abstractProductB.Interact(_abstractProductA);
    }
}
