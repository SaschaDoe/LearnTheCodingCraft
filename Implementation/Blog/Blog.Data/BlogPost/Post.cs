using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Authors;
using Blog.Data.Categories;
using Blog.Data.Tags;

namespace Blog.Data.BlogPost
{
    public class Post
    {
        public int Id { get;set; }
        public string Title { get;set; }
        public DateTime CreatedDate { get;set; }
        public string Content { get;set; } 
        public List<Author> Authors { get;set; }
        //public List<Tag> Tags { get; set; }
        //public List<Category> Categories { get; set; }

    }
}
