using RulesEnginePattern;


var engine = new RulesEngine<Person>();

var personShouldNotBeNull = new Rule<Person>(person => person is not null);
engine.AddRule(personShouldNotBeNull);

Person tim = null;

engine.Run(tim);

public record Person(string Name);
