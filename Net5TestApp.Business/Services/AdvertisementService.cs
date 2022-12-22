using AutoMapper;
using FluentValidation;
using Net5TestApp.Business.Interfaces;
using Net5TestApp.Common.Objects;
using Net5TestApp.DataAccess.Concrete.UnitOfWork;
using Net5TestApp.Dtos.Concrete.AdvertisementDtos;
using Net5TestApp.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Services
{
    public class AdvertisementService : Service<AdvertisementCreateDto, AdvertisementUpdateDto, AdvertisementListDto, Advertisement>, IAdvertisementService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public AdvertisementService(IMapper mapper, IValidator<AdvertisementCreateDto> createValidator, IValidator<AdvertisementUpdateDto> updateValidator, IUow uow) : base(mapper, createValidator, updateValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync()
        {
            var data = await _uow.GetRepository<Advertisement>().GetAllAsync(x => x.Status, x => x.CreatedDate, Common.Enums.OrderByType.DESC);
            var dto = _mapper.Map<List<AdvertisementListDto>>(data);
            return new Response<List<AdvertisementListDto>>(ResponseType.Success, dto);
        }
    }
}
