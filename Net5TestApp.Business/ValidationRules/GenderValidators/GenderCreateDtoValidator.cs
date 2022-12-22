using FluentValidation;
using Net5TestApp.Dtos.Concrete.GenderDtos;

namespace Net5TestApp.Business.ValidationRules.GenderValidators
{
    public class GenderCreateDtoValidator : AbstractValidator<GenderCreateDto>
    {
        public GenderCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
        }
    }
}
