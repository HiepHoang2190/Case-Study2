using Selling_Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels.ProductManagement
{
    public class ViewIndexManagementModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
