using Net5TestApp.Business.Abstract;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>
    {
    }
}
