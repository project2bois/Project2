﻿using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class Users
    {
		public int UserId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public DateTime DateCreated { get; set; }
		
		public Entities.Posts Post { get; set; }
		public Entities.Friendships Friends { get; set; }
<<<<<<< HEAD
		public Entities.Comments Comments { get; set; }
=======
		public ICollection <Entities.Comments> Comments { get; set; }
>>>>>>> ffde8e0a818a38a1429f7265f29a5e96f0e14546
		
	}
}
