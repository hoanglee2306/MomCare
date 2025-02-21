using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MomCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Infrastructure.Presistences.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(o => o.Id);
            //Order-Payment relationship
            builder.HasMany(p => p.Payments)
                 .WithOne(p => p.Order)
                 .HasForeignKey(p => p.OrderId);
        
        }
    }
}
