using System;
namespace Blog.Entity.Concretes
{
    public class User : Blog.Entity.Abstracts.Entity
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }

		//Navigation Property

		public virtual List<Post> Posts { get; set; }
		public virtual
			List<Comment> Comments { get; set; }



		public User()
		{
			Posts = new List<Post>();
			Comments = new List<Comment>();

		}

		

	}
}

