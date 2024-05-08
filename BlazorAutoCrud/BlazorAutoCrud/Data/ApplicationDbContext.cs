using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BlazorAutoCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Product> products = new();
            for (int i = 1; i <= 10; i++)
            {
                products.Add(new Product { Id = i, Name = $"Name {i}", Quantity = i });
            }
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}
