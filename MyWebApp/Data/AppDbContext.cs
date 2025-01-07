using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // For SQLite (uncomment if using SQLite)
            optionsBuilder.UseSqlite("Data Source=EFCoreDemoDB.db");
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
