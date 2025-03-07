using Hw4;

// Task 1
var employee1 = new Employee("John", "Manager", 50000);
var employee2 = new Employee("Maggie", "Assistant", 20000);
Console.WriteLine(employee1.ToString());
Console.WriteLine(employee2.ToString());
Console.WriteLine($"New salary for {employee1.Name} is {employee1 + 16000:C}");
Console.WriteLine($"New salary for {employee2.Name} is {employee2 - 1000:C}");
Console.WriteLine($"Are {employee1.Name} and {employee2.Name} salary equal? {employee1 == employee2}");
Console.WriteLine($"Are {employee1.Name} and {employee2.Name} salary not equal? {employee1 != employee2}");
Console.WriteLine($"Is {employee1.Name}'s salary higher than {employee2.Name}'s? {employee1 > employee2}");
Console.WriteLine($"Is {employee1.Name}'s salary lower than {employee2.Name}'s? {employee1 < employee2}");
Console.WriteLine($"Are {employee1.Name} and {employee2.Name} salary equal? {employee1.Equals(employee2)}");

// Task 2
Console.WriteLine();
var city1 = new City("New York", 8000000);
var city2 = new City("Los Angeles", 4000000);
Console.WriteLine(city1.ToString());
Console.WriteLine(city2.ToString());
Console.WriteLine($"New population for {city1.Name} is {city1 + 800000:N0}");
Console.WriteLine($"New population for {city2.Name} is {city2 - 70000:N0}");
Console.WriteLine($"Are {city1.Name} and {city2.Name} population equal? {city1 == city2}");
Console.WriteLine($"Are {city1.Name} and {city2.Name} population not equal? {city1 != city2}");
Console.WriteLine($"Is {city1.Name} population higher than {city2.Name}? {city1 > city2}");
Console.WriteLine($"Is {city1.Name} population lower than {city2.Name}? {city1 < city2}");
Console.WriteLine($"Are {city1.Name} and {city2.Name} population equal? {city1.Equals(city2)}");

// Task 3
Console.WriteLine();
var card1 = new CreditCard("1234-5678-9012-3456", new DateTime(2029, 12, 31), 123, 100);
var card2 = new CreditCard("9876-5432-1098-7654", new DateTime(2028, 3, 31), 123, 30000);
Console.WriteLine(card1.ToString());    
Console.WriteLine(card2.ToString());
Console.WriteLine($"New balance for {card1.CardNumber} is {card1 + 9900:C}");
Console.WriteLine($"New population for {card2.CardNumber} is {card2 - 20000:C}");
Console.WriteLine($"Are {card1.CardNumber} and {card2.CardNumber} CVC equal? {card1 == card2}");
Console.WriteLine($"Are {card1.CardNumber} and {card2.CardNumber} CVC not equal? {card1 != card2}");
Console.WriteLine($"Is {card1.CardNumber} balance higher than {card2.CardNumber}? {card1 > card2}");
Console.WriteLine($"Is {card1.CardNumber} balance lower than {card2.CardNumber}? {card1 < card2}");
Console.WriteLine($"Are {card1.CardNumber} and {card2.CardNumber} balance equal? {card1.Equals(card2)}");

