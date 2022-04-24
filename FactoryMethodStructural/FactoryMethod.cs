namespace FactoryStructural;

/// <summary>
/// The 'Product' abstract class
/// </summary>
public abstract class Product
{
    public string Name { get; private set; }
    public double Price { get; private set; }
}

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class ConcreteProductA : Product
{
    public ConcreteProductA()
    {
    }
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class ConcreteProductB : Product
{
    public ConcreteProductB()
    {
    }
}
/// <summary>
/// The 'Creator' abstract class
/// </summary>
public abstract class Creator
{
    public abstract Product FactoryMethod();
}
/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}
/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}
