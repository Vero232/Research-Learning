// See https://aka.ms/new-console-template for more information
using Enumerator;

Console.WriteLine("Hello, World!");

var team = new Team();

var filtered = team.Where(p => p.LastName.Contains('1'));

foreach (var player in filtered) {

   Console.WriteLine(player);
}


