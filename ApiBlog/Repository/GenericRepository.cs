using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext appDbContext;
        private readonly DbSet<T> DbSet;
        public GenericRepository(AppDbContext dbContext) 
        {
            this.appDbContext = dbContext;
            this.DbSet = appDbContext.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            if (entity == null) 
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await DbSet.AddAsync(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Guid id)
        {
            return Task.FromResult(DbSet.Any(a => a.Id == id));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T> GetAsync(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("The id could not be empty");
            var entity = await DbSet.FindAsync(id);
            return entity;
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
