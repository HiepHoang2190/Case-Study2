using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext context;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Category Create(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return category;
        }

        public bool Delete(int id)
        {
            var delCat = context.Categories.Find(id);
            if (delCat != null)
            {
                context.Categories.Remove(delCat);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Category Edit(Category category)
        {
            var editCat = context.Categories.Attach(category);
            editCat.State = EntityState.Modified;
            context.SaveChanges();
            return category;
        }

        public Category Get(int id)
        {
            return context.Categories.Find(id);
        }

        public IEnumerable<Category> Gets()
        {
            return context.Categories;
        }
    }
}
