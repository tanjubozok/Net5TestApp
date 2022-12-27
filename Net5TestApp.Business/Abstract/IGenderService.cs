using Net5TestApp.Dtos.Concrete.GenderDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Abstract
{
    public interface IGenderService : IService<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>
    {
    }
}
