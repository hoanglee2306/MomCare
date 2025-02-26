using AutoMapper;
using MomCare.Application.Requests;
using MomCare.Application.Responses;
using MomCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Application.MyMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ChildrenRequest, ChildrentEntity>();
            CreateMap<ChildrentEntity, ChildrenResponse>();
        }

    }
}
