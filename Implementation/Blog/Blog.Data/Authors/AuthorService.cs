using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Authors
{
    public class AuthorService
    {
        private AuthorContext _authorContext;
        public AuthorService(AuthorContext authorContext)
        {
            _authorContext = authorContext;
        }

        public void AddAuthor(Author author)
        {
            _authorContext.Authors.Add(author);
            _authorContext.SaveChanges();
        }

        public List<Author> GetAllAuthors()
        {
            return _authorContext.Authors.ToList();
        }
    }
}
