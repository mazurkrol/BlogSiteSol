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
        public List<Tag> Tags { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Post(List<Tag> tags, string title, string description, string content)
        {
            Tags = tags;
            Title=title;
            Description=description;
            Content=content;
            Date = DateTime.Now;
        }
        public Post()
        {
            Tags=new List<Tag>();
            Date=DateTime.Now;
        }
        public List<Tag> GetTags()
        {
            //List<Tag> list = new List<Tag>();
            //list=JsonConvert.DeserializeObject(this.Tags) as List<Tag>;
            return Tags;
        }
        public bool CheckIfTagged(int TagId)
        {
            List<Tag> tags = this.GetTags();
            foreach(Tag tag in tags) 
            {
                if (tag.Id == TagId)
                    return true;
            }
            return false;
        }

    }
}
