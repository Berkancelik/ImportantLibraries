using System;
using System.Collections.Generic;
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
        public IList<Address> Addresses { get; set; }
        public Gender Gender { get; set; }

        public string FullName2()
        {
            return $"{Name}-{Mail}-{Age}";
        }

    }
}
