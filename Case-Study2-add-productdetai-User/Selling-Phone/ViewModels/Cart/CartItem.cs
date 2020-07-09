using Selling_Phone.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels.Cart
{
    [Serializable]
    public class CartItem:ViewHomeModel
    {   
     
        public int ProductId { set; get; }
        public int Quantity { set; get; }
    }
}
