using BlogSite.Models;
namespace BlogSite.Services.PostService
{
    public interface IPostService
    {
        IEnumerable<Post> GetPosts{ get; }
        void AddPost(List<string> tags, string title, string description, string content);
        void RemovePost(int id);
    }
}
