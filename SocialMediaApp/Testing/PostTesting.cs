using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
	public class PostTesting
	{
		[Theory]
		[InlineData(null)]
		public void IsPostNull(string content) 
		{
			Library.Models.Post post = new Library.Models.Post();
			Assert.Throws<ArgumentNullException>(() => post.Content = content);
		}
		[Theory]
		[InlineData("")]
		public void IsPostEmpty(string content)
		{
			Library.Models.Post post = new Library.Models.Post();
			Assert.Throws<ArgumentOutOfRangeException>(()=>post.Content = content);
		}

		[Theory]
		[InlineData("abc")]
		public void IsPostTooLong(string content)
		{
			Library.Models.Post post = new Library.Models.Post();
			Assert.Throws<ArgumentOutOfRangeException>(() => post.Content = content);			
		}
	}
}
