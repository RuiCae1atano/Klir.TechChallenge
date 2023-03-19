using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Web.Api.DTOs;
using Klir.TechChallenge.Web.Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService orderService)
        {
            _service = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var orders = await _service.GetByIdAsync(id);
            return Ok(orders);
        }

        [HttpPost] 
        public async Task<IActionResult> CreateOrderAsync(OrderDTO order) 
        {
            var orders = await _service.CreateOrderAsync(order);
            return Ok(orders);
        }
    }
}
