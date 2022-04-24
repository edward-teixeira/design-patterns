using FactoryMethodExample.Product;

namespace FactoryMethodExample.Products;

public sealed record OracleDbConnector: DbConnector
{
    public OracleDbConnector(string connectionString) : base(connectionString)
    {
        ConnectionString = connectionString;
    }

    public override Connection Connect()
    {
        Console.WriteLine("Connecting to Oracle...");
        var connection = new Connection(ConnectionString);
        Connection.Open();

        return connection;
    }
}
