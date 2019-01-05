using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class Post
    {
        public Post(User author, String message)
        {
            this.author = author;
            this.postMessage = message;
        }

        public User author
        {
            private set;
            get;
        }

        public String postMessage
        {
            private set;
            get;
        }

    }
}
