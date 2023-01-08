using Microsoft.AspNetCore.Mvc;
using RetailHaven.API.Data;

namespace RetailHaven.API.Controllers
{
    public class ProductsController : Controller
    {
        private readonly StoreContext storeContext;

        public ProductsController(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        [HttpGet("api/products")]
        public IActionResult GetProducts()
        {
            var products = storeContext.Products;
            return Ok(products);
        }

        [HttpGet("api/products/{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = storeContext.Products.Find(id);
            return Ok(product);
        }

        [HttpPost("api/products")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            storeContext.Products.Add(product);
            storeContext.SaveChanges();
            return Ok(product);
        }

        [HttpPut("api/products/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            var productToUpdate = storeContext.Products.Find(id);
            if (productToUpdate == null)
            {
                return NotFound($"Product with Id = {id} not found");
            }

            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.Price = product.Price;
            productToUpdate.ImageUrl = product.ImageUrl;
            productToUpdate.ProductType = product.ProductType;
            productToUpdate.ProductBrand = product.ProductBrand;
            productToUpdate.QuantityInStock = product.QuantityInStock;
            productToUpdate.DateModified = product.DateModified;
            productToUpdate.DateDeleted = product.DateDeleted;
            productToUpdate.IsDeleted = product.IsDeleted;

            storeContext.SaveChanges();
            return Ok(productToUpdate);
        }

        [HttpDelete("api/products/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var productToDelete = storeContext.Products.Find(id);
            if (productToDelete == null)
            {
                return NotFound($"Product with Id = {id} not found");
            }

            storeContext.Products.Remove(productToDelete);
            storeContext.SaveChanges();
            return Ok();
        }

    
        [HttpGet("api/products/types")]
        public IActionResult GetProductTypes()
        {
            var productTypes = storeContext.Products;
            return Ok(productTypes);
        }
        
       
    public IActionResult Index()
        {
            return View();
        }
    }
}
