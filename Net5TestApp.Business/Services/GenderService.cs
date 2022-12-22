using AutoMapper;
using FluentValidation;
using Net5TestApp.Business.Interfaces;
using Net5TestApp.DataAccess.Concrete.UnitOfWork;
using Net5TestApp.Dtos.Concrete.GenderDtos;
using Net5TestApp.Entities.Concrete;

namespace Net5TestApp.Business.Services
{
    public class GenderService : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>, IGenderService
    {
        public GenderService(IMapper mapper, IValidator<GenderCreateDto> createValidator, IValidator<GenderUpdateDto> updateValidator, IUow uow) : base(mapper, createValidator, updateValidator, uow)
        {
        }
    }
}
