using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample;

/// <summary>
///     The 'Client' class
/// </summary>
public sealed record AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
{
    private readonly ICarnivore _carnivore;
    private readonly IHerbivore _herbivore;

    /// <summary>
    ///     Contructor of Animalworld
    /// </summary>
    public AnimalWorld()
    {
        // Create new continent factory
        IContinentFactory factory = new T();
        // Factory creates carnivores and herbivores
        _carnivore = factory.CreateCarnivore();
        _herbivore = factory.CreateHerbivore();
    }

    /// <summary>
    ///     Runs the foodchain: carnivores are eating herbivores.
    /// </summary>
    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}
