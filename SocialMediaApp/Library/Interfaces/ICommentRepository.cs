using System;
using System.Collections.Generic;
using System.Text;
using Library.Models;


namespace Library.Interfaces
{
	public interface ICommentRepository : IDisposable
	{
		public void CreateComment(string commentText, int userId, int postId);

		public void DeleteCommentsByPostId(int postId);

		public IEnumerable<Models.Comment> CommentsByPostId(int postId);
	}
}
