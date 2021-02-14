using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TobbyBlog.Data;
using TobbyBlog.Entities;
using TobbyBlog.Services.Interface;

namespace TobbyBlog.Services.Implementation
{
    public class PostService : IPostService
    {
        private readonly TobbyBlogDbContext _context;

        public PostService(TobbyBlogDbContext context)
        {
            _context = context;

        }

        public IQueryable<Post> GetPosts()
        {
            var getPosts = _context.Posts
                .AsNoTracking();
            return getPosts;
        }


        public IQueryable<Post> GetPostById(Guid id)
        {
            var getPost = _context.Posts.AsNoTracking().Where(p => p.PostId == id);
            return getPost;
        }


    }
}
