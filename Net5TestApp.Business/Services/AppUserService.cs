using AutoMapper;
using FluentValidation;
using Net5TestApp.Business.Extensions;
using Net5TestApp.Business.Interfaces;
using Net5TestApp.Common.Enums;
using Net5TestApp.Common.Objects;
using Net5TestApp.DataAccess.Concrete.UnitOfWork;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.Entities.Concrete;
using System.Threading.Tasks;

namespace Net5TestApp.Business.Services
{
    public class AppUserService : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>, IAppUserService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IValidator<AppUserCreateDto> _createDtoValidator;

        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> createValidator, IValidator<AppUserUpdateDto> updateValidator, IUow uow) : base(mapper, createValidator, updateValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
            _createDtoValidator = createValidator;
        }

        public async Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId)
        {
            var validationResult = _createDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var user = _mapper.Map<AppUser>(dto);
                await _uow.GetRepository<AppUserRoles>().AddAsync(new AppUserRoles()
                {
                    AppUser = user,
                    AppRoleId = roleId
                });
                await _uow.SaveChangesAsync();
                return new Response<AppUserCreateDto>(ResponseType.Success, dto);
            }
            return new Response<AppUserCreateDto>(dto, validationResult.CustomValidationErrors());
        }

    }
}
