using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.BlogPost
{
    public class BlogPostContext : ContextBase
    {
        public DbSet<Post> Posts { get; set; } 

        public BlogPostContext()
        {
             Database.EnsureCreated();
        }
    }
}
