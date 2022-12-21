using Net5TestApp.Business.Abstract;
using Net5TestApp.Dtos.Concrete.ProvidedServiceDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Interfaces
{
    public interface IProvidedServiceService : IService<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>
    {
    }
}
