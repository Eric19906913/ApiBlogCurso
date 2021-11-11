using ApiBlog.Domain.DTOs;
using ApiBlog.Entities;
using AutoMapper;

namespace ApiBlog.Domain.Profilers
{
    public class ArticleProfiler : Profile
    {
        public ArticleProfiler() 
        {
            this.CreateMap<Article, ArticleDto>();
        }
    }
}
