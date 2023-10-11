using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using ProjectMuseum.Services.Interfaces;
using ProjectMuseum.ViewModels;
using System.Diagnostics;

namespace ProjectMuseum.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ISliderService _sliderService;


        public HomeController(AppDbContext context, ISliderService sliderService)
        {
            _context = context;
            _sliderService = sliderService;
        }

        public async Task<IActionResult> Index()
        {

            List<Slider> sliders = await _sliderService.GetAll();
            List<MiddleAbout> middleAbouts = await _context.MiddleAbouts.ToListAsync();
            List<Event> events = await _context.Events.ToListAsync();


            HomeVM model = new()

            {
                Events = events,
                MiddleAbouts = middleAbouts,
                Sliders = sliders

            };






            return View(model);
        }

   
    }
}