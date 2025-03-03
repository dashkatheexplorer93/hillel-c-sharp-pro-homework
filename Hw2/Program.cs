using Hw2;

// Task 1
var money = new Money(25,105);
money.DisplayMoneyAmount();

money.SetValue(100, 4);
money.DisplayMoneyAmount();

var product = new Product("Laptop", 9999, 99);
product.DisplayProductInfo();
product.ReducePrice(100, 1);
product.DisplayProductInfo();

Console.WriteLine();

// Task 2
MusicalInstrument[] musicalInstruments = { new Cello(), new Trombone(), new Ukulele(), new Violin() };

foreach (var instrument in musicalInstruments)
{
    instrument.Show();
    instrument.Desc();
    instrument.Sound();
    instrument.History();
    Console.WriteLine();
}

// Task 3
Console.WriteLine("Enter a decimal number: ");
if (!decimal.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Invalid input");
    return;
}

var decimalNumber = new DecimalNumber(number);
decimalNumber.DisplayConversions();