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
    public class TransactionHistoryConfiguration : IEntityTypeConfiguration<TransactionHistory>
    {
        public void Configure(EntityTypeBuilder<TransactionHistory> builder)
        {
            builder.ToTable("TransactionHistory");
            builder.HasKey(t => t.Id);
            //Transaction-Payment relationship
            builder.HasMany(p => p.Payments)
                 .WithOne(p => p.TransactionHistory)
                 .HasForeignKey(p => p.TransactionId)
                 .OnDelete(DeleteBehavior.Restrict); 

        }
    }
}
