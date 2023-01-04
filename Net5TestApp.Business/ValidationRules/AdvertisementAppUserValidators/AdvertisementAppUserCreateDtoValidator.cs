using FluentValidation;
using Net5TestApp.Common.Enums;
using Net5TestApp.Dtos.Concrete.AdvertisementAppUserDtos;

namespace Net5TestApp.Business.ValidationRules.AdvertisementAppUserValidators
{
    public class AdvertisementAppUserCreateDtoValidator : AbstractValidator<AdvertisementAppUserCreateDto>
    {
        public AdvertisementAppUserCreateDtoValidator()
        {
            RuleFor(x => x.AdvertisementAppUserStatusId)
                .NotEmpty();

            RuleFor(x => x.AdvertisementId)
                .NotEmpty();

            RuleFor(x => x.AppUserId)
                .NotEmpty();

            RuleFor(x => x.CvFile)
                .NotEmpty().WithMessage("Cv dosyası eksik");

            RuleFor(x => x.EndDate)
                .NotEmpty()
                .When(x => x.MilitaryStatusId == (int)MilitaryStatusTypes.Tecilli).WithMessage("Tecil tarihi boş bırakılamaz.");
        }

    }
}
