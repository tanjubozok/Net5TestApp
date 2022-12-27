using Net5TestApp.Dtos.Concrete.ProvidedServiceDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Abstract
{
    public interface IProvidedServiceService : IService<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>
    {
    }
}
