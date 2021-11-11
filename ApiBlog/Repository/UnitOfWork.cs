using ApiBlog.Repository.Interfaces;
using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IArticleRepository ArticleRepository { get; }

        private readonly AppDbContext _appDbContext;
        private bool disposedValue;

        public UnitOfWork(AppDbContext dbContext, IArticleRepository articleRepository) 
        {
            this.ArticleRepository = articleRepository;
            this._appDbContext = dbContext;
        } 

        public async Task<int> CommitAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }

        public Task DiscardChangesAsync()
        {
            _appDbContext.ChangeTracker.Clear();
            return Task.CompletedTask;
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
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}
