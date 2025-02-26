using Application.Response;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using MomCare.Application.Interfaces;
using MomCare.Application.Requests;
using MomCare.Application.Responses;
using MomCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Application.Services
{
    public class ChildrenService : IChildrenService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ChildrenService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddNewChildren(ChildrenRequest childrenRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var children = _mapper.Map<ChildrentEntity>(childrenRequest);
                await _unitOfWork.Chidren.AddAsync(children);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk("Children's details added successfully!");
            }
            catch(Exception e)
            {
                return apiResponse.SetBadRequest(e.Message);
            }
        }

        public async Task<ApiResponse> DeleteChildrenData(Guid Id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var children = await _unitOfWork.Chidren.GetAsync(c => c.Id == Id);
                if(children == null)
                {
                    return apiResponse.SetNotFound("Can not found the Children detail");
                }
                await _unitOfWork.Chidren.RemoveByIdAsync(Id);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk("Delele successfully!");


            }
            catch(Exception e)
            {
                return apiResponse.SetBadRequest(e.Message);
            }
        }

        public async Task<ApiResponse> GetAllChildren()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var childrens = await _unitOfWork.Chidren.GetAllAsync(null);
                var resChildrens = _mapper.Map<List<ChildrenResponse>>(childrens);
                return new ApiResponse().SetOk(resChildrens);
            }
            catch( Exception e)
            {
                return apiResponse.SetBadRequest(e.Message);
            }
        }

        public async Task<ApiResponse> UpdateChildrenData(ChildrenRequest childrenRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var children = await _unitOfWork.Chidren.GetAsync(c => c.Id == childrenRequest.Id);
                if(children == null)
                {
                    return apiResponse.SetNotFound("Can not found the Children detail");
                }
                _mapper.Map(childrenRequest, children);
                await _unitOfWork.Chidren.UpdateAsync(children);
                return apiResponse.SetOk("Children's details updated successfully");
                
            }
            catch(Exception e)
            {
                return apiResponse.SetBadRequest(e.Message);
            }
        }
    }
}
