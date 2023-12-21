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
        
        public async Task<IActionResult> Matches(int leagueId)
        {
            var events = await _eventService.GetEventsByLeagueIdAsync(leagueId);

            var leagues = await _leagueService.GetLeaguesByLeagueIdAsync(leagueId);

            var league = await _leagueService.GetLeagueByIdAsync(leagueId);
            var viewModel = new EventViewModel
            {
                League = league,
                Events = events,
                Leagues = leagues
            };
            return View(viewModel);
        }

        public async Task<IActionResult> Details(int eventId)
        {
            //var events = await _eventService.GetEventsByLeagueIdAsync(leagueId);

            //var leagues = await _leagueService.GetLeaguesByLeagueIdAsync(leagueId);

            //var league = await _leagueService.GetLeagueByIdAsync(leagueId);
            //var viewModel = new EventViewModel
            //{
            //    League = league,
            //    Events = events,
            //    Leagues = leagues
            //};
            //return View(viewModel);
            return View();
        }
    }
}
