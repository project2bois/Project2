using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Post
    {
        /// <summary>
        /// ID of the post.
        /// </summary>
        public int PostID { get; set; }

        /// <summary>
        /// The user that this post was written by.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Text content of the post.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Time that the post was submitted.
        /// </summary>
        public DateTime TimeSent { get; set; }
    }
}
