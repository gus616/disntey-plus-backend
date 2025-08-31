using disntney_plus_api.Data;
using disntney_plus_api.Models;
using Microsoft.EntityFrameworkCore;

namespace disntney_plus_api.Repositories
{    
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _context.Movies
                .Include(m => m.Images)
                .ToListAsync();
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _context.Movies
                .Include(m => m.Images)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
