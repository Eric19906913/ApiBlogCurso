using ApiBlog.Repository;
using ApiBlog.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiBlog.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticleController : ControllerBase
    {
        private IArticleService articleService;
        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        [HttpGet]
        public IActionResult GetAllArticles()
        {
            var articles = articleService.GetAllArticlesAsync();
            return Ok(articles);
        }

        [HttpGet]
        [Route("/{articleId}")]
        public IActionResult GetArticle(Guid articleId)
        {
            var article = articleService.GetByIdAsync(articleId);

            return Ok(article);
        }
    }
}
