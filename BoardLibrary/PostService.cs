using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    class PostService : IPostService 
    {
        private List<Post> posts;

        public PostService()
        {
            posts = new List<Post>();
        }

        public Post this[int index]
        {
            get
            {
                return posts[index];
            }
            set
            {
                posts[index] = value;
            }
        }

        public User getAuthorByPost(Post post)
        {
            return post.author;
        }

        public List<Post> getPostsByAuthor(User author)
        {
            List<Post> returnPosts = new List<Post>();
            if (author == null)
            {
                return returnPosts;
            }
            foreach (Post post in posts )
            {
                if(post.author.Equals(author))
                {
                    returnPosts.Add(post);
                }
            }
            return returnPosts;
        }

        public bool deletePostsByAuthor(User author)
        {
            if(author == null)
            {
                return false;
            }
            foreach (Post post in posts)
            {
                if (post.author.Equals(author))
                {
                    posts.Remove(post);
                }
            }
            return true;
        }
    }
}
