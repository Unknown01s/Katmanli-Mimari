using System;
namespace Blog.Entity.Concretes
{
	public class Post : Blog.Entity.Abstracts.Entity
	{

		public string Content { get; set; }
		public string Photo { get; set; }

	}
}

