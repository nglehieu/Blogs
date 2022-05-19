using Core.Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Shared.Common;
using Infrastructure.Shared.ViewModel.Blog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/blog")]
    public class BlogsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public BlogsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _dbContext.Blogs.OrderByDescending(x => x.createdDate).ToListAsync();
            return View(result);
        }

        [HttpGet]
        [Route("create-blog")]
        public IActionResult Create()
        {
            ViewData["categoryId"] = new SelectList(_dbContext.Categories, "uuid", "name");
            return View();
        }
        [HttpPost]
        [Route("create-blog")]

        public async Task<IActionResult> Create(CreateBlogViewModel request)
        {
            if (ModelState.IsValid)
            {
                string post_imgae_path = "upload/posts/";

                if (request.image != null)
                {
                    var image = UploadImage.UploadImageFile(request.image, post_imgae_path);

                    var item = new Blog()
                    {
                        uuid = Guid.NewGuid().ToString(),
                        title = request.title,
                        content = request.content,
                        image = image, 
                        author = request.author,
                        categoryId = request.categoryId,
                        createdDate = DateTime.Now,
                    };
                    await _dbContext.Blogs.AddAsync(item);
                    await _dbContext.SaveChangesAsync();
                }
                return RedirectToAction(nameof(GetAll));
            }
            return View(request);
        }

        [HttpGet]
        [HttpPost("update-blog/{id}")]
        public async Task<IActionResult> Update(string id)
        {
            var item = await _dbContext.Blogs.Where(s => s.uuid == id).FirstOrDefaultAsync();
            return View(item);
        }

        [Route("update-blog/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(string id, UpdateBlogViewModel request)
        {
            var item = await _dbContext.Blogs.Where(s => s.uuid == id).FirstOrDefaultAsync();

            item.title = request.title;
            item.content = request.content;
            item.image = request.image;
            item.author = request.author;
            item.categoryId = request.categoryId;

            _dbContext.Update(item);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Category");
        }

        [HttpGet("delete-blog/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var item = await _dbContext.Blogs.Where(s => s.uuid == id).FirstOrDefaultAsync();
            _dbContext.Blogs.Remove(item);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

