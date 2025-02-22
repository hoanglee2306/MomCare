using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MomCare.Domain.Entities;

namespace MomCare.Infrastructure.Presistences.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<NotificationEntity>
    {
        public void Configure(EntityTypeBuilder<NotificationEntity> builder)
        {
            builder.Property(n => n.Message)
                .IsUnicode(true)
                .HasMaxLength(500);

            builder.Property(n => n.MarkAsRead)
                .HasDefaultValue(false);

            builder.Property(n => n.CreatedDate)
                .HasDefaultValueSql("GETDATE()");
            builder.Property(n => n.ModifiedDate)
                .ValueGeneratedOnAddOrUpdate();

            builder.HasIndex(n => n.Id);
            builder.HasIndex(n => n.AccountId);
            builder.HasIndex(n => n.CreatedDate);
            builder.HasIndex(n => n.ModifiedDate);

            builder.HasOne(n => n.Account)
                .WithMany(a => a.Notifications)
                .HasForeignKey(n => n.AccountId);
        }
    }

}
