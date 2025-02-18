using MomCare.Domain.Entities.Base;
using MomCare.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
     public class SubscriptionPlanEntity : BaseEntity
    {
        public Guid Id { get; set; }
        public SubscriptionPlanName Name { get; set; }

        public double Price { get; set; }
        public DateTime DurationMonth { get; set; }
        public string Description  { get; set; }
        public List<SubscriptionEntity>? SubscriptionEntities { get; set; }
        public List<OrderEntity>? Orders { get; set; }

    }
}
