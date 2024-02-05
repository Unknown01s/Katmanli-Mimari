using System;
using Blog.DataAccses.Abstracts;
using Blog.DataAccses.Concretes.EntityFramework.Contexts;
using Blog.Entity.Concretes;
namespace Blog.DataAccses.Concretes.EntityFramework.Concretes
{
	public class PostRepository : BaseRepository<Post,BlogContext>,IPostRepository
	{
		
	}
}

