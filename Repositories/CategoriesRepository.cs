using disntney_plus_api.Data;
using disntney_plus_api.Models;
using Microsoft.EntityFrameworkCore;

namespace disntney_plus_api.Repositories
{
    public class CategoriesRepository : ICommonRepository<Category>
    {
        private readonly AppDbContext _context;

        public CategoriesRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _context.Categories
                .Include(c => c.CategoryGallery)
                .ToListAsync();
            return categories;
        }

        public async Task<Category> GetByIdAsync(int id) =>
            await _context.Categories
            .Include(c => c.CategoryGallery)
            .FirstOrDefaultAsync(c => c.Id == id);
        
    }
}
