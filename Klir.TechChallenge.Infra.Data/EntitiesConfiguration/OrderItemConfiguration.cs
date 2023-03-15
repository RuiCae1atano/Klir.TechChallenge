using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Klir.TechChallenge.Infra.Data.EntitiesConfiguration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasOne(oi => oi.Order).WithMany(o => o.OrderItems).
                    HasForeignKey(oi => oi.OrderId);
            builder.HasOne(oi => oi.Product).WithMany(o => o.OrderItems).
                    HasForeignKey(oi => oi.OrderId);
            builder.Property(x => x.Price);
            builder.Property(x => x.Quantity);
        }
    }
}
