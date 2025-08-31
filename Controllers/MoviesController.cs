using disntney_plus_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace disntney_plus_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _moviesService;
        public MoviesController(IMovieService moviesService)
        {
            _moviesService = moviesService;
        }
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
           var movies = await _moviesService.GetAllMoviesAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> GetMovieById(int id)
        {
            var movie = await _moviesService.GetMovieByIdAsync(id);
            return Ok(movie);
        }
    }
}
