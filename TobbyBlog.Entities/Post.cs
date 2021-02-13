using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace TobbyBlog.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        public Guid PostId { get; set; }
        [AllowHtml]
        public string HtmlContent { get; set; }
        public string Content { get; set; }
        public string DatePosted { get; set; }     
        ICollection<Comment> Comments { get; set; }
        public int Likes { get; set; }

    }
}
