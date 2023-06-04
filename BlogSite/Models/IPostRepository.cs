namespace BlogSite.Models
{
    public interface IPostRepository
    {
        void RemovePost(int id);
        IEnumerable<Post> GetPosts { get; }
        void AddPost(Post post);
    }
}
