using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class BoardService : IBoardService
    {
        private List<Post> posts;

        public BoardService()
        {
            this.posts = new List<Post>();
        }

        public List<Post> getPosts()
        {
            return this.posts;
        }

        public bool deletePostsByUser(User user)
        {
            if (user != null)
            {
                foreach ( Post post in posts )
                {
                    if( post.author == user )
                    {
                        posts.Remove(post);
                    }
                }
            }
            return false;
        }

        public bool deletePostByPost(Post post)
        {
            if (post != null)
            {
                foreach (Post postm in posts)
                {
                    if (postm.postMessage.Equals(post))
                    {
                        deletePostByPost(postm);
                    }
                }
            }
            return false;
        }           
        public bool sortByUser(User user)
        {
            if (user != null)
            {
                sortByUser(user);
            }
            return false;
        }

        public bool sortByPosts()
        {
            return false;
        }
    }
}
