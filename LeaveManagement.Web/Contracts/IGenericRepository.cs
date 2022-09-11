namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> GetAsync(int? id);
        Task<List<TEntity>> GetAllAsync();
        Task<bool> Exists(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task AddRangeAsync(List<TEntity> entities);
        Task DeleteAsync(int id);
        Task UpdateAsync(TEntity entity);
    }
}
