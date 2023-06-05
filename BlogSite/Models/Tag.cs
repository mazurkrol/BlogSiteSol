namespace BlogSite.Models
{
    public class Tag
    {
        public int Id { get; set; }    
        public string Text { get; set; }
        public Tag(string name)
        {
            Text="#"+name;
        }
        public Tag()
        {

        }

    }
}
