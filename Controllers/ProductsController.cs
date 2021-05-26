using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Services;
using bright_web_api.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bright_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsService _productsService;

        public ProductsController(ProductsService productService)
        {
            _productsService = productService;
        }

        [HttpGet("get-all-products")]
        public IActionResult GetAllProducts()
        {
            var allProducts = _productsService.GetAllProducts();
            return Ok(allProducts);
        }

        [HttpPost("add-product")]
        public IActionResult AddProduct([FromBody] ProductVM product)
        {
            _productsService.AddProduct(product);
            return Ok();
        }
    }
}
