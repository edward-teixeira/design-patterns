## Factory Method

### Definition
Define an interface for creating an object, but let subclasses decide which
class to instantiate. Factory Method lets a class defer instantiation to
subclasses.

### UML Class Diagram
![img.png](img.png)![img_1.png](resources/img_1.png)

### Participants
The classes and/or objects participating in this pattern are:

- **Product (DbConnector)**: defines the interface of objects the factory method creates;
- **ConcreteProduct (OracleDbConnector , SqlServerConnector)**: implements the Product interface;
- **Creator (DbFactory)**: declares the factory method, which returns an object of type Product. Creator may also define a default implementation 
of the factory method that returns a default ConcreteProduct object;
- **ConcreteCreator (OracleFactory, SqlFactory)**: overrides the factory method to return an instance of a ConcreteProduct.;

### Sample Code
The structural code demonstrates the Factory method offering great flexibility in creating
different objects. The Abstract class may provide a default object, but each subclass can
instantiate an extended version of the object.

### Abstract Factory: when and where you would use it

Class constructors exist so that clients can create instances of a class. However, there
are situations, where the client does not, or should not, know which one of several
candidate classes to instantiate. The Factory Method allows the client to use an
interface for creating an object while still retaining control over which class to instantiate.
The key objective of the Factory Method is extensibility. Factory Methods are frequently
used in applications that manage, maintain, or manipulate collections of objects that are
different but at the same time have many characteristics in common.
A document management system, for example, is more extensible by referencing the
documents as a collection of IDocuments. These documents may be Text files, Word
documents, Visio diagrams, or legal papers. They are different but each one has an
author, a title, a type, a size, a location, a page count, etc. When a new document type is
introduced it simply implements the IDocument interface and it will work like the rest of
the documents. To support this new document type the Factory Method may or may not
have to be adjusted (depending on how it was implemented, i.e. with or without
parameters). The example below would need adjustment.

````c#
public class DocumentFactory
{
    // Factory method with parameter
    public IDocument CreateDocument(DocumentType docType)
    {
        IDocument document = null;
        switch(docType)
        {
          case DocumentType.Word:
          document = new WordDocument();
          break;
          case DocumentType.Excel:
          document = new ExcelDocument();
          break;
          case DocumentType.Visio:
          document = new VisioDocument();
          break;
        }
        return document;
    }
}
````
Factory Methods are frequently used in ‘manager’ type components, such as, document
managers, account managers, permission managers, custom control managers, etc.
In your own projects you probably have methods that return new objects. However, they
may or may not be Factory methods. How to you know when a method is a Factory
Method?
The rules are:
- the method creates a new object;
- the method returns an abstract class or interface;
- the abstract class or interface is implemented by several classes;

### Abstract Factory in the .NET Framework

The Factory Method is frequently used in .NET. An example is the System.Convert
class which exposes many static methods that, given an instance of a type, returns
another new type. For example, Convert.ToBoolean accepts a string and returns a
boolean which value depends on the incoming string value (“true” or “false”). Likewise
the Parse method on many built-in value types (Int32, Double, etc.) is an example of the
same pattern.
```c#
string myString = "true";
bool myBool = Convert.ToBoolean(myString);
```
In .NET the Factory Method is typically implemented as a static method that creates an
instance of a particular type determined at compile time. In other words, these methods
don’t return base classes or interface types of which the true type is only known at
runtime. This is exactly where Abstract Factory and Factory Method differ: Abstract
Factory methods are virtual or abstract and return abstract classes or interfaces. Factory
Methods are abstract and return object types.

Two static factory method examples are File.Open and Activator.Create

```c#
public class File
{
  public static FileStream Open(string path, FileMode mode){ }
};
```
```c#
public static class Activator
{
  public static object Create(Type type) { }
}
```
