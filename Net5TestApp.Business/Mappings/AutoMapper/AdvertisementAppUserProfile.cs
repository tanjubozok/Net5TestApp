using AutoMapper;
using Net5TestApp.Dtos.Concrete.AdvertisementAppUserDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Mappings.AutoMapper
{
    public class AdvertisementAppUserProfile : Profile
    {
        public AdvertisementAppUserProfile()
        {
            this.CreateMap<AdvertisementAppUser, AdvertisementAppUserCreateDto>().ReverseMap();
        }
    }
}
