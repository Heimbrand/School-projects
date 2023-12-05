namespace DataAccess.Entities;

public class Author
{
    public int Id { get; set; }
    public string  Name { get; set; }
    public List<Blog> BlogEntries { get; set; } = new();
}