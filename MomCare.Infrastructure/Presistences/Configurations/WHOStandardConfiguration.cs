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
    public class WHOStandardConfiguration : IEntityTypeConfiguration<WHOStandard>
    {
        public void Configure(EntityTypeBuilder<WHOStandard> builder)
        {
            builder.HasKey(w => w.Id);
        }
    }
}
