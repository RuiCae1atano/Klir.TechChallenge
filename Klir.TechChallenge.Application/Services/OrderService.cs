using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infra.IoC;
using Klir.TechChallenge.Application.DTOs;
using Klir.TechChallenge.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Application.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _repository;

        public OrderService(IOrderRepository orderRepository)
        {
            _repository = orderRepository;
        }
        public async Task<OrderDTO> CreateOrderAsync(OrderDTO orderDTO)
        {
            var orderItemList;
            //dto to entity
            foreach (var item in collection)
            {

            }

            var order = new Order(orderDTO.Total,);



            await _repository.CreateOrderAsync(order);
            return order.ToDto<Order, OrderDTO>();
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
