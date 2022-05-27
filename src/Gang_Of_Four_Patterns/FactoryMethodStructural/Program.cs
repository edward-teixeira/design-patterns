// An array of creators
using FactoryStructural;

var creators = new Creator[2];

creators[0] = new ConcreteCreatorA();
creators[1] = new ConcreteCreatorB();

// Iterate over creators and create products
foreach (var creator in creators)
{
    var product = creator.FactoryMethod();
    Console.WriteLine("Created {0}", product.GetType().Name);
}

// Wait for user
Console.ReadKey();
