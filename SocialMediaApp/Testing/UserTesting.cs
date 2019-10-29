using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class UserTesting
    {
        [Fact]
        public void FirstName_Null_ThrowException()
        {
            User user = new User();
            string nullString = null;

            Assert.Throws<ArgumentNullException>( () => user.FirstName = nullString );
        }

        [Fact]
        public void FirstName_EmptyString_ThrowException()
        {
            User user = new User();
            string emptyString = "";

            Assert.Throws<ArgumentException>( () => user.FirstName = emptyString );
        }
    }
}
