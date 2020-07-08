using Selling_Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels.Home
{
    public class ListProductViewModel
    {
        public List<Product> Products { get; set; }
        public Product product { get; set; }
    }
}
