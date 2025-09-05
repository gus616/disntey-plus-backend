namespace disntney_plus_api.Repositories
{
    public interface ICommonRepository<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(int id);
    }
}
