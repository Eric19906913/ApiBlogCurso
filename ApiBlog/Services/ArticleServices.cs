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
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ArticleServices(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            this._uow = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<ArticleDto>> GetAllArticlesAsync() 
        {
            var articles = await _uow.ArticleRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ArticleDto>>(articles);
        }

        public async Task<ArticleDto> GetByIdAsync(Guid id) 
        {
            var article = await _uow.ArticleRepository.GetAsync(id);

            return _mapper.Map<ArticleDto>(article);
        }
    }
}
