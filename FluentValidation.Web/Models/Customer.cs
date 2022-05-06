using System;
using System.ComponentModel.DataAnnotations;
namespace FluentValidation.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
   
        public DateTime? BirthDay { get; set; }

    }
}
