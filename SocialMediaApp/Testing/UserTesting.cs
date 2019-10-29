﻿using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class UserTesting
    {
        User user = new User();

        [Fact]
        public void FirstName_Null_ThrowException()
        {
            string nullString = null;

            Assert.Throws<ArgumentNullException>( () => user.FirstName = nullString );
        }

        [Fact]
        public void FirstName_EmptyString_ThrowException()
        {
            string emptyString = "";

            Assert.Throws<ArgumentException>( () => user.FirstName = emptyString );
        }

        [Fact]
        public void LastName_Null_ThrowException()
        {
            string nullString = null;

            Assert.Throws<ArgumentNullException>(() => user.LastName = nullString);
        }

        [Fact]
        public void LastName_EmptyString_ThrowException()
        {
            string emptyString = "";

            Assert.Throws<ArgumentException>(() => user.LastName = emptyString);
        }

        [Theory]
        [InlineData("beckany")]
        [InlineData("garbage")]
        [InlineData("Dillon")]
        public void FirstName_AlphabeticString_CorrectlyStored(string firstname)
        {
            user.FirstName = firstname;

            string expected = firstname.Substring(0, 1).ToUpper() + firstname.Substring(1).ToLower();

            Assert.Equal(expected, user.FirstName);
        }

        [Theory]
        [InlineData("winthrop")]
        [InlineData("Parlitan")]
        [InlineData("Francis")]
        public void LastName_AlphabeticString_CorrectlyStored(string lastname)
        {
            user.LastName = lastname;

            string expected = lastname.Substring(0, 1).ToUpper() + lastname.Substring(1).ToLower();

            Assert.Equal(expected, user.LastName);
        }
    }
}
