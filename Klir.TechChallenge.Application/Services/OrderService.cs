using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infra.IoC;
using Klir.TechChallenge.Application.DTOs;
using Klir.TechChallenge.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Klir.TechChallenge.Application.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _repository = orderRepository;
            _mapper = mapper;
        }
        public async Task<OrderDTO> CreateOrderAsync(OrderDTO orderDTO)
        {
            var orderEntiy = _mapper.Map<Order>(orderDTO);
            await _repository.CreateOrderAsync(orderEntiy);
            return orderDTO;
        }

        public async Task<OrderDTO> GetByIdAsync(int id)
        {
            var order = await _repository.GetByIdAsync(id);
            var orderDTO = order.ToDto<Order, OrderDTO>();


            var result = new List<OrderItemDTO>();

            foreach (var collection in order.OrderItems)
            {
                var d = new OrderItemDTO(collection.Quantity, collection.Product.Name, collection.Product.Price, collection.Product.Promotion.Name);                
                result.Add(d);
            }
            orderDTO.OrderItems = result;

            return orderDTO;
        }
    }
}
