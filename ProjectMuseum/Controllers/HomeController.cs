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
            List<FirstDeportation> firstDeportations = await _context.FirstDeportations.ToListAsync();
            List<SecondDeportation> secondDeportations = await _context.SecondDeportations.ToListAsync();
            List<Blog> blogs =  await _context.Blogs.Where(m => !m.SoftDelete).Include(m => m.Images).ToListAsync();

            List<BigNewsBanner> bigNews = await _context.BigNewsBanners.Where(m => !m.SoftDelete).ToListAsync();

            List<MartyrOfAzerbaijan> martyrOfAzerbaijans = await _context.MartyrOfAzerbaijans.ToListAsync();


            HomeVM model = new()

            {
                BigNewsBanners = bigNews,
                Blogs = blogs,
                MartyrOfAzerbaijans=martyrOfAzerbaijans,
                SecondDeportations = secondDeportations,
                FirstDeportations = firstDeportations,
                Events = events,
                MiddleAbouts = middleAbouts,
                Sliders = sliders

            };






            return View(model);
        }

   
    }
}