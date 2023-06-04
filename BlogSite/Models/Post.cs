using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSite.Models
{
    public class Post
    {
        public int Id { get; set; }
        List<Tag> tags { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string title { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string description { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }

        public Post(List<Tag> tags, string title, string description, string content)
        {
            this.tags=tags;
            this.title=title;
            this.description=description;
            this.content=content;
            this.date = DateTime.Now;
        }
    }
}
