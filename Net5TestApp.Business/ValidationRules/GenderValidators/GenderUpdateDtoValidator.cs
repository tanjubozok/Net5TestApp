using FluentValidation;
using Net5TestApp.Dtos.Concrete.GenderDtos;

namespace Net5TestApp.Business.ValidationRules.GenderValidators
{
    public class GenderUpdateDtoValidator : AbstractValidator<GenderUpdateDto>
    {
        public GenderUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Definition).NotEmpty();
        }
    }
}
