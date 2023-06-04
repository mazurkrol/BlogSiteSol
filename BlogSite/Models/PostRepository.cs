namespace BlogSite.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogSiteDbContext _context;
        public PostRepository(BlogSiteDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Post> GetPosts
        { 
            get
            { 
            return _context.Posts;
            }
        }
        public void AddPost(Post post) 
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
        public void RemovePost(int id) 
        {
            var _post = _context.Posts.Find(id);
            if (_post != null)
            {
                _post.Id = id; // Set a permanent value for SearchId
                _context.Posts.Remove(_post);
                _context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

    }
}
