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
            //HealthMetric-GrowthIndex relationship
            builder.HasOne(h => h.GrowthIndex)
                 .WithOne(h => h.HealthMetric)
                 .HasForeignKey<GrowthIndex>(h => h.HealthMetricId);

        }
    }
}
