using ApiBlog.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiBlog.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            this._articleService = articleService;
        }

        [HttpGet]
        public IActionResult GetAllArticles()
        {
            var articles = _articleService.GetAllArticlesAsync();
            return Ok(articles);
        }

        [HttpGet]
        [Route("/{articleId}")]
        public IActionResult GetArticle(Guid articleId)
        {
            var article = _articleService.GetByIdAsync(articleId);

            return Ok(article);
        }
    }
}
