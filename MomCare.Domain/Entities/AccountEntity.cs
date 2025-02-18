using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;


namespace MomCare.Domain.Entities

{
    [Table("Account")]
    public class AccountEntity : IdentityUser
    {
        public string? UrlAvatar { get; set; }

        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DefaultValue("GETDATE()")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? LastUpdatedTime { get; set; }
        public bool isDeleted { get; set; } = false;


    }

}
