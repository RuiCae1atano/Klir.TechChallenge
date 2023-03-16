using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public class Order : Entity
    {
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public decimal Total { get; set; }

        public Order(int id, decimal total)
        {
            Id = id;
            Total = total;
        }

        public Order(decimal total, ICollection<OrderItem> orderItems)
        {
            Total = total;
            OrderItems = orderItems;
        }

    }
}
