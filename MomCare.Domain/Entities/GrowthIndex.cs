using MomCare.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class GrowthIndex : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid HealthMetricId { get; set; }
        public double DevelopmentScore { get; set; }
        public double GrowthRate { get; set; }
        public HealthMetric? HealthMetric { get; set; } 
    }
}
