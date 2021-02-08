using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TobbyBlog.Entities;

namespace TobbyBlog.Data
{
    public class TobbyBlogDbContext: IdentityDbContext<IdentityUser>
    {

        public TobbyBlogDbContext(DbContextOptions<TobbyBlogDbContext> options) 
        : base(options)
        {

        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
