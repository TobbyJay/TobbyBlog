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
    public class CommentService : ICommentService
    {
        private readonly TobbyBlogDbContext _context;
        public CommentService(TobbyBlogDbContext context)
        {
            _context = context;
        }
        
        public IQueryable<Comment> GetComment(Guid id)
        {
            var comment = _context.Comments
                .AsNoTracking()
                .Where(c => c.PostId == id);
            return comment;
        }
    }
}
