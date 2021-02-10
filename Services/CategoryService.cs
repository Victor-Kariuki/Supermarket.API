using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Services;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryService;

        public CategoryService(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryService.ListAsync();
        }
    }
}
