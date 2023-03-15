using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Infra.Data.EntitiesConfiguration
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);

            builder.HasData(
                new Promotion(1, "Buy 1 Get 1 Free"),
                new Promotion(2, "3 for 10 Euro")
                );
        }
    }
}
