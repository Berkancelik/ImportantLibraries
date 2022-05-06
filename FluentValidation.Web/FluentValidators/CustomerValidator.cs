using FluentValidation.Web.Models;

namespace FluentValidation.Web.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş olamaz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email alanı boş geçilemez").
                EmailAddress().WithMessage("Email alanı doğru formatta olmaldıır");
            RuleFor(x => x.Age).NotEmpty()
                .WithMessage("Age alanı boş olamaz").InclusiveBetween(18, 60)
                .WithMessage("Age alanı 18 ile 60 arasında olmalıdır.");

        }
    }
}
