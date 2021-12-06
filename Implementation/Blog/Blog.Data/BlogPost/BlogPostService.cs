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

        public void AddBlogPost(Post blogPost)
        {
            _blogPostContext.Posts.Add(blogPost);
            _blogPostContext.SaveChanges();
        }

        /// <summary>
        /// Get all posts and delete them
        /// </summary>
        /// <returns></returns>
        public BlogPostContext DeleteAllPosts()
        {
            using (var context = _blogPostContext)
            {
                var allPosts = _blogPostContext.Posts;

                foreach(var post in allPosts)
                {
                    _blogPostContext.Posts.Remove(post);
                }

                _blogPostContext.SaveChanges();
                return context;
            }
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
    }
}
