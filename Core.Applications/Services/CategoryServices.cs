using Core.Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Shared.IServices;
using Infrastructure.Shared.ViewModel.Category;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Applications.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var result = await _dbContext.Categories.ToListAsync();
            return result;
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            var result = await _dbContext.Categories.FirstOrDefaultAsync(x => x.uuid == id);
            return result;
        }

        public Task<CreateCategoryViewModel> Create(CategoryDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<CreateCategoryViewModel> Update(CategoryDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
