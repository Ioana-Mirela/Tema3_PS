using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
      
        public decimal Price { get; set; }
    }

    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}