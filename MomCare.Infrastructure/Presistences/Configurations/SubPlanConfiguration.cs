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
    public class SubPlanConfiguration : IEntityTypeConfiguration<SubscriptionPlanEntity>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPlanEntity> builder)
        {
            builder.ToTable("SubscriptionPlan");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Price)
                .HasColumnType("decimal(18,2)");

            //SubPlan-Sub relationship
            builder.HasMany(s => s.SubscriptionEntities)
                 .WithOne(s => s.SubscriptionPlanEntity)
                 .HasForeignKey(s => s.PlanId);

            //SubPlan-Order relationship
            builder.HasMany(o => o.Orders)
                .WithOne(o => o.SubscriptionPlan)
                .HasForeignKey(o => o.PlanId);
        }
    }
}
