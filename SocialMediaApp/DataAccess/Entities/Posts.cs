using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
	public class Posts
	{
		public int PostId { get; set; }
		public int UserId { get; set; }
		public DateTime PostedDate { get; set; }
		public string Content { get; set; }

		public virtual Users User { get; set; }
<<<<<<< HEAD
=======
        public virtual ICollection <Comments> Comments  {get; set; }
>>>>>>> ffde8e0a818a38a1429f7265f29a5e96f0e14546
	}
}
