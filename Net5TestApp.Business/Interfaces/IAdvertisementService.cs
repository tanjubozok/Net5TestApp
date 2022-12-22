using Net5TestApp.Business.Abstract;
using Net5TestApp.Common.Objects;
using Net5TestApp.Dtos.Concrete.AdvertisementDtos;
using Net5TestApp.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Interfaces
{
    public interface IAdvertisementService : IService<AdvertisementCreateDto, AdvertisementUpdateDto, AdvertisementListDto, Advertisement>
    {
        Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync();
    }
}
