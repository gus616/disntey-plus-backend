using disntney_plus_api.Models;

namespace disntney_plus_api.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
