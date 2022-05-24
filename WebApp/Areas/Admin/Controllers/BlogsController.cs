using Core.Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Shared.Common;
using Infrastructure.Shared.ViewModel.Blog;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> GetAll(string? s, string? catId, string? aut)
        {
            var listCategories = await _dbContext.Categories.ToListAsync();
            ViewBag.ListCats = listCategories;
            var item = await (from b in _dbContext.Blogs
                              join c in _dbContext.Categories on b.categoryId equals c.uuid
                              where catId != null ? c.uuid == catId : c.uuid.Contains(String.Empty)
                              && aut != null ? b.author.Contains(aut) : b.author.Contains(String.Empty)
                              && s != null ? b.title.Contains(s) : b.title.Contains(String.Empty)
                              orderby b.createdDate descending
                              select new BlogsDto()
                              {
                                  uuid = b.uuid,
                                  content = b.content,
                                  author = b.author,
                                  categoryName = c.name,
                                  categoryId = c.uuid,
                                  image = b.image,
                                  title = b.title,
                                  status = true,
                                  createDate = DateTime.Now
                              }).ToListAsync();
            return View(item);
        }

        [HttpGet("details")]
        public async Task<IActionResult> Details(string id)
        {
            var item = await (from b in _dbContext.Blogs
                              join c in _dbContext.Categories on b.categoryId equals c.uuid
                              select new BlogsDto()
                              {
                                  uuid = b.uuid,
                                  content = b.content,
                                  author = b.author,
                                  categoryName = c.name,
                                  categoryId = c.uuid,
                                  image = b.image,
                                  title = b.title,
                                  status = true,
                                  createDate = DateTime.Now
                              }).FirstOrDefaultAsync();
            return View(item);
        }
            // Lafm toi details
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
        [Route("update-blog/{id}")]
        public async Task<IActionResult> Update(string id)
        {
            ViewData["categoryId"] = new SelectList(_dbContext.Categories, "uuid", "name");
            var result = await _dbContext.Blogs.FirstOrDefaultAsync(x => x.uuid == id);
            return View(result);
        }

        [Route("update-blog/{id}")]
        [HttpPost]
        public async Task<IActionResult> Update(string id, UpdateBlogViewModel request)
        {
            var item = await _dbContext.Blogs.FirstOrDefaultAsync(s => s.uuid == id);

            item.title = request.title;
            item.content = request.content;
            item.author = request.author;
            item.categoryId = request.categoryId;
            item.createdDate = DateTime.Now;

            _dbContext.Blogs.Update(item);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(GetAll));
        }

        [Route("update-image-blog/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateImage(string id, IFormFile imageUrl)
        {
            string POST_IMAGE_PATH = "upload/posts/";

            if (imageUrl != null)
            {

                var image = UploadImage.UploadImageFile(imageUrl, POST_IMAGE_PATH);

                var item = await _dbContext.Blogs.FirstOrDefaultAsync(s => s.uuid == id);

                item.image = image;

                _dbContext.Blogs.Update(item);
                await _dbContext.SaveChangesAsync();
                return Redirect("/admin/blog/update-blog/" + id);
            }
            return Redirect("/admin/blog/update-blog/" + id);
        }

        [HttpGet("delete-blog/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var item = await _dbContext.Blogs.Where(s => s.uuid == id).FirstOrDefaultAsync();
            _dbContext.Blogs.Remove(item);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(GetAll));
        }
    }
}

