using Microsoft.EntityFrameworkCore;
using MicroStore.ProductAPI.Models;

namespace MicroStore.ProductAPI.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext() { }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options){ }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-N3AACJ8;Database=MicroStore.Product;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
