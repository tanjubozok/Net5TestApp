using AutoMapper;
using FluentValidation;
using Net5TestApp.Business.Interfaces;
using Net5TestApp.DataAccess.Concrete.UnitOfWork;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Services
{
    public class AppUserService : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>, IAppUserService
    {
        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> createValidator, IValidator<AppUserUpdateDto> updateValidator, IUow uow) : base(mapper, createValidator, updateValidator, uow)
        {
        }
    }
}
