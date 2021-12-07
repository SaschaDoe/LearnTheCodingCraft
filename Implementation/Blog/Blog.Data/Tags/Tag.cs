using Blog.Data.BlogPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Tags
{
    public class Tag
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
