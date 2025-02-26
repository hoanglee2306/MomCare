using Microsoft.EntityFrameworkCore;
using MomCare.Application;
using MomCare.Application.Repositories;
using MomCare.Infrastructure.Presistences;
using MomCare.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _applicationDbContext;
        public IChidrenRepository Chidren { get; }
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            Chidren = new ChildrenRepository(applicationDbContext);
        }

        //public Task ExecuteRawSqlAsync(string sql)
        //{
            
        //}

        //public Task<T> ExecuteScalarAsync<T>(string sql)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task SaveChangeAsync()
        {
            try
            {
                await _applicationDbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
