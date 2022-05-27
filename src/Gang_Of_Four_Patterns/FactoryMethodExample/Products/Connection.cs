namespace FactoryMethodExample.Product;

public sealed record Connection(string ConnectionString)
{
    public static bool IsOpened { get; set; }

    public static void ExecuteCommand(string command)
    {
        Console.WriteLine("Executing command: " + command);
    }

    public static void Open()
    {
        IsOpened = true;
        Console.WriteLine("Open Connection");
    }

    public static void Close()
    {
        Console.WriteLine("Connection is closed");
    }
}
