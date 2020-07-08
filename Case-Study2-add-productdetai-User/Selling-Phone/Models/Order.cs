using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class Order
    {   
        [Required]
        public int OrderId { set; get; }
        public DateTime OrderDate { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public int TotalProduct { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
