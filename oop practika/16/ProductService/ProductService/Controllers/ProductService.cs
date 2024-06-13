using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            // Здесь можно получить данные из базы данных или другого источника
            // В данном примере мы вернем жестко закодированный список продуктов

            return new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description 1" },
                new Product { Id = 2, Name = "Product 2", Description = "Description 2" },
                new Product { Id = 3, Name = "Product 3", Description = "Description 3" }
            };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}