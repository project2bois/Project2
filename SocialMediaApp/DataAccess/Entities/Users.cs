﻿using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Users
    {
		public int UserID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public int Gender { get; set; }
		public DateTime DateCreated { get; set; }
		
		public Posts Post { get; set; }
		public ICollection <Friendships> Friends { get; set; }
		public ICollection <Comments> Comments { get; set; }

		
	}
}
