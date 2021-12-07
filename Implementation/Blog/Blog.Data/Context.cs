using Blog.Data.Authors;
using Blog.Data.BlogPost;
using Blog.Data.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class Context : ContextBase
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public Context()
        {
            Database.EnsureCreated();
        }
    }
}
