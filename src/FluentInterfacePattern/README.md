## Fluent Interface Pattern

### Definition

Fluent Interface are semantic facades. You put them on top of existing code to reduce syntactical noise and to more
clearly express what the code does in an ubiquitous language. It's a pattern used when building an internal Domain
Specific Language.

An example of a Fluent Interface would be a SQL query builder:

```java
SQLBuilder.select('foo').from('bar').where('foo = ?', 42).prepare();
```

Under the hood of that API lies the code to create an SQL statement. It might include several objects and the calls
shown could very well create a Select object, call a setter on it, create a Condition object and apply it to the Select
object and finally return a Statement object. But all that is hidden from us. This also highlights another aspect of
Fluent Interfaces: they might violate [SOLID](http://en.wikipedia.org/wiki/SOLID_%28object-oriented_design%29)
and [Law of Demeter](http://en.wikipedia.org/wiki/Law_of_Demeter). But since it's a facade on top of code that hopefully
follows these design principles, it doesn't matter that much, because you localize the violations to the Fluent
Interface.

### UML Diagram

![](https://d2z1ksq6nul58p.cloudfront.net/sites/default/files/styles/full/public/images/blog/Design%20and%20implement%20Fluent%20Interface%20pattern%20in%20C%23%20-%20Dimitrie%20Tataru%20-%20ASSIST%20Software.jpg?itok=8a-mz48v)

### Participants

- **Fluent Interface**: Interface that defines how the DSL is going to look like. Fluent interface requires that the
  methods participating in the chain return the same object (or context) to the next method in the chain;
- **Product**: The concrete implementation of the Fluent Interface;

### Sample Code

The prerequisite is to write a class that allows:

- Download to file/stream and upload from file/stream;
- Files transfer between the local computer and Azure Blob Storage;
- Asynchronous transfer, which is not imperative, but may be required later on.

### Tips

- Constructors must be private; do not allow class instantiation.
- Do not allow inheritance; use the [**
  sealed**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed) modifier.
- Use expressive names for methods and arguments; do not use ambiguous or misleading names.
- Use at most one parameter for each method; do not forget that we are going the _fluent way_!

### When and where you would use it

- Client side complexity (and in one case a subtle, but unpleasant code smell) is reduced by moving object construction
  behind a thoughtful, humane interface;
- The returned type varies for each method. This assures flexibility and extensibility;
- Looping can be restrained; methods can be chained in a predetermined order;
- Statements are executed at the end. Chaining is used to collect data and establish paths;

### .NET Framework Example

If you have worked with LINQ, EF Core Fluent API, or ASP.NET Core's Startup class, chances are you have already used
method chaining. Consider the following LINQ code:

```cs
List<Employee> list = new List<Employee>();
...
...
var data = list.Where(e => e.Country == "USA")
               .OrderBy(e => e.EmployeeID)
               .ToList();

```

The above code creates a List of Employee objects and stores certain employees (not shown in the code) in it. Then a
LINQ query picks employees matching certain condition. Notice how various aspects of the LINQ query such as a WHERE
condition and an ORDER BY clause are handled using method chaining. The terminating method ToList() ends the chain by
returning the final list of employees (after applying the previous conditions).

---
Links:
[Fluent Interface Pattern](https://www.codeproject.com/Articles/5326456/Fluent-Interface-Pattern-in-Csharp-With-Inheritanc)
[Domain Specific Language DSL](https://www.jetbrains.com/mps/concepts/domain-specific-languages/)
[Martin Fowler Fluent Interface](https://martinfowler.com/bliki/FluentInterface.html))
[How to Design and Implement the Fluent Interface Pattern in C#](https://assist-software.net/blog/how-design-and-implement-fluent-interface-pattern-c)
[Fluent Interface And Method Chaining In C# For Beginners](http://www.binaryintellect.net/articles/41e7744a-e2ca-49b9-bd36-76e81d0277ae.aspx)

---
[Source](https://github.com/edward-teixeira/design-patterns/tree/master/src/FluentInterfacePattern)
