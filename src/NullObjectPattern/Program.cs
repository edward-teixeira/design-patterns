// See https://aka.ms/new-console-template for more information
using NullObjectPattern;

var sarah = new PlayerCharacter(new DiamondSkinDefence()) {Name = "Sarah"};

var amrit = new PlayerCharacter(new IronBonesDefence()) {Name = "Amrit"};

var gentry = new PlayerCharacter(SpecialDefence.Null) {Name = "Gentry"};

sarah.Hit(10);
amrit.Hit(10);
gentry.Hit(10);


Console.ReadLine();
