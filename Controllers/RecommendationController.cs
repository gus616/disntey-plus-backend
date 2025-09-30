using AutoMapper;
using disntney_plus_api.DTOs;
using disntney_plus_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace disntney_plus_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly RecommendationService _recommendationService;

        public RecommendationController(IMapper mapper, RecommendationService  recommendationService)
        {
            _mapper = mapper;
            _recommendationService = recommendationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecommendationDto>>> GetAll()
        {
            try
            {
                var recommendations = await _recommendationService.GetAllRecommendations();
                var dtos = _mapper.Map<List<RecommendationDto>>(recommendations);
                return Ok(dtos);
            }
            catch (Exception ex) {
                return StatusCode(500, new { message = "An internal server error ocurred", details = ex.Message });
            }
        }
    }
}
