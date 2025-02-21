using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MomCare.Domain.Entities;

namespace MomCare.Infrastructure.Presistences.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<AccountEntity>
    {
        public void Configure(EntityTypeBuilder<AccountEntity> builder)
        {
            builder.ToTable("Account");
            //account-subscription relationship
            builder.HasMany(s => s.SubscriptionEntities)
                 .WithOne(s => s.Account)
                 .HasForeignKey(s => s.AccountId);

            //account-payment relationship
            builder.HasMany(p => p.Payments)
                .WithOne(p=> p.Account)
                .HasForeignKey(p => p.AccountId);

            //account-childrent relationship
            builder.HasMany(c => c.Childrents)
                .WithOne(c => c.Account)
                .HasForeignKey(c => c.AccountId);

            //account-schedule relationship
            builder.HasMany(sc => sc.Schedules)
                .WithOne(sc => sc.Account)
                .HasForeignKey(sc => sc.AccountId);

            //account-post relationship
            builder.HasMany(ps => ps.Posts)
                .WithOne(ps => ps.Account)
                .HasForeignKey(ps => ps.AccountId);

            //account-notification relationship
            builder.HasMany(n => n.Notifications)
                 .WithOne(n => n.Account)
                 .HasForeignKey(n => n.AccountId);

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .IsRequired();
            builder.Property(a => a.Email)
                .IsRequired();
            builder.Property(a => a.Password)
                .IsRequired();
            builder.Property(a => a.Phone)
                .HasMaxLength(11);
        }
    }

}