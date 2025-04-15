using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Chicken Noodle Soup", Category = "Food", Price = 10 },
            new Product { Id = 2, Name = "Woody", Category = "Figure", Price = 375M },
            new Product { Id = 3, Name = "Wrench", Category = "Tool", Price = 16 }
        };
        public ProductsController() { }
        public ProductsController(Product[] products)
        {
            this.products = products;
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
    
}