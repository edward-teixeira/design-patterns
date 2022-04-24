namespace FactoryMethodExample.Product;
public sealed record Connection(string ConnectionString)
{
    private static bool _isOpened;
    public static bool IsOpened
    {
        get => _isOpened;
        set => _isOpened = value;
    }
    public static void ExecuteCommand(string command)
        => Console.WriteLine("Executing command: " + command);
    public static void Open()
    {
        IsOpened = true;
        Console.WriteLine("Open Connection");
    }
    public static void Close() => Console.WriteLine("Connection is closed");
}
