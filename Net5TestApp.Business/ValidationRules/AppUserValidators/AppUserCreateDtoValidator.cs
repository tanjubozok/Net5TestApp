using FluentValidation;
using Net5TestApp.Dtos.Concrete.AppUserDtos;

namespace Net5TestApp.Business.ValidationRules.AppUserValidators
{
    public class AppUserCreateDtoValidator : AbstractValidator<AppUserCreateDto>
    {
        public AppUserCreateDtoValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            RuleFor(x => x.Phone).NotEmpty();
        }
    }
}
