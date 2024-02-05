using System;
using Blog.Entity.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccses.Concretes.EntityFramework.Contexts
{
	public class BlogContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Blog;user=root;password=IAu1251.677");

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

