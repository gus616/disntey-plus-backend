using disntney_plus_api.Models;
using disntney_plus_api.Repositories;

namespace disntney_plus_api.Services
{
    public class CategoriesService : ICommonService<Category>
    {
        private readonly ICommonRepository<Category> _repository;
        public CategoriesService(ICommonRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
