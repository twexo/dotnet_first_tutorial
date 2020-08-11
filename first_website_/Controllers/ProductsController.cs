using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using first_website_.Models;
using first_website_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace first_website_.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
            
        }

        public JsonFileProductService ProductService { get; }

        [Route("/Products")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            Console.WriteLine("Getting those shits  ");
            return ProductService.GetProducts();
        }


        [Route("/Rate")]
        [HttpGet]
        public ActionResult Gett( [FromQuery] string ProductId, [FromQuery] int Rating)
        {
            Console.WriteLine(ProductId + " and " + Rating);
            ProductService.AddRating(ProductId, Rating);
            return Ok();
            
        }
    }


}
