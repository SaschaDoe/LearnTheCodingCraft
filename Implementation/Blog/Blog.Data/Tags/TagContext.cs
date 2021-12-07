using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Tags
{
    public class TagContext : ContextBase
    {
        public DbSet<Tag> Tags { get; set; }

        public TagContext()
        {
            Database.EnsureCreated();
        }
    }
}
