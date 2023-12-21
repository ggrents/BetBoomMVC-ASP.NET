using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Application.ViewModels;
using BetBoomMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BetBoomMVC.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ILeagueService _leagueService;
        public EventController(ILeagueService leagueService, IEventService eventService)
        {
            _eventService = eventService;
            _leagueService = leagueService;
        }
        [Route("Spor/League/{leagueId}/")]
        public async Task<IActionResult> Matches(int leagueId)
        {
            var events = _eventService.GetEventsByLeagueIdAsync(leagueId);
            var leagues = _leagueService.GetLeaguesBySportIdAsync

            var viewModel = new EventViewModel
            {
                
            }
            return View();
        }
    }
}
