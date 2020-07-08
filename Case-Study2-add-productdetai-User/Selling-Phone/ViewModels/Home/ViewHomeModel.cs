using Selling_Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels.Home
{
    public class ViewHomeModel:SearchKey
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
       

    }
}
