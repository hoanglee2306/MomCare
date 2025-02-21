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
    public class GrowthIndexConfiguration : IEntityTypeConfiguration<GrowthIndex>
    {
        public void Configure(EntityTypeBuilder<GrowthIndex> builder)
        {
            builder.ToTable("GrowthIndex");
            builder.HasKey(g => g.Id);
        }
    }
}
