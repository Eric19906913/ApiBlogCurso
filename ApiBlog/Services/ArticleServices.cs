using ApiBlog.Domain.DTOs;
using ApiBlog.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBlog.Services
{
    public class ArticleServices : IArticleService
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;
        public ArticleServices(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            this.uow = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ArticleDto>> GetAllArticlesAsync() 
        {
            var articles = await uow.articleRepository.GetAllAsync();

            return mapper.Map<IEnumerable<ArticleDto>>(articles);
        }

        public async Task<ArticleDto> GetByIdAsync(Guid id) 
        {
            var article = await uow.articleRepository.GetAsync(id);

            return mapper.Map<ArticleDto>(article);
        }
    }
}
