using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Categories
{
    public class CategoryService
    {
        private Context _categoryContext;
        public CategoryService(Context categoryContext)
        {
            _categoryContext = categoryContext;
        }

        public void AddCategory(Category category)
        {
            _categoryContext.Categories.Add(category);
            _categoryContext.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {

            return _categoryContext.Categories.ToList();

        }
    }
}
