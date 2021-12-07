using Blog.Data.Authors;
using Blog.Data.BlogPost;
using Blog.Data.Categories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Tests.ScenarioTests
{
    [TestClass]
    public class AddPost
    {

        [TestMethod]
        public void AddPostWithCategory()
        {
            var author = AddAuthor("Sascha", "software developer");

            var category = AddCategory("TDD", "Test driven development");
            /*
            var blogPostContext = new BlogPostContext();
            var blogPostService = new BlogPostService(blogPostContext);

            var blogPost = new Post()
            {
                Title = "How TDD rocks!",
                CreatedDate = DateTime.Now,
                Content = "Content...",
                Authors = new List<Author>
                {
                    author,
                },
                Categories = new List<Category>
                {
                    category
                },
            };

            blogPostService.AddBlogPost(blogPost);


            var posts = blogPostService.GetAllBlogPosts();
            Assert.AreEqual("How TDD rocks!", posts[0].Title);
            Assert.AreEqual("TDD", posts[0].Categories[0]);
            Assert.AreEqual("Sascha", posts[0].Authors[0]);
            */
        }

        [TestInitialize]
        public void DeleteDatabase()
        {
            
            var authorContext = new Context();

            authorContext.DeleteAll();

 /*
            var blogPostContext = new BlogPostContext();

            blogPostContext.DeleteAll();
            */
        }

        private static Category AddCategory(string name, string description)
        {
            var categoryContext = new Context();
            var categoryService = new CategoryService(categoryContext);

            var category = new Category
            {
                Name = name,
                Description = description,
            };

            categoryService.AddCategory(category);

            return category;
        }

        private Author AddAuthor(string name, string description)
        {
            var authorContext = new Context();
            var authorService = new AuthorService(authorContext);

            var author = new Author()
            {
                Name = name,
                Description = description,
            };

            authorService.AddAuthor(author);

            return author;
        }
    }
}
