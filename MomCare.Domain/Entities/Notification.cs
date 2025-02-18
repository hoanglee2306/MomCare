using MomCare.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class Notification
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string Content { get; set; }
        public NotiType Type { get; set; }
        public bool IsRead { get; set; }
        public DateTime Date { get; set; }
        public AccountEntity Account { get; set; }
    }
}
