namespace SimpleChat.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAllAsync();

        Task<bool> AddAsync(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        Task<bool> RemoveAsync(TEntity entity);

        Task<IList<TEntity>> QueryAsync(
            params Func<TEntity, bool>[] predicates);
    }
}
