using System;
using EFCoreDemo.Data;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // Add a new product
            var product = new Product { Name = "Sample Product", Price = 19.99m };
            context.Products.Add(product);
            context.SaveChanges();

            // Retrieve and display products
            Console.WriteLine("Products in the database:");
            foreach (var p in context.Products)
            {
                Console.WriteLine($"- {p.Name}: ${p.Price}");
            }
        }
    }
}
