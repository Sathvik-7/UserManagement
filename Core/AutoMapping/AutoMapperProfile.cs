using AutoMapper;
using UserManagement.BackEnd.Core.DTO.Log;
using UserManagement.BackEnd.Core.Entities;

namespace UserManagement.BackEnd.Core.AutoMapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<GetLogDTO,Log>()
                .ForMember(dest => dest.UserName , o => o.MapFrom(s => s.UserName))
                .ForMember(dest => dest.Description , o => o.MapFrom(s => s.Description))
                .ForMember(dest => dest.CreatedAt, o => o.MapFrom(s => s.CreatedAt))
                .ReverseMap();
        }
    }
}
