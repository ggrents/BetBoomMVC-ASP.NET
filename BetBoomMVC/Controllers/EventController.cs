using BetBoomMVC.Application.Services;
using BetBoomMVC.Application.Services.Implementations;
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
        private readonly ISportTypeService _sportTypeService;
        private readonly IOutcomeService _outcomeService;

        public EventController(ILeagueService leagueService, IEventService eventService, ISportTypeService sportTypeService, IOutcomeService outcomeService)
        {
            _eventService = eventService;
            _leagueService = leagueService;
            _sportTypeService = sportTypeService;
            _outcomeService = outcomeService;
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
            
            var outcomes = await _outcomeService.GetOutcomesByEventIdAsync(eventId);
            var leagues  = await _leagueService.GetLeaguesByEventIdAsync(eventId);
            var _event = await _eventService.GetEventByIdAsync(eventId);

            var viewModel = new EventDetailsViewModel
            
            {
                Outcomes = outcomes,
                Leagues = leagues,
                Event = _event
            };
            return View(viewModel);


        }
    }
}
