using AutoMapper;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Mappings.AutoMapper
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUserListDto, AppUser>().ReverseMap();
            CreateMap<AppUserCreateDto, AppUser>().ReverseMap();
            CreateMap<AppUserUpdateDto, AppUser>().ReverseMap();
        }
    }
}
