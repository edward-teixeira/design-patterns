namespace AbstractFactoryExample.Interfaces;

/// <summary>
///     The 'AbstractFactory' interface.
/// </summary>
public interface IContinentFactory
{
    IHerbivore CreateHerbivore();
    ICarnivore CreateCarnivore();
}
