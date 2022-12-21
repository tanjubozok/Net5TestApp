using Net5TestApp.Common.Objects;
using Net5TestApp.Dtos.Abstract;
using Net5TestApp.Dtos.Interfaces;
using Net5TestApp.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Abstract
{
    public interface IService<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        Task<IResponse<List<ListDto>>> GetAllAsync();
        Task<IResponse<IDto>> GetByIdAsync(int id);

        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);
        Task<IResponse> RemoveAsync(int id);
    }
}
