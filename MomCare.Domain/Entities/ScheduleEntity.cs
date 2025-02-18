using MomCare.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class ScheduleEntity : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public bool IsNoti { get; set; }
        public string Content { get; set; }
        public AccountEntity? Account { get;set; }

    }
}
