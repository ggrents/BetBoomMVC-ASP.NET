using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BetBoomMVC.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController(ILogger<HomeController> logger)
        {
          
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

     
    }
}