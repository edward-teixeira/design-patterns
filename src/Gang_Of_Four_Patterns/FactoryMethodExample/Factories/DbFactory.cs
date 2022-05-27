using FactoryMethodExample.Product;
using FactoryMethodExample.Products;

namespace FactoryMethodExample.Factories;

/// <summary>
///     Creator
/// </summary>
public abstract record DbFactory
{
    /// <summary>
    ///     Factory Method
    /// </summary>
    /// <param name="connectionString"></param>
    /// <returns></returns>
    public abstract DbConnector CreateConnector(string connectionString);

    public static DbFactory Database(DataBase dataBase)
    {
        return dataBase switch
        {
            DataBase.SqlServer => new SqlFactory(),
            DataBase.Oracle => new OracleFactory(),
            _ => throw new ApplicationException("Unknown Database.")
        };
    }
}
