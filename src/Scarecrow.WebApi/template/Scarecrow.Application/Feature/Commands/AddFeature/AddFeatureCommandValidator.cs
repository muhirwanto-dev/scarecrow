using FluentValidation;

namespace Scarecrow.Application.Feature.Commands.AddFeature
{
    public class AddFeatureCommandValidator : AbstractValidator<AddFeatureCommand>
    {
        public AddFeatureCommandValidator()
        {
            RuleFor(x => x.Arg)
                .NotEmpty()
                .WithMessage("Argument should not empty");
        }
    }
}
