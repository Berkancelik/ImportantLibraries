using FluentValidation.Web.Models;

namespace FluentValidation.Web.FluentValidators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";

        public AddressValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage(NotEmptyMessage);

            RuleFor(x => x.Province)
                .NotEmpty()
                .WithMessage(NotEmptyMessage);

            RuleFor(x => x.PostCode)
                .NotEmpty()
                .WithMessage(NotEmptyMessage)
                .MaximumLength(5)
                .WithMessage("{PropertyName} alanı en fazla {MaxLength} karakterden fazla oluşabilir");
        }
    }
}
