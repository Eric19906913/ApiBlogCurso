using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;
        private bool disposedValue;

        public GenericRepository(AppDbContext dbContext) 
        {
            this._appDbContext = dbContext;
            this._dbSet = _appDbContext.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _dbSet.AddAsync(entity);
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await Task.FromResult(_dbSet.Any(a => a.Id == id));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException(nameof(id), "The id could not be empty");
            var entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public async Task RemoveAsync(Guid id)
        {
            throw await Task.FromResult(new NotImplementedException());
        }

        public async Task RemoveAsync(T entity)
        {
            throw await Task.FromResult(new NotImplementedException());
        }

        public async Task UpdateAsync(T entity)
        {
            throw await Task.FromResult(new NotImplementedException());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~GenericRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
