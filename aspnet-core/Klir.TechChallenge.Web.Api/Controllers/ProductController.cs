using Klir.TechChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService orderService)
        {
            _service = orderService;
        }

        [HttpGet]
        [Route("GetProduct/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("GetPromotions/{id}")]
        public async Task<IActionResult> GetPromotions(int id)
        {
            var promotions = await _service.GetProductPromotionAsync(id);
            return Ok(promotions);
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _service.GetProductsAsync();
            return Ok(products);
        }
    }
}
