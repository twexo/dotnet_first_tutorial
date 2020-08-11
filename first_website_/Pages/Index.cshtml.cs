using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using first_website_.Models;
using first_website_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace first_website_.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }
        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productService
            )
        {
            ProductService = productService;
            _logger = logger;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
