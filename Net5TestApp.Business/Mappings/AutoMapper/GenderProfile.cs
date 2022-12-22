using AutoMapper;
using Net5TestApp.Dtos.Concrete.GenderDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Mappings.AutoMapper
{
    public class GenderProfile : Profile
    {
        public GenderProfile()
        {
            CreateMap<GenderListDto, Gender>().ReverseMap();
            CreateMap<GenderCreateDto, Gender>().ReverseMap();
            CreateMap<GenderUpdateDto, Gender>().ReverseMap();
        }
    }
}
