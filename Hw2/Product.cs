namespace Hw2;

internal class Product
{
    private readonly string _name;
    private readonly Money _price;
    
    public Product(string name, int whole, int fractional)
    {
        _name = name;
        _price = new Money(whole, fractional);
    }
    public void ReducePrice(int whole, int fractional)
    {
        var newPrice = _price.GetTotalAmount() - (decimal)(whole + fractional / 100.0);
        if (newPrice < 0)
        {
            Console.WriteLine("The price cannot be negative, the discount is not applied");
            return;
        }

        var newWhole = (int)newPrice;
        var newFractional = (int)((newPrice - newWhole) * 100);
        _price.SetValue(newWhole, newFractional);
    }
    
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product name: {_name}");
        _price.DisplayMoneyAmount();
    }
}