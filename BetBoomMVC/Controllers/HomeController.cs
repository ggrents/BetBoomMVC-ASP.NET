using BetBoomMVC.Application.Services;
using BetBoomMVC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BetBoomMVC.Controllers
{
    public class HomeController : Controller
    {

        private ISportTypeService _sportTypeService;
        public HomeController(ILogger<HomeController> logger, ISportTypeService sportTypeService)
        {
            _sportTypeService = sportTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var sports = await _sportTypeService.GetSportTypesAsync();

            var viewModel = new IndexViewModel
            {
                SportTypes = sports
            };

            return View(viewModel);
        }

        public IActionResult Stocks()
        {
           
            return View();
        }

     
    }
}