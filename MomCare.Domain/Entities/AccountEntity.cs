using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MomCare.Domain.Entities.Base;
using MomCare.Domain.Enums;


namespace MomCare.Domain.Entities

{
    public class AccountEntity  : BaseEntity
    {

        //public string? UrlAvatar { get; set; }

        //public string? CreatedBy { get; set; }
        //public string? LastUpdatedBy { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[DefaultValue("GETDATE()")]
        //public DateTime? CreatedTime { get; set; } = DateTime.Now;

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime? LastUpdatedTime { get; set; }
        //public bool isDeleted { get; set; } = false;
     
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Url { get; set; }
        public Role Role { get; set; }
        public List<SubscriptionEntity>? SubscriptionEntities { get; set; }
        public List<PaymentEntity>? Payments { get; set; }
        public List<ChildrentEntity>? Childrents { get; set; }
        public List<ScheduleEntity>? Schedules { get;set; }
        public List<PostEntity>? Posts { get;set; }
        public List<Notification>? Notifications { get; set; }
        public List<CommentEntity> Comments { get; set; }
    }

}
