using AbstractFactoryStructural;
using AbstractFactoryStructural.Factories;

/* Entry point into console application. */
var factory1 = new ConcreteFactory1();
var client1 = new Client(factory1);
client1.Run();

var factory2 = new ConcreteFactory2();
var client2 = new Client(factory2);
client2.Run();

Console.ReadKey();
