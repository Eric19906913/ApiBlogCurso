using ApiBlog.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBlog.Repository
{
    public interface IArticleRepository : IGenericRepository<Article>
    {
        Task<IEnumerable<Article>> GetArticlesAsync();
    }
}
