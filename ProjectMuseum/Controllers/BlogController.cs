using Microsoft.AspNetCore.Mvc;

namespace ProjectMuseum.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
