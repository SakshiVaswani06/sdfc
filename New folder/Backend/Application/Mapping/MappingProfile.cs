using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Assessment, AssQuesDto>().ReverseMap();
            CreateMap<Questions, AssQuesDto>().ReverseMap();
            CreateMap<Assessment, AssDto>().ReverseMap();
            CreateMap<Questions, QuesDto>().ReverseMap();


        }
    }

}
