using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IArticleRepository articleRepository { get; }
        private readonly AppDbContext appDbContext;
        public UnitOfWork(AppDbContext dbContext, IArticleRepository articleRepository) 
        {
            this.articleRepository = articleRepository;
            this.appDbContext = dbContext;
        } 

        public async Task<int> CommitAsync()
        {
            return await appDbContext.SaveChangesAsync();
        }

        public Task DiscardChangesAsync()
        {
            appDbContext.ChangeTracker.Clear();
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
