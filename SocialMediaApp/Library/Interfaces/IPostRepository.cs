using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface IPostRepository : IDisposable
    {
        //CRUD
        public void CreatePost();
        public IEnumerable<Post> GetPosts();
        public void UpdatePost();
        public void DeletePost();
    }
}
