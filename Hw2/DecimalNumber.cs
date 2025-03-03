namespace Hw2;

readonly struct DecimalNumber
{
    private readonly decimal _number;

    public DecimalNumber(decimal number)
    {
        _number = number;
    }

    private string ToBinary()
    {
        return Convert.ToString((long)_number, 2);
    }

    private string ToOctal()
    {
        return Convert.ToString((long)_number, 8);
    }

    private string ToHex()
    {
        return Convert.ToString((long)_number, 16);
    }
    
    public void DisplayConversions()
    {
        Console.WriteLine($"Decimal number is: {_number}");
        Console.WriteLine($"Binary representation is: {ToBinary()}");
        Console.WriteLine($"Octal representation is: {ToOctal()}");
        Console.WriteLine($"Hexadecimal representation is: {ToHex()}");
    }
}