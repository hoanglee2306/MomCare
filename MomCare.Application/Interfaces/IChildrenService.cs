using Application.Response;
using MomCare.Application.Requests;
using MomCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Application.Interfaces
{
    public interface IChildrenService
    {
        Task<ApiResponse> AddNewChildren(ChildrenRequest childrentRequest);
        Task<ApiResponse> GetAllChildren();
        Task<ApiResponse> DeleteChildrenData( Guid Id);
        Task<ApiResponse> UpdateChildrenData(ChildrenRequest childrenRequest);

    }
}
