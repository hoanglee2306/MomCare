﻿using MomCare.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class HealthMetric : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid ChildrentId { get; set; }
        public DateTime PregnancyWeek { get; set; }
        public double HeadCircumference { get; set; }
        public double Weight { get; set; }
        public double Lenght { get; set; }
        public double SacDiameter { get; set; }
        public double HearRate { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public bool IsAlert { get; set; }
        public ChildrentEntity? Childrent { get; set; }
        public GrowthIndex? GrowthIndex { get; set; }
    }
}
