using Microsoft.EntityFrameworkCore;
using OnionArchitectureDemo.Domain.Entities;

namespace OnionArchitectureDemo.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var products = new List<Product>()
        {
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Pen",
                Value = 10,
                Quantity = 100
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Paper A4",
                Value = 1,
                Quantity = 200
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Book",
                Value = 30,
                Quantity = 500
            }
        };
        modelBuilder.Entity<Product>().HasData(products);
    }
}