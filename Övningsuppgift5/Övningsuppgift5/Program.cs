
// Program.Cs får inte vara tom när man gör en migration... xD

using DataAccess;

Console.WriteLine("Bajs");
using var appDbContext = new AppDbContext();


//appDbContext.Author.Add(
//    new()
//    {
//        Name = "Pelle",
//    }
//);
//appDbContext.Author.Add(
//    new()
//    {
//        Name = "Bengt",
//    }
//);
//appDbContext.Author.Add(
//    new()
//    {
//        Name = "Jönsson",
//    }
//);
//appDbContext.SaveChanges();

//appDbContext.Blogs.Add(
//    new()
//    {
//        Title = "Pelles dag",
//        Content = "Idag var en dag"
//    }
//);
//appDbContext.Blogs.Add(
//    new()
//    {
//        Title = "Bengts dag",
//        Content = "Idag var sannerligen en dag"
//    }
//);
//appDbContext.Blogs.Add(
//    new()
//    {
//        Title = "Jönssons dag",
//        Content = "Idag var absolut en dag"
//    }
//);
//appDbContext.SaveChanges();

//var pellesBlog = appDbContext.Author.FirstOrDefault(a => a.Name == "Pelle");
//var blog1 = appDbContext.Blogs.FirstOrDefault(b => b.Title == "Pelles dag");
//pellesBlog.BlogEntries.Add(blog1);
//appDbContext.SaveChanges();

//var bengtsBlog = appDbContext.Author.FirstOrDefault(a => a.Name == "Bengt");
//var jönssonssBlog = appDbContext.Author.FirstOrDefault(a => a.Name == "Jönsson");

//var blog2 = appDbContext.Blogs.FirstOrDefault(b => b.Title == "Bengts dag");
//var blog3 = appDbContext.Blogs.FirstOrDefault(b => b.Title == "Jönssons dag");

//bengtsBlog.BlogEntries.Add(blog2);
//jönssonssBlog.BlogEntries.Add(blog3);
//appDbContext.SaveChanges();

//var entries = appDbContext.Blogs.ToList();

//foreach (var blogs in entries)
//{
//    Console.WriteLine($"{blogs.Title}: {blogs.Content}");
//}

//Console.WriteLine("-----------------------------------\n");

//var authors = appDbContext.Author.ToList();
//foreach (var Authors in authors)
//{
//    Console.WriteLine($"Authors: {Authors.Name}");
//}

var removeAuthorId = appDbContext.Blogs.Where(a => a.ID == 1);


foreach (var Authors in removeAuthorId)
{
    appDbContext.Blogs.Remove(Authors);
}
appDbContext.SaveChanges();



//var removeduplicates = appDbContext.Author.Where(a => a.Id == 1);
//foreach (var Authors in removeduplicates)
//{
//    appDbContext.Author.Remove(Authors);
//}
//appDbContext.SaveChanges();


//Console.WriteLine("-------------------------------\n");

//var changeTitles = appDbContext.Blogs.Find(1);
//changeTitles.Title = "Pelles andra dag";
//appDbContext.SaveChanges();


//appDbContext.Comment.Add(
//    new()
//    {
//        Comments = "Fyfan sicken go blogg",
//    }
//);
//appDbContext.SaveChanges();


//var removecomment = appDbContext.Comment.Find(2);
//appDbContext.Comment.Remove(removecomment);
//appDbContext.SaveChanges();


//var Kommenterare = appDbContext.Comment.FirstOrDefault(a => a.Comments == "Fyfan sicken go blogg");
//var commentedBlog = appDbContext.Blogs.FirstOrDefault(b => b.Title == "Pelles dag");


//commentedBlog.Comments.Add(Kommenterare);
//appDbContext.SaveChanges();