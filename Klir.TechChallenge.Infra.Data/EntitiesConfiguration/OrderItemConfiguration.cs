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
            builder.HasOne(orderItem => orderItem.Product).WithMany(prd => prd.OrderItems)
            .HasForeignKey(orderItem => orderItem.ProductId);

            builder.HasData(new OrderItem(1,1,1)); //20
            builder.HasData(new OrderItem(2,2,1)); //4
        }
    }
}
