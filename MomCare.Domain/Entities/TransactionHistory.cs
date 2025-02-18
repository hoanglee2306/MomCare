using MomCare.Domain.Entities.Base;
using MomCare.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class TransactionHistory : BaseEntity
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public Status Status { get; set; }
        public List<PaymentEntity>? Payments { get; set; }


    }
}
