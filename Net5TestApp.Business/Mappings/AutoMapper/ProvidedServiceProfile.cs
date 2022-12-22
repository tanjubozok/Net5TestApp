using AutoMapper;
using Net5TestApp.Dtos.Concrete.ProvidedServiceDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Mappings.AutoMapper
{
    public class ProvidedServiceProfile : Profile
    {
        public ProvidedServiceProfile()
        {
            CreateMap<ProvidedServiceListDto, ProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceCreateDto, ProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceUpdateDto, ProvidedService>().ReverseMap();
        }
    }
}
