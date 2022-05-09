using System;

namespace FluentValidation.Web.Models
{
    public class CreditCard
    {
        public string Number { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
