namespace Hw6;

internal class Shop(string name, string address, string type) : IDisposable
{
    public void DisplayInfo() =>
        Console.WriteLine($"Name: {name}\nAddress: {address}\nType: {type}\n");

    public void Dispose() =>
        Console.WriteLine($"Shop {name} has been disposed\n");
    
    ~Shop() =>
        Console.WriteLine($"Shop {name} has been destroyed\n");
}