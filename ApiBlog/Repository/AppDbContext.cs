using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBlog.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles {  get; set; }
        public DbSet<Comment> Comments {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
