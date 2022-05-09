using AutoMapper;
using FluentValidation.Web.DTOs;
using FluentValidation.Web.Models;
using System;

namespace FluentValidation.Web.Mapping
{
    public class EventDateProfile:Profile
    {
        public EventDateProfile()
        {
            CreateMap<EvetDateDto, EventDate>()
                .ForMember(x => x.Date, opt => opt
                .MapFrom(x =>
                 new DateTime(x.Year, x.Month, x.Day)));

            CreateMap<EventDate, EvetDateDto>().ForMember(x => x.Year, opt => opt.MapFrom(
                   x => x.Date.Year)).ForMember(x=>x.Month, opt => opt.MapFrom(x=>x.Date.Month))
                   .ForMember(x=>x.Day, opt=> opt.MapFrom(x=>x.Date.Day));
        }
    }
}
