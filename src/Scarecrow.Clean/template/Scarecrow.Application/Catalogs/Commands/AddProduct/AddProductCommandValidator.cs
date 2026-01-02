using FluentValidation;

namespace Scarecrow.Application.Catalogs.Commands.AddProduct
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
