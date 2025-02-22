﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class SubscriptionEntity
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public AccountEntity? Account { get; set; }
        public SubscriptionPlanEntity? SubscriptionPlanEntity { get; set; }
    }
}
