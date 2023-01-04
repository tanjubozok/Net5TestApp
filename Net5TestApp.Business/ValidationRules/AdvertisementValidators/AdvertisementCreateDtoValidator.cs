using FluentValidation;
using Net5TestApp.Dtos.Concrete.AdvertisementDtos;

namespace Net5TestApp.Business.ValidationRules.AdvertisementValidators
{
    public class AdvertisementCreateDtoValidator : AbstractValidator<AdvertisementCreateDto>
    {
        public AdvertisementCreateDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık zorunlu alandır");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama zorunlu alandır");
        }
    }
}
