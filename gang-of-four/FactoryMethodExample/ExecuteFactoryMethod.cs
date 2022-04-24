using FactoryMethodExample.Factories;
using FactoryMethodExample.Product;
using FactoryMethodExample.Products;

namespace FactoryMethodExample;

/// <summary>
///     Client
/// </summary>
public static class ExecuteFactoryMethod
{
    public static void Exec()
    {
        var sqlServerConn = DbFactory.Database(DataBase.SqlServer)
            .CreateConnector("myConnectionString")
            .Connect();
        var oracleConn = DbFactory.Database(DataBase.Oracle)
            .CreateConnector("myConnectionString")
            .Connect();

        Connection.ExecuteCommand("select * from sqlTable");
        Connection.Close();

        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");

        Connection.ExecuteCommand("select * from oracleTable");
        Connection.Close();
    }
}
