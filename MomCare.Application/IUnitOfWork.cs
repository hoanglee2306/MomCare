using MomCare.Application.Interfaces;
using MomCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Application
{
    public interface IUnitOfWork
    {
       public IChidrenRepository Chidren { get; }
       public Task SaveChangeAsync();
       //Task<T> ExecuteScalarAsync<T>(string sql);
       //Task ExecuteRawSqlAsync(string sql);

    }
}
