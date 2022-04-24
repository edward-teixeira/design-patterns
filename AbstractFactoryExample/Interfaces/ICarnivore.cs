namespace AbstractFactoryExample.Interfaces;

/// <summary>
///     The 'AbstractProductB' interface
/// </summary>
public interface ICarnivore
{
    void Eat(IHerbivore h);
}
