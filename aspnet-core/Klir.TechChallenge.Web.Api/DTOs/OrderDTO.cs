using Klir.TechChallenge.Domain.Entities;
using System.Collections.Generic;

namespace Klir.TechChallenge.Web.Api.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public decimal Total { get; set; }
    }
}
