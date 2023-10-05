using Microsoft.AspNetCore.Mvc;

namespace ProjectMuseum.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
