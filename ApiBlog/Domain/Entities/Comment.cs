using System;

namespace ApiBlog.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }

        public User Author { get; set; }
        public int AuthorId { get; set; }
        
        public Article Article {  get; set; }
        public int ArticleId { get; set; }
    }
}
