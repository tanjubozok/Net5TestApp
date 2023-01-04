using FluentValidation;
using Net5TestApp.Dtos.Concrete.ProvidedServiceDtos;

namespace Net5TestApp.Business.ValidationRules.ProvidedServiceValidators
{
    public class ProvidedServiceCreateDtoValidator : AbstractValidator<ProvidedServiceCreateDto>
    {
        public ProvidedServiceCreateDtoValidator()
        {
            RuleFor(x => x.ImagePath)
                .NotEmpty().WithMessage("Resim yolu zorunlu alan")
                .MaximumLength(500).WithMessage("En fazla 300 karakter olmalıdır");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık zorunlu alan")
                .MaximumLength(300).WithMessage("En fazla 300 karakter olmalıdır");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama zorunlu alan");
        }
    }
}
