// See https://aka.ms/new-console-template for more information
using DecoratorStructural;

// Create ConcreteComponent and Decorators
var comp = new Component();
var decoratorA = new DecoratorA(comp);
// Link decorators
var decoratorB = new DecoratorB(decoratorA);
var decoratorC = new DecoratorC(decoratorB);

decoratorC.Execute();
/*
 * Output:
 * Component.Execute()
 * DecoratorA.ExtraBehaviour()
 * DecoratorB.ExtraBehaviour()
 * DecoratorC.ExtraBehaviour()
 */
