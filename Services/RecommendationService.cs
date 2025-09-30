using disntney_plus_api.Models;
using disntney_plus_api.Repositories;

namespace disntney_plus_api.Services
{
    public class RecommendationService
    {
        private readonly RecommendationRepository _repository;

        public RecommendationService(RecommendationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Recommendation>> GetAllRecommendations()
        {
            return await _repository.GetAll();
        }
    }
}
