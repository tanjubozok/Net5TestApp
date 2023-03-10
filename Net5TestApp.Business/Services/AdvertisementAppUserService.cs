using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Net5TestApp.Business.Abstract;
using Net5TestApp.Business.Extensions;
using Net5TestApp.Common.Enums;
using Net5TestApp.Common.Objects;
using Net5TestApp.DataAccess.Concrete.UnitOfWork;
using Net5TestApp.Dtos.Concrete.AdvertisementAppUserDtos;
using Net5TestApp.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Services
{
    public class AdvertisementAppUserService : IAdvertisementAppUserService
    {
        private readonly IUow _uow;
        private readonly IValidator<AdvertisementAppUserCreateDto> _craeteDtoValidator;
        private readonly IMapper _mapper;

        public AdvertisementAppUserService(IUow uow, IValidator<AdvertisementAppUserCreateDto> craeteDtoValidator, IMapper mapper)
        {
            _uow = uow;
            _craeteDtoValidator = craeteDtoValidator;
            _mapper = mapper;
        }

        public async Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto)
        {
            var result = _craeteDtoValidator.Validate(dto);
            if (result.IsValid)
            {
                var control = await _uow.GetRepository<AdvertisementAppUser>()
                    .GetByFilterAsync(x => x.AppUserId == dto.AppUserId && x.AdvertisementId == dto.AdvertisementId);
                if (control == null)
                {
                    await _uow.GetRepository<AdvertisementAppUser>().AddAsync(_mapper.Map<AdvertisementAppUser>(dto));
                    await _uow.SaveChangesAsync();
                    return new Response<AdvertisementAppUserCreateDto>(ResponseType.Success, dto);
                }
                List<CustomValidationError> errors = new()
                {
                    new()
                    {
                        PropertyName="",
                        ErrorMessage="İlana daha önce başvurdunuz"
                    }
                };
                return new Response<AdvertisementAppUserCreateDto>(dto, errors);
            }
            return new Response<AdvertisementAppUserCreateDto>(dto, result.CustomValidationErrors());
        }

        public async Task<List<AdvertisementAppUserListDto>> GetListAsync(AdvertisementAppUserStatusTypes type)
        {
            var query = _uow.GetRepository<AdvertisementAppUser>().GetQueryable();
            var list = await query
                .Include(x => x.Advertisement)
                .Include(x => x.AdvertisementAppUserStatus)
                .Include(x => x.MilitaryStatus)
                .Include(x => x.AppUser).ThenInclude(x => x.Gender)
                .Where(x => x.AdvertisementAppUserStatusId == (int)type)
                .ToListAsync();

            return _mapper.Map<List<AdvertisementAppUserListDto>>(list);
        }

        public async Task SetStatusAsync(int advertisementAppUserId, AdvertisementAppUserStatusTypes type)
        {
            var query = _uow.GetRepository<AdvertisementAppUser>().GetQueryable();
            var entity = await query.SingleOrDefaultAsync(x => x.Id == advertisementAppUserId);
            entity.AdvertisementAppUserStatusId = (int)type;
            await _uow.SaveChangesAsync();
        }
    }
}
