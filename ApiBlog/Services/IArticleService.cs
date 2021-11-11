using ApiBlog.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBlog.Services
{
    public interface IArticleService
    {
        public Task<IEnumerable<ArticleDto>> GetAllArticlesAsync();
        public Task<ArticleDto> GetByIdAsync(Guid id);
    }
}
