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
    public class HealthMetricConfiguration : IEntityTypeConfiguration<HealthMetric>
    {
        public void Configure(EntityTypeBuilder<HealthMetric> builder)
        {
            builder.ToTable("HealthMetric");
            //HealthMetric-GrowthIndex relationship
            builder.HasOne(h => h.GrowthIndex)
                 .WithOne(h => h.HealthMetric)
                 .HasForeignKey<GrowthIndex>(h => h.HealthMetricId);

            builder.HasKey(h => h.Id);
            builder.Property(h => h.PregnancyWeek)
                .IsRequired();
            builder.Property(h => h.HeadCircumference)
                .IsRequired();
            builder.Property(h => h.Weight)
                .IsRequired();
            builder.Property(h => h.Lenght)
                .IsRequired();
            builder.Property(h => h.SacDiameter)
                .IsRequired();
            builder.Property(h => h.HearRate)
                .IsRequired();
        }
    }
}
