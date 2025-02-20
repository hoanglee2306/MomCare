using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MomCare.Domain.Entities;

namespace MomCare.Infrastructure.Presistences
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }
        #region DbSet
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<ChildrentEntity> Childrents { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<GrowthIndex> GrowthIndices { get; set; }
        public DbSet<HealthMetric> HealthMetrics { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<PaymentMethod> Methods { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<ScheduleEntity> Schedules { get; set; }
        public DbSet<SubscriptionEntity> Subscriptions { get; set; }
        public DbSet<SubscriptionPlanEntity> Plans { get; set; }
        public DbSet<TransactionHistory> Transactions { get; set; }
        public DbSet<WHOStandard> Standards { get; set; }
        #endregion
    }
}