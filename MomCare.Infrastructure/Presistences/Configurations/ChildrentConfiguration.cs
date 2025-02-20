using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MomCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Infrastructure.Presistences.Configurations
{
    public class ChildrentConfiguration : IEntityTypeConfiguration<ChildrentEntity>
    {
        public void Configure(EntityTypeBuilder<ChildrentEntity> builder)
        {
            //Childrent-HealthMetric relationship
            builder.HasMany(h => h.HealthMetrics)
                 .WithOne(h => h.Childrent)
                 .HasForeignKey(h => h.ChildrentId);

        }
    }
}
