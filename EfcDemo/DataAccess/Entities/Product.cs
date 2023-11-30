using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Product
{
    [Key]
    public int ID { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }

}