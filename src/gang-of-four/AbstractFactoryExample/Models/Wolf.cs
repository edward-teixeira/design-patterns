using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample.Models;

/// <summary>
///     The 'ProductB2' class
/// </summary>
public class Wolf : ICarnivore
{
    public void Eat(IHerbivore h)
    {
        // Eat Bison
        Console.WriteLine(GetType().Name +
                          " eats " + h.GetType().Name);
    }
}
