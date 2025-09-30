using disntney_plus_api.Data;
using disntney_plus_api.Models;
using Microsoft.EntityFrameworkCore;

namespace disntney_plus_api.Repositories
{
    public class RecommendationRepository
    {
        private readonly AppDbContext _context;

        public RecommendationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Recommendation>> GetAll()
        {
            return await _context.Recommendations.ToListAsync();
        }
    }
}
