using Core.Domain.Entities;
using Infrastructure.Shared.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("admin")]
    public class AccountController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Route("login")]
        [Authorize]
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        [AllowAnonymous]
        //[Route("login")]
        [Route("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName,model.Password,model.RememberMe,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
            }
            return View(model);
        }
        [Route("logout")]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}
