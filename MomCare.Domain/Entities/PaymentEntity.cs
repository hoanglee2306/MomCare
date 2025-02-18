using MomCare.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class PaymentEntity : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid AccountId{ get; set; }
        public Guid OrderId { get; set; }
        public Guid MethodId { get; set; }
        public Guid TransactionId { get; set; }
        public string Note { get; set; }
        public OrderEntity? Order { get; set; }
        public AccountEntity? Account { get; set; }
        public PaymentMethod? paymentMethod { get; set; }
        public TransactionHistory? TransactionHistory { get; set; }

    }
}
