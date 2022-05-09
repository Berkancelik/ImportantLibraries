using AutoMapper;
using FluentValidation.Web.DTOs;
using FluentValidation.Web.Models;

namespace FluentValidation.Web.Mapping
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x=> x.Mail))
                .ForMember(dest => dest.FullName, opt=> opt.MapFrom(x=>x.FullName2()));
        }
        
    }
}
