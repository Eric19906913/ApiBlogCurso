using ApiBlog.Entities;
using System.Collections.Generic;

namespace ApiBlog.Domain.DTOs
{
    public class ArticleDto
    {
        public UserHeaderDto Author { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
