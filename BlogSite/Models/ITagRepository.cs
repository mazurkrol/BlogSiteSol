namespace BlogSite.Models
{
    public interface ITagRepository
    {
        public Tag Create(Tag tag);
        public void Delete(Tag tag);

    }
}
