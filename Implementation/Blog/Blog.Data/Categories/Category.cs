using Blog.Data.BlogPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Categories
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Post> Posts { get; set; }
    }
}
