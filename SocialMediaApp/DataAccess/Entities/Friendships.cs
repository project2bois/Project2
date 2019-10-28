using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Friendships
    {
        public int User1ID { get; set; }
        public int User2ID { get; set; }
        public DateTime DateRequestSent { get; set; }
        public DateTime DateRequestConfirmed { get; set; } 
        public virtual Users User1 { get; set; }
        public virtual Users User2 { get; set; }

    }
}
