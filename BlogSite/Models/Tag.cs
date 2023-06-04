namespace BlogSite.Models
{
    public class Tag
    {
        public int Id;      
        public string tag;
        public int uses_count;
        public Tag(string name)
        {
            tag="#"+name;
        }

    }
}
