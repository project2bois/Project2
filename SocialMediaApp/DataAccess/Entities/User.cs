﻿using System;

namespace DataAccess
{
    public class User
    {
		public int UserId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public DateTime DateCreated { get; set; }
		
		public Entities.Post Post { get; set; }
		public Entities.Friendships Friends { get; set; }
		public Entities.Comment Comments { get; set; }
		
	}
}
