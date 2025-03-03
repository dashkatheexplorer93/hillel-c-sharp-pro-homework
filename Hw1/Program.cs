using Hw1;

Console.WriteLine("Welcome to simple calculator!");

Console.Write("Enter the first number: ");
if (!double.TryParse(Console.ReadLine(), out var num1))
{
      Console.WriteLine("Invalid input for the first number");
      return;
}

Console.WriteLine("Choose the operation: +, -, *, / ");
var input = Console.ReadLine();
if (input.Length > 1)
{
    Console.WriteLine("Invalid operation");
    return;
}
var operation = char.Parse(input);

Console.Write("Enter the second number: ");
if (!double.TryParse(Console.ReadLine(), out var num2))
{
    Console.WriteLine("Invalid input for the second number");
    return;
}

try
{
    switch (operation)
    {
        case '+':
            Console.WriteLine($"The result is: {Calculator.Add(num1, num2)}");
            break;
        case '-':
            Console.WriteLine($"The result is: {Calculator.Subtract(num1, num2)}");
            break;
        case '*':
            Console.WriteLine($"The result is: {Calculator.Multiply(num1, num2)}");
            break;
        case '/':
            Console.WriteLine($"The result is: {Calculator.Divide(num1, num2)}");
            break;
        default:
            throw new InvalidOperationException("Invalid operation");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}