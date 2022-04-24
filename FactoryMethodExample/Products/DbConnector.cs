namespace FactoryMethodExample.Product;

/// <summary>
/// Abstract Product
/// </summary>
public abstract record DbConnector(string ConnectionString)
{
    protected string ConnectionString { get; set; } = ConnectionString;
    public abstract Connection Connect();
}
