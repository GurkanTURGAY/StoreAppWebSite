using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { ProductId = 1, ProductName = "Computer", Price = 25000 },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 5000 },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 10000 },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 15000 },
                new Product() { ProductId = 5, ProductName = "Deck", Price = 30000 },
                new Product() { ProductId = 6, ProductName = "HeadPhone", Price = 40000 }
            );
        }
    }
}