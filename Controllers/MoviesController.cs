using Microsoft.AspNetCore.Mvc;

namespace disntney_plus_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = new[]
            {
                new { Id = 1, Title= "The Lion King",Year=1994},
                new { Id = 2, Title="Frozen", Year=2013 },
                new { Id = 3, Title="Avengers Endgame", Year = 2019 }
            };
            return Ok(movies);
        }
    }
}
