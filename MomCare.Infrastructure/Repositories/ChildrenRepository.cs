using MomCare.Application.Repositories;
using MomCare.Domain.Entities;
using MomCare.Infrastructure.Presistences;
using MomCare.Infrastructure.Repositories.BaseRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Infrastructure.Repositories
{
    public class ChildrenRepository : GenericRepository<ChildrentEntity>, IChidrenRepository
    {
        public ChildrenRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
