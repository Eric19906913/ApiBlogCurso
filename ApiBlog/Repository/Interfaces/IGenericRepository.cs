using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        Task CreateAsync(T entity);
        Task RemoveAsync(Guid id);
        Task RemoveAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
