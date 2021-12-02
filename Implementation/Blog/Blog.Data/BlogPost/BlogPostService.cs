using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.BlogPost
{
    public class BlogPostService
    {
        private BlogPostContext _blogPostContext;
        public BlogPostService(BlogPostContext blogPostContext)
        {
            _blogPostContext = blogPostContext;
        }

        public BlogPostContext AddBlogPost(Post blogPost)
        {
            using(var context = _blogPostContext)
            {
                _blogPostContext.Posts.Add(blogPost);
                _blogPostContext.SaveChanges();
                return context;
            }
        }

    }
}
