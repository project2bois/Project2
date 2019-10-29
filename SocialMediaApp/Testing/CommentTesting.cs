using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
	public class CommentTesting
	{

		[Theory]
		[InlineData(null)]
		public void IsCommentNull(string content)
		{
			Library.Models.Comment comment = new Library.Models.Comment();
			Assert.Throws<ArgumentNullException>(() => comment.Content = content);
		}
		[Theory]
		[InlineData("")]
		public void IsCommentEmpty(string content)
		{
			Library.Models.Comment comment = new Library.Models.Comment();
			Assert.Throws<ArgumentOutOfRangeException>(() => comment.Content = content);
		}

		[Theory]
		[InlineData("abc")]
		public void IsCommentTooLong(string content)
		{
			Library.Models.Comment comment = new Library.Models.Comment();
			Assert.Throws<ArgumentOutOfRangeException>(() => comment.Content = content);
		}
	}
}
