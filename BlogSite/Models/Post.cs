using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSite.Models
{
    public class Post
    {
        public int Id { get; set; }
        public List<PostTag> PostTags { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Post(string title, string description, string content)
        {
            Title=title;
            Description=description;
            Content=content;
            Date = DateTime.Now;
            PostTags=new List<PostTag>();
        }
        public Post()
        {
            PostTags=new List<PostTag>();
            Date=DateTime.Now;
        }
       /* public List<Tag> GetTags()
        {
            List<Tag> list = new List<Tag>();
            list=JsonConvert.DeserializeObject(this.Tags) as List<Tag>;
            return Tags;
        }
       */
        public bool CheckIfTagged(int TagId)
        {
            return true;
        }

    }
}
