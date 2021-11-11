using System.Collections.Generic;

namespace ApiBlog.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email {  get; set; }
        public string Password {  get; set; }   
        public string Username {  get; set; }
        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public ICollection<Comment> Commnets { get; set; } = new List<Comment>();
    }
}
