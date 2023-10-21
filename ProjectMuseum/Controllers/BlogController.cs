using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using ProjectMuseum.ViewModels;

namespace ProjectMuseum.Controllers
{
    public class BlogController : Controller
    {


        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            List<Blog> blogs= await _context.Blogs.Where(m => !m.SoftDelete).Include(m => m.Images).ToListAsync();


            BlogVM model = new()
            {
                Blogs = blogs
            };
            
            
            return View(model);
        }

        public async Task<IActionResult> GetBlogView(int? id)
        {



            List<Blog> blogs = await _context.Blogs.Where(m => !m.SoftDelete).Include(m => m.Images).ToListAsync();




            BlogDetailVM model = new()
            {
                Blogs = blogs
            };

            return View(model);
        }



    }
}
