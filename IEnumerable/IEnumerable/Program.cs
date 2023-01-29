// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

//returns an IEnumerable of int
var filtered = numbers.Where(x => x % 2 == 0);

//returns list of numbers and Query is executed therefor adding number 8 after works won't matter
// If you use ToList() you force the compiler to reify the results right away.
var filteredToList = numbers.Where(x => x % 2 == 0).ToList();  //Lazy execution /

numbers.Add(8);

//Only when to start to iterate filtered gets executed 
//therefore by the time it executes 8 is already in the list
Console.WriteLine("filtered");
foreach (var number in filtered) //Executes one by one
{
    Console.Write($"{number} ");//using string interpolation to create space between numbers
}
Console.WriteLine();
Console.WriteLine("filteredToList");
//
foreach (var number in filteredToList)
{
    Console.Write($"{number} ");
}