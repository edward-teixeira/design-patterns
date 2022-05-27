// See https://aka.ms/new-console-template for more information
using BuilderStructure;
using BuilderStructure.Models;

/*
 * Using the Builder pattern makes sense only when your products
 * are quite complex and require extensive configuration.
*/
var director = new Director();

var builderA = new ConcreteBuilderA();
var builderB = new ConcreteBuilderB();

director.Build(builderA);
director.Build(builderB);

var prodA = builderA.Result;
var prodB = builderB.Result;

prodA.Show();
prodB.Show();

Console.ReadKey();
