using AutoMapper;
using Net5TestApp.Dtos.Concrete.AdvertisementDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Mappings.AutoMapper
{
    public class AdvertisementProfile : Profile
    {
        public AdvertisementProfile()
        {
            CreateMap<AdvertisementListDto, Advertisement>().ReverseMap();
            CreateMap<AdvertisementCreateDto, Advertisement>().ReverseMap();
            CreateMap<AdvertisementUpdateDto, Advertisement>().ReverseMap();
        }
    }
}
