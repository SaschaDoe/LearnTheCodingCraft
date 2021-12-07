using Blog.Data.Authors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Tests.Authors
{
    [TestClass]
    public class AuthorTests
    {
        [TestInitialize]
        public void DeleteDatabase()
        {
            var authorContext = new Context();

            authorContext.DeleteAll();
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void AddAuthor()
        {
            var authorContext = new Context();
            var authorService = new AuthorService(authorContext);
            
            var author = new Author()
            {
                Name = "Muster",
                Description = "Ich bin..."
            };
            authorService.AddAuthor(author);

            var allAuthors = authorService.GetAllAuthors();
            Assert.AreEqual(1, allAuthors.Count);
            Assert.AreEqual("Muster", allAuthors[0].Name);
        }
    }
}
