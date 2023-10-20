using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using ProjectMuseum.ViewModels;

namespace ProjectMuseum.Controllers
{
    public class DocumentController : Controller
    {

        private readonly AppDbContext _context;

        public DocumentController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {


            List<Document> documents = await _context.Documents.ToListAsync();


            DocumentVM model = new()
            {

                Documents = documents

            };


            return View(model);
        }
    }
}
