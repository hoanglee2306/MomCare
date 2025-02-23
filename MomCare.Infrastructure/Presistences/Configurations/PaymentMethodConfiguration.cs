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
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethod");
            builder.HasKey(m => m.Id);
            //PaymentMethod-Payment relationship
            builder.HasMany(p => p.Payments)
                 .WithOne(p => p.PaymentMethod)
                 .HasForeignKey(p => p.MethodId)
                 .OnDelete(DeleteBehavior.Restrict); 

        }
    }
}
