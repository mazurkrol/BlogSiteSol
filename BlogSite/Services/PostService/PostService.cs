using BlogSite.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BlogSite.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository=postRepository;
        }

        public void AddPost(List<Tag> tags, string title, string description, string content)
        {
            
            var post = new Post(tags, title, description, content);

        }
        public void RemovePost(int id)
        {
            _postRepository.RemovePost(id);
        }
        public IEnumerable<Post> GetPosts
        {
            get
            {
                return _postRepository.GetPosts;
            }
            
        }

    }
}
