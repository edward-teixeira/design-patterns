using FactoryMethodExample.Product;
using FactoryMethodExample.Products;

namespace FactoryMethodExample.Factories;

public sealed record SqlFactory : DbFactory
{
    // Factory Method
    public override DbConnector CreateConnector(string connectionString)
    {
        return new SqlServerConnector(connectionString);
    }
}
