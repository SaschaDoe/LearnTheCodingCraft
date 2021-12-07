using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Categories
{
    public class CategoryContext : ContextBase
    {
        public DbSet<Category> Categories { get; set; }

        public CategoryContext()
        {
            Database.EnsureCreated();
        }
    }
}
