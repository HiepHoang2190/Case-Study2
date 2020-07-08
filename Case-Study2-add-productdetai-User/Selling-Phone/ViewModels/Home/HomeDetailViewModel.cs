using Microsoft.AspNetCore.Authorization;
using Selling_Phone.Models;
using Selling_Phone.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels
{   
    public class HomeDetailViewModel
    {
        public Product product { get; set; }
        public string TitleName { get; set; }

    }
}
