using System.Collections.Generic;
using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Enum;
using ASPLesson.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPLesson.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _productService.GetAllProducts();
            if (response.StatusCode == ErrorCode.OK)
            {
                var products = response.Data as List<Product>;
                return View(products);
            }
            return BadRequest(response.Message);
        }

        [HttpGet]
        public IActionResult CreateProduct() => View();

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductViewModel productModel)
        {
            var response = await _productService.CreateProduct(productModel);
            if (response.StatusCode == ErrorCode.OK)
            {
                return Ok("Продукт создан");
            }
            return BadRequest(response.Message);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateProduct1(string car)
        {
            return Ok();
        }
    }
}