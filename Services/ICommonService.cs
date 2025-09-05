namespace disntney_plus_api.Services
{
    public interface ICommonService<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(int id);
    }
}
