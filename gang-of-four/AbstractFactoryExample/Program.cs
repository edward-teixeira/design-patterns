using AbstractFactoryExample;
using AbstractFactoryExample.Factories;

// Create and run the African animal world
var africa = new AnimalWorld<Africa>();
africa.RunFoodChain();

// Create and run the American animal world
var america = new AnimalWorld<America>();
america.RunFoodChain();

// Wait for user input
Console.ReadKey();
