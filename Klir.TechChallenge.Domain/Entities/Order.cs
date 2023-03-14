using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.Entities
{
    public class Order : Entity
    {
        public IEnumerable<OrderItem> OrderItens { get; set; }

        public decimal Total { get; set; }

    }
}
