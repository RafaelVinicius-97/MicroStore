using Microsoft.AspNetCore.Mvc;
using MicroStore.ProductAPI.Contracts;
using MicroStore.ProductAPI.Models;

namespace MicroStore.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new
                ArgumentNullException(nameof(productService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            IEnumerable<Product> products = _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            Product product = _productService.GetById(id);
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            if (product == null) return BadRequest();

            Product returnedProduct = _productService.Create(product);
            return Ok(returnedProduct);
        }

        [HttpPut]
        public ActionResult<Product> Update(Product product)
        {
            if (product == null) return BadRequest();

            Product returnedProduct = _productService.Update(product);
            return Ok(returnedProduct);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var status = _productService.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
