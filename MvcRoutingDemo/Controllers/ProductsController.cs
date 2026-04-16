using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingDemo.Controllers
{
    [Route("products")]   // ⭐ REQUIRED ROUTE PREFIX
    public class ProductsController : Controller
    {
        // Matches: /products
        [HttpGet("")]
        public IActionResult List()
        {
            return Content("All Products (Attribute Routing)");
        }

        // Matches: /products/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Content($"Product with ID = {id}");
        }

        // Matches: /products/category/electronics
        [HttpGet("category/{name}")]
        public IActionResult ByCategory(string name)
        {
            return Content($"Products in category: {name}");
        }
    }
}