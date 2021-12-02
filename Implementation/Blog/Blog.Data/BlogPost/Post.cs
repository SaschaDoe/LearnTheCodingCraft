using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.BlogPost
{
    public class Post
    {
        public int Id { get;set; }
        public string Title { get;set; }
        public DateTime CreatedDate { get;set; }
        public string Content { get;set; } 

    }
}
