using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Models;
using YumBlazor.Repositories.Interfaces;

namespace YumBlazor.Repositories.Implementations
{
    public class CategoryRepository(ApplicationDbContext context) : ICategoryRepository
    {
        public async Task<Category> CreateAsync(Category category)
        {
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteAsync(int categoryId)
        {
            var category = await context.Categories.FirstOrDefaultAsync(_ => _.Id == categoryId);
            if (category != null)
            {
                context.Categories.Remove(category);
                return (await context.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<Category> GetAsync(int categoryId)
        {
            var category = await context.Categories.FirstOrDefaultAsync(_ => _.Id == categoryId);
            if (category == null) return new Category();
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<Category> UpdateAsync(Category newCategory)
        {
            var oldCategory = await context.Categories.FirstOrDefaultAsync(_ => _.Id == newCategory.Id);
            if (oldCategory != null)
            {
                oldCategory.Name = newCategory.Name;
                context.Categories.Update(oldCategory);
                await context.SaveChangesAsync();
                return oldCategory;
            }
            return newCategory;
        }
    }
}