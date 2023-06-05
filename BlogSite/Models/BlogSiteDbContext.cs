using Microsoft.EntityFrameworkCore;
namespace BlogSite.Models
{
    public class BlogSiteDbContext : DbContext
    {
        public BlogSiteDbContext(DbContextOptions<BlogSiteDbContext> options) : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

    }
}
