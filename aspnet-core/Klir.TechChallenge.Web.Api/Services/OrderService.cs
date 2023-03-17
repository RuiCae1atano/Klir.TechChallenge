using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infra.IoC;
using Klir.TechChallenge.Web.Api.DTOs;
using Klir.TechChallenge.Web.Api.Interfaces;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _repository;

        public OrderService(IOrderRepository orderRepository)
        {
            _repository = orderRepository;
        }
        public async Task<OrderDTO> CreateOrderAsync(Order order)
        {
            await _repository.CreateOrderAsync(order);
            return order.ToDto<Order, OrderDTO>();
        }

        public async Task<OrderDTO> GetByIdAsync(int id)
        {
            var order = await _repository.GetByIdAsync(id);
            OrderDTO orderDTO = order.ToDto<Order, OrderDTO>();
            return orderDTO;
        }
    }
}
