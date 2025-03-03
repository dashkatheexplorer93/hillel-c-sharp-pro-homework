namespace Hw2;

internal class Money
{
    private int _wholePart;
    private int _fractionalPart;
    private const int ConversionRate = 100;

    public Money(int whole = 0, int fractional = 0)
    {
        SetValue(whole, fractional);
    }

    public void SetValue(int whole, int fractional)
    {
        if (fractional >= ConversionRate)
        {
            whole += fractional / ConversionRate;
            fractional %= ConversionRate;
        } 
        _wholePart = whole; 
        _fractionalPart = fractional;
    }

    public void DisplayMoneyAmount()
    {
        Console.WriteLine($"Money amount: {_wholePart}.{_fractionalPart:D2}");
    }
    
    public decimal GetTotalAmount()
    { 
        var fractionalResult = _fractionalPart / (decimal)ConversionRate;
        fractionalResult = Math.Round(fractionalResult, 2); 
        return _wholePart + fractionalResult;
    }
}