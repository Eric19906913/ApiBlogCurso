using System;

namespace ApiBlog.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository articleRepository { get; }

        Task<int> CommitAsync();
        Task DiscardChangesAsync();
    }
}
