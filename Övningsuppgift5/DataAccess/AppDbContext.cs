using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; } = null!; 
    public DbSet<Author> Author { get; set; } = null!;
    public DbSet<Comment> Comment { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source = OLLES;Initial Catalog=BlogDb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
    }
}