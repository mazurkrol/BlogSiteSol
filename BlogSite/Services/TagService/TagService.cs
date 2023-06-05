using BlogSite.Models;
namespace BlogSite.Services.TagService
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public Tag Create(string name)
        {
            Tag tag = new Tag(name);
            _tagRepository.Create(tag);
            return tag;
        }

        public void Delete(Tag tag)
        {
            _tagRepository.Delete(tag);
        }
    }
}
