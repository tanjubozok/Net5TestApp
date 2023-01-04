using Net5TestApp.Common.Objects;
using Net5TestApp.Dtos.Concrete.AdvertisementAppUserDtos;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Abstract
{
    public interface IAdvertisementAppUserService
    {
        Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto);
    }
}
