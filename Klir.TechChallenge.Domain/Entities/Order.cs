using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public class Order : Entity
    {
        public ICollection<OrderItem> OrderItems { get; set; }

        public decimal Total { get; set; }

        public Order(int id, decimal total, ICollection<OrderItem> orderItems)
        {
            Id = id;
            Total = total;
            OrderItems = orderItems;
        }

    }
}
