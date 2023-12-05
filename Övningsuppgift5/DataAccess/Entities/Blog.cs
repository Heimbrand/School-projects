
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Blog
{
    [Key]
    public int ID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public List<Comment> Comments { get; set; } = new();

}