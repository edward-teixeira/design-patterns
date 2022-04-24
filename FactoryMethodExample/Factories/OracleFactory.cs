using FactoryMethodExample.Product;
using FactoryMethodExample.Products;

namespace FactoryMethodExample.Factories;

public sealed record OracleFactory : DbFactory
{
    // Factory Method
    public override DbConnector CreateConnector(string connectionString)
    {
        return new OracleDbConnector(connectionString);
    }
}
