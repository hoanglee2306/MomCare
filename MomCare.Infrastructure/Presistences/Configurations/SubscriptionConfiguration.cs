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
    public class SubscriptionConfiguration : IEntityTypeConfiguration<SubscriptionEntity>
    {
        public void Configure(EntityTypeBuilder<SubscriptionEntity> builder)
        {
            builder.ToTable("Subscription");
            builder.HasKey(s => s.Id);
        }
    }
}
