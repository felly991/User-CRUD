using AutoMapper;
using HumanAPI.Dto;
using HumanAPI.Models;

namespace HumanAPI.MapperProfile
{
    public class HumanProfile : Profile
    {
        public HumanProfile()
        {
            CreateMap<HumanModel, HumanModelDto>();
            CreateMap<HumanModelDto, HumanModel>();
        }
    }
}
