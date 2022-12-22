using Net5TestApp.Business.Abstract;
using Net5TestApp.Dtos.Concrete.GenderDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Interfaces
{
    public interface IGenderService : IService<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>
    {
    }
}
