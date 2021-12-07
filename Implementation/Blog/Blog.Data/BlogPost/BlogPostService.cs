using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.BlogPost
{
    public class BlogPostService
    {
        private Context _blogPostContext;
        public BlogPostService(Context blogPostContext)
        {
            _blogPostContext = blogPostContext;
        }

        public void AddBlogPost(Post blogPost)
        {
            _blogPostContext.Posts.Add(blogPost);
            _blogPostContext.SaveChanges();
        }

       

        public List<Post> GetAllBlogPosts()
        {
           
            return _blogPostContext.Posts.ToList();

        }

        public Post GetBlogPost(int postId)
        {
            using (var context = _blogPostContext)
            {
                foreach(var post in _blogPostContext.Posts)
                {
                   if(post.Id == postId)
                    {
                        return post;
                    }
                }
            }

            return null;
        }

        public List<Post> GetBlogPost(int begin, int end)
        {
            return _blogPostContext.Posts.Skip(begin).Take(end).ToList();
        }
    }
}
