using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    interface IBoardService
    {
        List<Post> getPosts();
        bool deletePostsByUser(User user);
        bool deletePostByPost(Post post);
        bool sortByUser(User user);
        bool sortByPosts();
    }
}
