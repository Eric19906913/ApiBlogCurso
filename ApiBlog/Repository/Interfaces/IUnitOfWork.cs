using ApiBlog.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        Task<int> CommitAsync();
        Task DiscardChangesAsync();
    }
}
