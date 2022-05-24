using Core.Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Shared.ViewModel.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/category")]
    //[Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _dbContext.Categories.OrderByDescending(x => x.createdDate).ToListAsync();
            return View(result);
        }

        [HttpGet("details")]
        public async Task<IActionResult> Details(string id)
        {
            var item = await _dbContext.Categories.FirstOrDefaultAsync();
            return View(item);
        }
        [HttpGet]
        [Route("create-category")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create-category")]

        public async Task<IActionResult> Create(CreateCategoryViewModel request)
        {
            if (ModelState.IsValid)
            {
                var item = new Category()
                {
                    uuid = Guid.NewGuid().ToString(),
                    name = request.name,
                    description = request.description,
                    createdDate = DateTime.Now,
                };
                await _dbContext.Categories.AddAsync(item);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(GetAll));
        }

        [HttpGet]
        [Route("update-category/{id}")]
        public async Task<IActionResult> Update(string id)
        {
            var item = await _dbContext.Categories.Where(s => s.uuid == id).FirstOrDefaultAsync();
            return View(item);
        }

        [Route("update-category/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(string id, UpdateCategoryViewModel model)
        {
            var item = await _dbContext.Categories.Where(s => s.uuid == id).FirstOrDefaultAsync();

            item.name = model.name;
            item.description = model.description;

            _dbContext.Categories.Update(item);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("get-all", "Category");
        }

        [HttpGet("delete-category/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var item = await _dbContext.Categories.Where(s => s.uuid == id).FirstOrDefaultAsync();
             _dbContext.Categories.Remove(item);
            _dbContext.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
