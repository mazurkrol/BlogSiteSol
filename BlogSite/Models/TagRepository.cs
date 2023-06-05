namespace BlogSite.Models
{
    public class TagRepository
    {
        private readonly BlogSiteDbContext _context;

        TagRepository(BlogSiteDbContext context)
        {
            _context=context;
        }

        public Tag Create(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
            return tag;
        }

        public void Delete(Tag tag) 
        { 
            _context.Tags.Remove(tag);
            _context.SaveChanges();
        }
    }
}
