using FluentValidation.Web.Models;
using System;

namespace FluentValidation.Web.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";
        public CustomerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(NotEmptyMessage);

            RuleFor(x => x.Mail)
                .NotEmpty()
                .WithMessage(NotEmptyMessage)
                .EmailAddress()
                .WithMessage("Email alanı doğru formatta olmaldıır");

            RuleFor(x => x.Age)
                .NotEmpty()
                .WithMessage(NotEmptyMessage)
                .InclusiveBetween(18, 60)
                .WithMessage("Age alanı 18 ile 60 arasında olmalıdır.");

            RuleFor(x => x.BirthDay).NotEmpty().Must(x =>
            {
                return DateTime.Now.AddYears(-18)>=x;
            }).WithMessage("Yaşınız 18 Yaşından Büyük Olmalıdır");

        }
    }
}
