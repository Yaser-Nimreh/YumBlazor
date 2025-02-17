using YumBlazor.Models;

namespace YumBlazor.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category);
        public Task<Category> UpdateAsync(Category category);
        public Task<bool> DeleteAsync(int categoryId);
        public Task<Category> GetAsync(int categoryId);
        public Task<IEnumerable<Category>> GetAllAsync();
    }
}