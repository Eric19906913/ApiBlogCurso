using System;
using System.Collections.Generic;

namespace ApiBlog.Entities
{
    public class Article : BaseEntity
    {
        public User Author { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
