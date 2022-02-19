using MicroStore.ProductAPI.Models;

namespace MicroStore.ProductAPI.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Product Create(Product product);
        Product Update(Product product);
        bool Delete(int id);
    }
}
