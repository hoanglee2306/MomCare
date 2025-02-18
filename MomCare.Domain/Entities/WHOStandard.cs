using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class WHOStandard
    {
        public Guid Id { get; set; }
        public DateTime PregnancyWeek { get; set; }
        public double HeadCircumference { get; set; }
        public double Weight { get; set; }
        public double Lenght { get; set; }
        public double SacDiameter { get; set; }
        public double HearRate { get; set; }
        public string Status { get; set; }
    }
}
