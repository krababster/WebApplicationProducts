using Microsoft.AspNetCore.Mvc;
using WebApplicationProducts.Model;

namespace WebApplicationProducts.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SortedProductsController : ControllerBase
    {
        private static List<Product> products;
        public SortedProductsController()
        {
            products = new List<Product>();
            products.Add(new Product() { name = "Apple", price = 12, manufacturer = "Ukraine" });
            products.Add(new Product() { name = "Potato", price = 26, manufacturer = "Ukraine" });
            products.Add(new Product() { name = "Milk", price = 10, manufacturer = "Ukraine" });
            products.Add(new Product() { name = "Water", price = 54, manufacturer = "Ukraine" });
            products.Add(new Product() { name = "Cherry", price = 21, manufacturer = "Ukraine" });
        }

        [HttpGet(Name = "GetSortedProduct")]
        public IEnumerable<Product> Get()
        {
            return products.OrderBy(e=>e.price).ToArray();
        }
    }
}
