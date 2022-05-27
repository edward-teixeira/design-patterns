using AbstractFactoryExample.Interfaces;
using AbstractFactoryExample.Models;

namespace AbstractFactoryExample.Factories;

/// <summary>
///     The 'ConcreteFactory2' class.
/// </summary>
public class America : IContinentFactory
{
    /// <inheritdoc />
    public IHerbivore CreateHerbivore()
    {
        return new Bison();
    }

    /// <inheritdoc />
    public ICarnivore CreateCarnivore()
    {
        return new Wolf();
    }
}
