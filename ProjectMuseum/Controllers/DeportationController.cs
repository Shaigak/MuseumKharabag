using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using ProjectMuseum.ViewModels;

namespace ProjectMuseum.Controllers
{
    public class DeportationController : Controller
    {

        private readonly AppDbContext _context;

        public DeportationController(AppDbContext context)
        {

            _context = context; 

        }
        public async Task<IActionResult> Index()
        {



            List <BeforeDeportation> beforeDeportations =  await _context.BeforeDeportations.ToListAsync();
            List<DeportSlider> deportSliders = await _context.DeportSliders.ToListAsync();

            DeportVM model = new ()
            {
                DeportSliders = deportSliders,
                BeforeDeportations = beforeDeportations,
                

            };


            return View(model);
        }
    }
}
