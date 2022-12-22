using FluentValidation;
using Net5TestApp.Dtos.Concrete.ProvidedServiceDtos;

namespace Net5TestApp.Business.ValidationRules.ProvidedServiceValidators
{
    public class ProvidedServiceUpdateDtoValidator : AbstractValidator<ProvidedServiceUpdateDto>
    {
        public ProvidedServiceUpdateDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Zorunlu alan");

            RuleFor(x => x.ImagePath)
                .NotEmpty().WithMessage("Zorunlu alan")
                .MaximumLength(500).WithMessage("En fazla 300 karakter olmalıdır");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Zorunlu alan")
                .MaximumLength(300).WithMessage("En fazla 300 karakter olmalıdır");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Zorunlu alan");
        }
    }
}
