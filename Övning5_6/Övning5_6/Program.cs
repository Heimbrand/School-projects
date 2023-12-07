

using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
using var appDbContext = new AppDbContext();

//var gronsaksLandet = appDbContext.Suppliers.FirstOrDefault(a => a.Name == "Pelles Frukt");
//var fruit = appDbContext.Products.FirstOrDefault(p => p.Name == "Päron");
//gronsaksLandet.Suppliers.Add(fruit);
//appDbContext.SaveChanges();

//var apelsin = appDbContext.Products.FirstOrDefault(p => p.Name == "Apelsin");
//var categorytwo = appDbContext.Categories.FirstOrDefault(c => c.Name == "Frukt");
//categorytwo.Categories.Add(apelsin);
//appDbContext.SaveChanges();

//var oldCategory = appDbContext.Categories.FirstOrDefault(c=> c.Name == "Stenfrukt");
//appDbContext.Categories.Add((new Category { Name = "invalid" }));
//appDbContext.SaveChanges();

//var removeCategory = appDbContext.Categories.FirstOrDefault(c => c.Name == "invalid");
//appDbContext.Categories.Remove(removeCategory);
//appDbContext.SaveChanges(); 


void AddProduct(string inputtedString, double inputtedDouble)
{
    appDbContext.Products.Add(
        new()
        {
            Name = inputtedString,
            Price = inputtedDouble
        }
    );
    appDbContext.SaveChanges();
}

AddProduct("Hamburgare", 25.50); //Orkar inte göra readlines 

var suppliers = appDbContext.Suppliers.FirstOrDefault(s => s.Name == "Grönsakslandet");

foreach (var product in suppliers.Name)
{
    Console.WriteLine(suppliers.Name);
}




//void RemoveProduct(string inputtedString)
//{
//    if (inputtedString == "Äpple" || 
//        inputtedString == "Banan" || 
//        inputtedString == "Päron" ||
//        inputtedString == "Apelsin")
//    {
        
       
//    }
    
//}
