using Microsoft.AspNetCore.Mvc;

namespace ProjectMuseum.Controllers
{
    public class ExhibitionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
