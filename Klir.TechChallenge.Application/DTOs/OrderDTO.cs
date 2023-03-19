using Klir.TechChallenge.Domain.Entities;
using System.Collections.Generic;

namespace Klir.TechChallenge.Application.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }

        public decimal Total { get; set; }
    }
}
