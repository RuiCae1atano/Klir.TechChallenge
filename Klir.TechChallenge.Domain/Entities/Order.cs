using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public class Order : Entity
    {
        public ICollection<OrderItem> OrderItems { get; set; }

        public decimal Total { get; set; }

    }
}
