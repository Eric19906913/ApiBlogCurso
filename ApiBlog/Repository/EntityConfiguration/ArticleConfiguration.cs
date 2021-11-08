using ApiBlog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBlog.Repository.EntityConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Title).IsRequired();
            builder.HasOne(u => u.Author).WithMany(a => a.Articles).HasForeignKey(a => a.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(a => a.Comments).WithOne(c => c.Article).HasForeignKey(a => a.ArticleId);
        }
    }
}
