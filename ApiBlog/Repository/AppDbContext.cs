using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBlog.Repository
{
    public class AppDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Article> Articles {  get; set; }
        DbSet<Comment> Comments {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
