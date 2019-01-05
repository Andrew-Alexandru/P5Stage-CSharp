using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    interface IPostService
    {
        User getAuthorByPost(Post post);
        List<Post> getPostsByAuthor(User author);
        bool deletePostsByAuthor(User author);
    }
}
