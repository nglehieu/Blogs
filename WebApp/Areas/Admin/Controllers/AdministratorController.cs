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
    [Route("admin/authorization")]
    public class AdministratorController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public AdministratorController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet("get-all-role")]
        public async Task<IActionResult> GetAllRole()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        [Route("create-role")]
        public async Task<IActionResult> CreateRole()
        {
            return View();
        }

        [Route("create-role")]
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel request)
        {
            if (ModelState.IsValid)
            {
                Role role = new Role
                {
                    Name = request.RoleName,
                    Description = request.Description
                };
                IdentityResult result =  await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(GetAllRole));
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(request);
        }
        [Route("update-role/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateRole(string id)
        {
            var item = await _roleManager.FindByIdAsync(id);
            if (item == null)
            {
                ViewBag.ErrorMessge = $"Role id ={id} không tìm thấy";
                return View("Not Found");
            }
            var model = new UpdateRoleViewModel()
            {
                Id = item.Id,
                RoleName = item.Name,
                Description = item.Description,
               
            };
            foreach (var user in _userManager.Users)
            {

                if (await _userManager.IsInRoleAsync(user, item.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [Route("update-role/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id.ToString());
            if (role == null)
            {
                ViewBag.ErrorMessage =
                    $"Role with Id: {model.Id} could not be found";
                return View("NotFound");
            }

            role.Name = model.RoleName;
            role.Description = model.Description;

            var result = await _roleManager.UpdateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(GetAllRole));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(model);
        }

        //[Route("update-user-role/{roleId}")]
        //[HttpGet]
        //public async Task<IActionResult> UpdateUsersInRole(string roleId)
        //{
        //    ViewBag.roleId = roleId;

        //    var role = await _roleManager.FindByIdAsync(roleId.ToString());

        //    if (role == null)
        //    {
        //        ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
        //        return View("NotFound");
        //    }

        //    var model = new List<UserRoleViewModel>();

        //    foreach (var user in _userManager.Users)
        //    {
        //        var userRoleViewModel = new UserRoleViewModel
        //        {
        //            UserId = user.Id,
        //            UserName = user.UserName
        //        };

        //        if (await _userManager.IsInRoleAsync(user, role.Name))
        //        {
        //            userRoleViewModel.IsSelected = true;
        //        }
        //        else
        //        {
        //            userRoleViewModel.IsSelected = false;
        //        }

        //        model.Add(userRoleViewModel);
        //    }

        //    return View(model);
        //}

        //[Route("update-user-role/{roleId}")]
        //[HttpPost]
        //public async Task<IActionResult> UpdateUsersInRole(List<UserRoleViewModel> model, string roleId)
        //{
        //    var role = await _roleManager.FindByIdAsync(roleId.ToString());

        //    if (role == null)
        //    {
        //        ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
        //        return View("NotFound");
        //    }

        //    for (int i = 0; i < model.Count; i++)
        //    {
        //        var user = await _userManager.FindByIdAsync(model[i].UserId.ToString());

        //        IdentityResult result = null;

        //        if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
        //        {
        //            result = await _userManager.AddToRoleAsync(user, role.Name);
        //        }
        //        else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
        //        {
        //            result = await _userManager.RemoveFromRoleAsync(user, role.Name);
        //        }
        //        else
        //        {
        //            continue;
        //        }

        //        if (result.Succeeded)
        //        {
        //            if (i < (model.Count - 1))
        //                continue;
        //            else
        //                return RedirectToAction(nameof(GetAllRole), new { Id = roleId });
        //        }
        //    }

        //    return RedirectToAction(nameof(GetAllRole), new { Id = roleId });
        //}

        [Route("delete-role/{id}")]
        [HttpGet]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await _roleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(GetAllRole));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(nameof(GetAllRole));
            }
        }
    }
}
