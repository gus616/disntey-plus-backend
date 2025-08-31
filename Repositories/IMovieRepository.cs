using disntney_plus_api.Models;

namespace disntney_plus_api.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> GetByIdAsync(int id);
    }
}
