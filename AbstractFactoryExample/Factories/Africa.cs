using AbstractFactoryExample.Interfaces;
using AbstractFactoryExample.Models;

namespace AbstractFactoryExample.Factories;

/// <summary>
///     The 'ConcreteFactory1' class.
/// </summary>
public class Africa : IContinentFactory
{
    /// <inheritdoc />
    public IHerbivore CreateHerbivore()
    {
        return new Wildebeest();
    }

    /// <inheritdoc />
    public ICarnivore CreateCarnivore()
    {
        return new Lion();
    }
}
