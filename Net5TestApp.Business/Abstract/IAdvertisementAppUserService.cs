using Net5TestApp.Common.Enums;
using Net5TestApp.Common.Objects;
using Net5TestApp.Dtos.Concrete.AdvertisementAppUserDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Abstract
{
    public interface IAdvertisementAppUserService
    {
        Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto);
        Task<List<AdvertisementAppUserListDto>> GetListAsync(AdvertisementAppUserStatusTypes type);
        Task SetStatusAsync(int advertisementAppUserId, AdvertisementAppUserStatusTypes type);
    }
}
