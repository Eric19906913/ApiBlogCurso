using System;
using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();
        Task DiscardChangesAsync();
    }
}
