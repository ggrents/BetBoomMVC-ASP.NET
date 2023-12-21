using BetBoomMVC.Application.Services;
using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Application.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using BetBoomMVC.Application.ViewModels;

namespace BetBoomMVC.Controllers
{
    public class SportController : Controller
    {
        private ISportTypeService _sportTypeService;
        private ILeagueService _leagueService;

        public SportController(ISportTypeService sportTypeService, ILeagueService leagueService)
        {
            _sportTypeService = sportTypeService;
            _leagueService = leagueService;
        }
        public async Task<IActionResult> Details(int id)
        {
            var sportTypes = await _sportTypeService.GetSportTypesAsync();
            var leagues = await _leagueService.GetLeaguesBySportIdAsync(id);
            var sportType = await _sportTypeService.GetSportTypeByIdAsync(id);

            var viewModel = new SportDetailsViewModel
            {
                SportType = sportType,
                SportTypes = sportTypes,
                Leagues = leagues
            };

            return View(viewModel);
        }
    }
}
