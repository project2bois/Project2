using DataAccess.Entities;
using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess.Repositories
{
	public class CommentRepository : ICommentRepository, IDisposable
	{
		private readonly NotTwitterDbContext _context;

		public CommentRepository(NotTwitterDbContext db)
		{
			_context = db;
		}

		public void CreateComment(string commentText, int userId, int postId)
		{
			var comment = new Comments
			{

				UserId = userId,
				PostId = postId,
				Content = commentText
			};

			_context.Add(comment);
			_context.SaveChanges();
		}

		public void DeleteCommentsByPostId(int postId)
		{
			var comments = _context.Comments.Where(p => p.PostId == postId);
			foreach (var comment in comments)
			{
				_context.Remove(comment);
			}

			_context.SaveChanges();
		}

		public IEnumerable<Comment> CommentsByPostId(int postId)
		{
			return _context.Comments.Where(p => p.PostId == postId).OrderByDescending(d => d.TimeSent).Select(Mapper.MapComments);
		}


		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
