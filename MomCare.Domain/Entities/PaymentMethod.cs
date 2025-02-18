using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class PaymentMethod
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PaymentEntity>? Payments { get; set; }
    }
}
