using BlogSite.Services.PostService;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class PostController : Controller
    {
        public readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetPostData(string title, string description, string content, List<string> Tags)
        {         
            _postService.AddPost(Tags,title,description,content);
            return View("Views/Home/Index.cshtml");
        }
    }
}
