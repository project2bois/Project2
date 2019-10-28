using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
	public class Comments
	{
		public int CommentId { get; set; }
		public int PostId { get; set; }
		public int UserId { get; set; }
		public string Content { get; set; }
		public DateTime CommentedDate { get; set; }

		public virtual Users User { get; set; }
		public virtual Posts Post { get; set; }
	}
}
