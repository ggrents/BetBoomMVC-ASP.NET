using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Application.ViewModels;
using BetBoomMVC.Application.RequestModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Controllers
{
    public class BetController : Controller
    {
        IOutcomeService _outcomeService;
        IBetService _betService;
        private readonly UserManager<ApplicationUser> _userManager;
        public BetController(IOutcomeService outcomeService, IBetService betService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
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
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "User");
            }


            var isAdded = await _betService.MakeBetAsync(outcomeId, amount, user);
            if (!isAdded) {
                return BadRequest(ModelState);

            }

            return RedirectToAction("Index", "Home");
        }

    }
}
