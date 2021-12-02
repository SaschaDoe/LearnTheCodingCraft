using Blog.Data.BlogPost;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blog.Data.Tests
{
    [TestClass]
    public class BlogTests
    {
        [TestMethod]
        public void AddNewBlog()
        {
            var blogPostContext = new BlogPostContext();
            var blogPostService = new BlogPostService(blogPostContext);

            var blogPost = new Post()
            {
                Title = "Title",
                Content = "Content...",

            };
            var result = blogPostService.AddBlogPost(blogPost);

            Assert.IsNotNull(result);
        }
    }
}