using Blog.Data.BlogPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Authors
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[]? ProfileAvatarImage { get; set; }
        public byte[]? DescriptionImage { get; set; }

        public List<Post> Posts { get; set; }
        
    }
}
