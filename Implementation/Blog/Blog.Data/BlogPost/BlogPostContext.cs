using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.BlogPost
{
    public class BlogPostContext : DbContext
    {
        private static bool _created = false;
        public DbSet<Post> Posts { get; set; } 

        public BlogPostContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=mydatabase.db;");
        }
    }
}
