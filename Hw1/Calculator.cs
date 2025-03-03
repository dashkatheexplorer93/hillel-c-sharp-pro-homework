namespace Hillel;

internal static class Calculator
{
    public static double Add(double num1, double num2) => num1 + num2;
    
    public static double Subtract(double num1, double num2) => num1 - num2;
    
    public static double Multiply(double num1, double num2) => num1 * num2;

    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Division by 0 is impossible");
        }

        return num1 / num2;
    }
}