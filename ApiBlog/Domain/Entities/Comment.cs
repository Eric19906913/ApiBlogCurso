using System;

namespace ApiBlog.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public User Author { get; set; }
        public int UserId { get; set; }
        public DateTime Created {  get; set; }  
        public DateTime Updated {  get; set; }  
        public Article Article {  get; set; }
        public int ArticleId { get; set; }



    }
}
