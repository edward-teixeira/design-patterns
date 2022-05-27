using BuilderExample;
using BuilderExample.Builders;

var shop = new Shop();

var carBuilder = new CarBuilder();
var motorcycleBuilder = new MotorCycleBuilder();

shop.Build(carBuilder);
var car = carBuilder.Vehicle;
car.Show();

shop.Build(motorcycleBuilder);
var motorcycle = motorcycleBuilder.Vehicle;
motorcycle.Show();

Console.ReadKey();
