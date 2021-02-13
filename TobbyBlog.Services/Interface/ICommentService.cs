using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TobbyBlog.Entities;

namespace TobbyBlog.Services.Interface
{
    public interface ICommentService
    {
      
        public IQueryable<Comment> GetComment(Guid id);
    }
}
