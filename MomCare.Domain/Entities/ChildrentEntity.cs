using MomCare.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
  public class ChildrentEntity
    { 
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birth { get; set; }
        public AccountEntity Account { get; set; }
        public List<HealthMetric> HealthMetrics { get; set; }

    } 
}
