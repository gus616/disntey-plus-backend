using AutoMapper;
using disntney_plus_api.DTOs;
using disntney_plus_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace disntney_plus_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _moviesService;
        private readonly IMapper _mapper;
        public MoviesController(IMovieService moviesService, IMapper mapper)
        {
            _moviesService = moviesService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _moviesService.GetAllMoviesAsync();
            var moviesDto = _mapper.Map<List<MovieDto>> (movies);
            return Ok(moviesDto);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> GetMovieById(int id)
        {
            var movie = await _moviesService.GetMovieByIdAsync(id);
            var movieDto = _mapper.Map<MovieDto>(movie);
            return Ok(movieDto);
        }
    }
}
