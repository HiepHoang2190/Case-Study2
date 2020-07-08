using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Gets();
        Category Create(Category category);
        Category Edit(Category category);
        Category Get(int id);
        bool Delete(int id);
    }
}
