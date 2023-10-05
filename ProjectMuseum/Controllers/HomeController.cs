using Microsoft.AspNetCore.Mvc;
using ProjectMuseum.Data;
using ProjectMuseum.Models;
using System.Diagnostics;

namespace ProjectMuseum.Controllers
{
    public class HomeController : Controller
    {
   
     
        public IActionResult Index()
        {
            return View();
        }

   
    }
}