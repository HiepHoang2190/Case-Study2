using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Caching.Memory;
using Selling_Phone.ViewModels.Cart;

namespace Selling_Phone.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";

  

        public IActionResult Index()
        {
            var list = new List<CartItem>();
            return View(list);
        }
        public IActionResult AddItem(int productId, int quantity)
        {
            return View();
        }
    }
}
