using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Domain.Entities.Base
{
    public abstract class BaseEntity
    {

        public DateTime Date { get; set; }
        public bool IsDelete { get; set; }

    }
}
