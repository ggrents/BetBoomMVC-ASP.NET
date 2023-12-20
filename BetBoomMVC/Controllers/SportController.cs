using Microsoft.AspNetCore.Mvc;

namespace BetBoomMVC.Controllers
{
    public class SportController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
    }
}
