using MicroStore.ProductAPI.Context;
using MicroStore.ProductAPI.Contracts;
using MicroStore.ProductAPI.Models;

namespace MicroStore.ProductAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly BaseContext _context;

        public ProductService(BaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            IEnumerable<Product> products = _context.Products;
            return products;
        }

        public Product GetById(int id)
        {
            Product product = _context.Products.Where(x => x.Id == id).First();
            return product;
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public Product Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }

        public bool Delete(int id)
        {
            Product product = _context.Products.Where(p => p.Id == id).First();
            if (product == null) return false;
            _context.Products.Remove(product);
            _context.SaveChangesAsync();
            return true;
        }
    }
}
