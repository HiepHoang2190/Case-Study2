using Selling_Phone.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> Gets();
        Product Create(Product product);
        Product Edit(Product product);
        Product Get(int id);
        bool Delete(int id);
    }
}
