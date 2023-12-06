

using BdFirstDemo;
using BdFirstDemo.Entities;

Console.WriteLine("Halloj planeten Jorden!");


using var KeysDemoDbContext = new KeysDemoDbContext();


var cities = KeysDemoDbContext.Cities.ToList().OrderByDescending(c => c.Id);

foreach (var c in cities)
{
    Console.WriteLine($"ID: {c.Id}, City: {c.Name}, Population: {c.Population}");
}

var country = KeysDemoDbContext.Countries.ToList().OrderByDescending(c => c.Id);
Console.WriteLine("");
Console.WriteLine("---------------------------");

foreach (var countries in country)
{
    Console.WriteLine($"ID: {countries.Id}, City: {countries.Name}, Population: {countries.Population}");
}

//var Tidaholm = new City() { Name = "Tidaholm", Population = 13000 };
//KeysDemoDbContext.Cities.Add(Tidaholm);
//KeysDemoDbContext.SaveChanges();