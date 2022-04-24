using FactoryMethodExample.Product;

namespace FactoryMethodExample.Products;

public sealed record SqlServerConnector : DbConnector
{
    public SqlServerConnector(string connectionString) : base(connectionString)
    {
        ConnectionString = connectionString;
    }

    public override Connection Connect()
    {
        Console.WriteLine("Connecting to SQL Server...");
        var connection = new Connection(ConnectionString);
        Connection.Open();

        return connection;
    }
}
