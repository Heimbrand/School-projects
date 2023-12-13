

using System.Reflection.Metadata;
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


void AddCategorie(string inputtedString)
{
    appDbContext.Categories.Add(
        new()
        {
            Name = inputtedString,

        }
    );
    appDbContext.SaveChanges();
} //lägger till en kategori

//AddCategorie("Mat"); 

void ProductDetails(string categoryNames)
{
    var cateGories = appDbContext.Categories.
        Include(c => c.Categories).
        FirstOrDefault(c => c.Name == categoryNames);

    foreach (var noumberOfCategories in cateGories.Categories)
    {
        Console.WriteLine($"Product: {noumberOfCategories.Name}, Price:{noumberOfCategories.Price}");
    }
} //Skriver ut alla produkter med inputtens valda kategori

//ProductDetails("Stenfrukt");

void ShowCategories()
{
    var rnadom = appDbContext.Categories.ToList();
    foreach (var prod in rnadom)
    {

        Console.WriteLine(prod.Name);
    }
} //Visar alla befintliga kategorier

void DeleteCategory(int CategoryId)
{
    var deletedCategory = appDbContext.Categories.
        Include(c => c.Categories).
        FirstOrDefault(c => c.ID == CategoryId);
    deletedCategory.Categories.Clear();
    appDbContext.Remove(deletedCategory);
    appDbContext.SaveChanges();
} // Tar bort kategorier

//DeleteCategory(1);


void ProductSupplier(int supplierId)
{
    var productSupplier = appDbContext.Suppliers
        .Include(s => s.Suppliers)
        .FirstOrDefault(s => s.ID == supplierId);
    foreach (var supplier in productSupplier.Suppliers)
    {
        Console.WriteLine($"{supplier.Name}");
    }
} // Skriver ut alla produkter med från vald leverantörsId

//ProductSupplier(1);

void AddSupplier()
{
    appDbContext.Suppliers.Add(
        new()
        {

            Name = "Bengans pengatvätt",
            ContactInformation = "Bengan.IllegalPengaTvätt@hotmail.com"

        }

    );
    appDbContext.SaveChanges();
} // lägger till nya suppliers

void UpdateSupplier(int supplierID, string newSupplierName, string newSupplierMail)
{
    var updatedSupplier = appDbContext.Suppliers.FirstOrDefault(s => s.ID == supplierID);
    updatedSupplier.Name = newSupplierName;
    updatedSupplier.ContactInformation = newSupplierMail;
    appDbContext.SaveChanges();
}


//appDbContext.Tags.Add(new() { Name = "Fresh" });
//appDbContext.Tags.Add(new() { Name = "Healthy" });
//appDbContext.Tags.Add(new() { Name = "Green" });
//appDbContext.Tags.Add(new() { Name = "Vegan" });
//appDbContext.Tags.Add(new() { Name = "Crunchy" });
//appDbContext.Tags.Add(new() { Name = "Yummy" });
//appDbContext.Tags.Add(new() { Name = "Borgir" });
//appDbContext.SaveChanges();

void AddTagsToProducts(int productId, List<int> tagIds)
{
    var product = appDbContext.Products
        .Include(p => p.Tags)
        .FirstOrDefault(p => p.ID == productId);

    var tags = product.Tags.Where(t => tagIds.Contains(t.Id)).ToList();

    foreach (var tag in tags)
    {
        tag.givenTags.Add(product);
        appDbContext.SaveChanges();
    }
}
List<int> tagsToAdd = new() { 1, 2, 3 };
AddTagsToProducts(1, tagsToAdd);
appDbContext.SaveChanges();




void ShowTags()
{
    var rnadom = appDbContext.Tags.ToList();
    foreach (var prod in rnadom)
    {

        Console.WriteLine($"ID: {prod.Id}, TAG: {prod.Name} ");
    }
} //Visar taggar

