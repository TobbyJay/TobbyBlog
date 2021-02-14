using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TobbyBlog.Entities;

namespace TobbyBlog.Services.Interface
{
    public interface IPostService
    {
        public IQueryable<Post> GetPosts();
        public IQueryable<Post> GetPostById(Guid id);
    }
}
