using Hw3;

// Task 1
var myArray = new MyArray([1, 2, 3, 4, 7]);
myArray.Show();
myArray.Show("This is my 5-element array: ");

// Task 2
Console.WriteLine($"Max element of my array is: {myArray.Max()}");
Console.WriteLine($"Min element of my array is: {myArray.Min()}");
Console.WriteLine($"Average number of my array is: {myArray.Avg()}");
Console.WriteLine($"My array contains number 3: {myArray.Search(3)}");
Console.WriteLine($"My array contains number 6: {myArray.Search(6)}");

// Task 3
myArray.SortAsc();
myArray.Show("Sorting my array in ascending order: ");
myArray.SortDesc();
myArray.Show("Sorting my array in descending order: ");
myArray.SortByParam(true);
myArray.Show("Sorting my array when isAsc param is TRUE: ");
myArray.SortByParam(false);
myArray.Show("Sorting my array when isAsc param is FALSE: ");
