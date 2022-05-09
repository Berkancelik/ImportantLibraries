using AutoMapper;
using FluentValidation.Web.DTOs;
using FluentValidation.Web.Models;

namespace FluentValidation.Web.Mapping
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();
        }
        
    }
}
