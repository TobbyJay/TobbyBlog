using System;
using System.Collections.Generic;
using System.Text;

namespace TobbyBlog.Entities
{
    public class Comment
    {

        public Guid CommentId { get; set; }
        public Guid PostId { get; set; }
        public string SenderName { get; set; }
        public string SenderComment { get; set; }
        public string DateCommented { get; set; }

    }
}
