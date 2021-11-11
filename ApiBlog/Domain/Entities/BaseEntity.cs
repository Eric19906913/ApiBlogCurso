using System;

namespace ApiBlog.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid Created_User { get; set; }
        public Guid Updated_User { get; set; }
    }
}
