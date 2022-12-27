using FluentValidation;
using Net5TestApp.Dtos.Concrete.AppUserDtos;

namespace Net5TestApp.Business.ValidationRules.AppUserValidators
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş olamaz.");
        }
    }
}
