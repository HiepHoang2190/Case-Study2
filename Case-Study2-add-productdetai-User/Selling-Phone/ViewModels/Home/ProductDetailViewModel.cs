using Selling_Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels.Home
{
    public class ProductDetailViewModel
    {
        public int ProductId { get; set; }


        public string Name { get; set; }
        public decimal Price { get; set; }
        public string AvatarPatch { get; set; }
     

        public string Processor { get; set; }
        public string Screen { get; set; }
        public string OperatingSystem { get; set; }
        public string RearCamera { get; set; }
        public string FrontCamera { get; set; }
        public string Graphics { get; set; }
        public string Memory { get; set; }
        public string HardDrive { get; set; }
        public string Sim { get; set; }
        public string BatteryCapacity { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName{ get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
