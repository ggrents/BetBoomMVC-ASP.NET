using BetBoomMVC.Application.RequestModels;
using BetBoomMVC.Application.Services.Interfaces;
using BetBoomMVC.Application.ViewModels;
using BetBoomMVC.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BetBoomMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IBetService _betservice;
        

        public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IBetService betservice)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _betservice = betservice;
        }
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginRequestModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                   
                    return RedirectToAction("Index", "Home"); 
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }

               
            }
            return View(model);
        }


        public ActionResult Register()
        {

            return View();
        }

        public async Task<ActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            
            var bets =await _betservice.GetBetsByUserAsync(user);
            var viewModel = new ProfileViewModel
            {
                Bets = bets
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home"); 
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

      
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home"); 
        }
    }
}
