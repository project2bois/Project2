﻿using System;

namespace DataAccess
{
    public class Mapper
    {
        public static Library.Models.User MapUsers(Entities.Users users)
        {
            return new Library.Models.User
            {
                UserID = users.UserID,
                Username = users.Username,
                Password = users.Password,
                FirstName = users.FirstName,
                LastName = users.LastName,
                Email = users.Email,
                Gender = users.Gender
            };
        }

        public static Entities.Users MapUsers(Library.Models.User users)
        {
            return new Entities.Users
            {
                UserID = users.UserID,
                Username = users.Username,
                Password = users.Password,
                FirstName = users.FirstName,
                LastName = users.LastName,
                Email = users.Email,
                Gender = users.Gender
            };
        }

        public static Library.Models.Post MapPosts(Entities.Posts posts)
        {
            return new Library.Models.Post
            {
               PostID = posts.PostId,
               Content = posts.Content,
               TimeSent = posts.TimeSent
            };
        }

        public static Entities.Posts MapPosts(Library.Models.Post posts)
        {
            return new Entities.Posts
            {
                PostId = posts.PostID,
                Content = posts.Content,
                TimeSent = posts.TimeSent
            };
        }

        public static Library.Models.Comment MapComments(Entities.Comments comments)
        {
            return new Library.Models.Comment
            {
                CommentId = comments.CommentId,
                Content = comments.Content,
                TimeSent = comments.TimeSent
            };
        }

        public static Entities.Comments MapComments(Library.Models.Comment comments)
        {
            return new Entities.Comments
            {
                CommentId = comments.CommentId,
                PostId = comments.Post.PostID,
                UserId = comments.User.UserID,
                Content = comments.Content,
                TimeSent = comments.TimeSent
            };
        }

        public static Library.Models.Friendship MapFriendships(Entities.Friendships friendships)
        {
            return new Library.Models.Friendship
            {
                TimeRequestConfirmed = friendships.TimeRequestConfirmed,
                TimeRequestSent = friendships.TimeRequestSent

            };
        }

        public static Entities.Friendships MapFriendships(Library.Models.Friendship friendships)
        {
            return new Entities.Friendships
            {
                TimeRequestConfirmed = friendships.TimeRequestConfirmed,
                TimeRequestSent = friendships.TimeRequestSent
            };
        }
    }
}
