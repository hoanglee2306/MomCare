using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid PlanId { get; set; }
        public decimal TotalPrice { get; set; }
        public string Note { get; set; }
        public bool IsDelete { get; set; }
        public AccountEntity? Account { get; set; }
        public SubscriptionPlanEntity? SubscriptionPlan { get; set; }
        public List<PaymentEntity>? Payments { get; set; }
    }
}
