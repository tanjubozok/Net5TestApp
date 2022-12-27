using Net5TestApp.Business.Abstract;
using Net5TestApp.Common.Objects;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.Entities.Concrete;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>
    {
        Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
    }
}
