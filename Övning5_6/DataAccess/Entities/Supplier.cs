using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Supplier
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string ContactInformation { get; set; }
    public List<Product> Suppliers { get; set; } = new();
}