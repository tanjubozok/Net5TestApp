using AutoMapper;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.WebUI.Models;

namespace Net5TestApp.WebUI.Mappings
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>();
        }
    }
}
