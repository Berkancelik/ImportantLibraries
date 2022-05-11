using AutoMapper;
using FluentValidation.Web.DTOs;
using FluentValidation.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Web.Controllers
{
    public class ProjectionController : Controller
    {
        private readonly IMapper _mapper;

        public ProjectionController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Index(EvetDateDto evetDateDto)
        {
            EventDate eventDate = _mapper.Map<EventDate>(evetDateDto);
            ViewBag.date = eventDate.Date.ToShortDateString();
            return View();
        }
    }
}
