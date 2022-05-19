using Core.Domain.Entities;
using Infrastructure.Shared.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Shared.IServices
{
    public interface ICategoryServices
    { 
        Task<Category> GetByIdAsync(string id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<CreateCategoryViewModel> Create(CategoryDto entity);
        Task<CreateCategoryViewModel> Update(CategoryDto entity);
        Task<string> Delete(Guid id);
    }
}
