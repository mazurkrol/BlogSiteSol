namespace BlogSite.Models
{
    public class Tag
    {
        public int Id { get; set; }    
        public string tag { get; set; }
        public int uses_count { get; set; }
        public Tag(string name)
        {
            tag="#"+name;
        }
        public Tag()
        {

        }

    }
}
