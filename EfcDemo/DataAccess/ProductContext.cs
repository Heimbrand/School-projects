using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=OLLES;Initial Catalog=ProductsDemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}