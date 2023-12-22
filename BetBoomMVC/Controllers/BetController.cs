using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Application.ViewModels;
using BetBoomMVC.Application.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace BetBoomMVC.Controllers
{
    public class BetController : Controller
    {
        IOutcomeService _outcomeService;
        IBetService _betService;
        public BetController(IOutcomeService outcomeService, IBetService betService)
        {
            _outcomeService = outcomeService;
            _betService = betService;

        }
        public async Task<IActionResult> MakeBet(int outcomeId)
        {
            var outcome = await _outcomeService.GetOutcomeByIdAsync(outcomeId);

            var viewModel = new MakeBetViewModel
            {
                Outcome = outcome
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBet(int outcomeId, double amount)
        {
            var isAdded = await _betService.MakeBetAsync(outcomeId, amount);
            if (!isAdded) {
                return BadRequest(ModelState);

            }

            return RedirectToAction("Index", "Home");
        }

    }
}
