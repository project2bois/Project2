using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
	public class Post
	{
		public int PostId { get; set; }
		public int UserId { get; set; }
		public DateTime PostedDate { get; set; }
		public string Content { get; set; }

		public virtual User User { get; set; }
	}
}
