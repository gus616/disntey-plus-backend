using disntney_plus_api.Models;
using disntney_plus_api.Repositories;

namespace disntney_plus_api.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;
        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _repository.GetAllMovies();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
           return await _repository.GetByIdAsync(id);
        }
    }
}
