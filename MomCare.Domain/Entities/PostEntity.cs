using MomCare.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities
{
    public class PostEntity : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsEdited { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public AccountEntity? Account { get; set; }
        public List<CommentEntity>? Comments { get; set; }

    }
}
