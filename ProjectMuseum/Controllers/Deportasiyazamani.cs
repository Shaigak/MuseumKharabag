using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using ProjectMuseum.ViewModels;

namespace ProjectMuseum.Controllers
{
    public class Deportasiyazamani : Controller
    {


        private readonly AppDbContext _context;


        public Deportasiyazamani(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

          
            
            List<DeportationTime> deportationTimes = await _context.DeportationTimes.ToListAsync();




            DeportationTimeVM model = new()
            {
                DeportationTimes = deportationTimes
            };

         



            return View(model);
        }
    }
}
