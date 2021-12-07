using Blog.Data.BlogPost;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Data.Tests
{
    [TestClass]
    public class BlogTests
    {
        [TestInitialize]
        public void DeleteDatabase()
        {
            var blogPostContext = new BlogPostContext();

            blogPostContext.DeleteAll();
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void AddNewBlogAsync()
        {
            var blogPostContext = new BlogPostContext();
            var blogPostService = new BlogPostService(blogPostContext);

            var blogPost = new Post()
            {
                Title = "Title",
                CreatedDate = DateTime.Now,
                Content = "Content...",

            };
            blogPostService.AddBlogPost(blogPost);

            var actualPosts = blogPostService.GetAllBlogPosts();
            Assert.AreEqual(1, actualPosts.Count);
            Assert.AreEqual("Title", actualPosts[0].Title);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void GetBlog()
        {
            var blogPostContext = new BlogPostContext();
            var blogPostService = new BlogPostService(blogPostContext);

            var blogPostOne = new Post()
            {
                Title = "Title1",
                CreatedDate = DateTime.Now,
                Content = "Content...",

            };
            blogPostService.AddBlogPost(blogPostOne);

            var blogPostTwo = new Post()
            {
                Title = "Title2",
                CreatedDate = DateTime.Now,
                Content = "Content...",

            };
            blogPostService.AddBlogPost(blogPostTwo);

            var post = blogPostService.GetBlogPost(1);

            Assert.IsNotNull(post);
            Assert.AreEqual("Title1", post.Title);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void GetPosts_begin_to_end()
        {
            var blogPostContext = new BlogPostContext();
            var blogPostService = new BlogPostService(blogPostContext);

            var blogPostOne = new Post()
            {
                Title = "Title1",
                CreatedDate = DateTime.Now,
                Content = "Content...",

            };
            blogPostService.AddBlogPost(blogPostOne);

            var blogPostTwo = new Post()
            {
                Title = "Title2",
                CreatedDate = DateTime.Now,
                Content = "Content...",

            };
            blogPostService.AddBlogPost(blogPostTwo);

            var posts = blogPostService.GetBlogPost(0,2);

            Assert.IsNotNull(posts);
            Assert.AreEqual(2, posts.Count);
            Assert.AreEqual("Title1", posts[0].Title);
        }
    }
}