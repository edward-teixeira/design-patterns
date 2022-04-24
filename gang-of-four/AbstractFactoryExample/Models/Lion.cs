using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample.Models;

/// <summary>
///     The 'ProductB1' class
/// </summary>
public class Lion : ICarnivore
{
    public void Eat(IHerbivore h)
    {
        // Eat Wildebeest
        Console.WriteLine(GetType().Name +
                          " eats " + h.GetType().Name);
    }
}
