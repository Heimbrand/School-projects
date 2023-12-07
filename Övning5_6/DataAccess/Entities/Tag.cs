namespace DataAccess.Entities;

public class Tag
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> givenTags { get; set; } = new();
}