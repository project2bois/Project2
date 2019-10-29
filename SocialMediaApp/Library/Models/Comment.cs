using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Comment
    {
        /// <summary>
        /// This comment's ID. 0 if new comment.
        /// </summary>
        public int CommentId { get; set; }

        /// <summary>
        /// The post that this comment is posted to.
        /// </summary>
        public Post Post { get; set; }

        /// <summary>
        /// The user that this comment was written by
        /// </summary>
        public User User { get; set; }
        
        /// <summary>
        /// The text content of the comment.
        /// </summary>
        /// <remarks>
        /// Removes any special characters (?) that could potentially break code
        /// </remarks>
        public string Content { get; set; }

        /// <summary>
        /// Time that the comment was written.
        /// </summary>
        public DateTime TimeSent { get; set; }
    }
}
