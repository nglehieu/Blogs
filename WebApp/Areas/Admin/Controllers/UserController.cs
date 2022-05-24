using Core.Domain.Entities;
using Infrastructure.Shared.ViewModel.Administrator;
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
    [Route("admin/users")]
    public class UserController : Controller
    {
        private readonly RoleManager<Role> _roleManager;

        private readonly UserManager<User> _userManager;

        public UserController(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var user = _userManager.Users;
            return View(user);
        }

        [Route("manage-user-roles/{userId}")]
        [HttpGet]
        // Phan quyen cho user
        public async Task<IActionResult> ManageUserRoles(string userid)
        {
            ViewBag.userId = userid;

            var user = await _userManager.FindByIdAsync(userid.ToString());

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id =  { userid} cannot be found";
                return View("NotFound");
            }
            var model = new List<UserRoleViewModel>();

            foreach (var role in _roleManager.Roles)
            {
                var userRole = new UserRoleViewModel
                {
                    roleId = role.Id,
                    roleName = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRole.isSelected = true;
                }
                else
                {
                    userRole.isSelected = false;
                }
                model.Add(userRole);
            }
            return View(model);
        }

        [Route("manage-user-roles/{userId}")]
        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<UserRoleViewModel> model, Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }

            result = await _userManager.AddToRolesAsync(user,
                model.Where(x => x.isSelected).Select(y => y.roleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }

            return RedirectToAction("GetAll");
        }

    }
}
