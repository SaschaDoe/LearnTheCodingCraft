using Blog.Data.Authors;
using Blog.Data.BlogPost;
using Blog.Data.Categories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Tests.Categories
{
    [TestClass]
    public class CategoryTests
    {
        [TestInitialize]
        public void DeleteDatabase()
        {
            var categoryContext = new Context();

            categoryContext.DeleteAll();
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void AddCategory()
        {
            var categoryContext = new Context();
            var categoryService = new CategoryService(categoryContext);

            var category = new Category
            {
                Name = "Technical",
                Description = "..."
            };

            categoryService.AddCategory(category);

            var allCategories = categoryService.GetAllCategories();
            Assert.AreEqual(1, allCategories.Count);
            Assert.AreEqual("Technical", allCategories[0].Name);
        }
    }
}
