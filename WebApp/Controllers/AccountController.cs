using Core.Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Shared.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("")]
    public class AccountController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;

        public AccountController(Microsoft.AspNetCore.Identity.UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext context, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _config = config;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.UserName,
                    FisrtName = model.FisrtName,
                    LastName = model.LastName,
                    FullName = model.LastName + " " + model.FisrtName,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(Login));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded) { 
                //{
                //    var token = GenerateToken(model);
                    return RedirectToAction("Index", "Home");
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

        //private string GenerateToken(LoginViewModel model)
        //{
        //    var securityKey = Encoding.UTF8.GetBytes(_config["Jwt:Secret"]);

        //    var claims = new Claim[] {
        //            new Claim(ClaimTypes.Name,model.UserName),
        //            new Claim(ClaimTypes.Email,model.UserName)
        //        };

        //    var credentials = new SigningCredentials(new SymmetricSecurityKey(securityKey), SecurityAlgorithms.HmacSha256);

        //    var token = new JwtSecurityToken(_config["Jwt:Issuer"],
        //      _config["Jwt:Issuer"],
        //      claims,
        //      expires: DateTime.Now.AddDays(7),
        //      signingCredentials: credentials);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}
    }
}
