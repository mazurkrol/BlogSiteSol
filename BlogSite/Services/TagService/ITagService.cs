using BlogSite.Models;
namespace BlogSite.Services.TagService
{
    public interface ITagService
    {
        Tag Create(string name);
        void Delete(Tag tag);
    }
}
