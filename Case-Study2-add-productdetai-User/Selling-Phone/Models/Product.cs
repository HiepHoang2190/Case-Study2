using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Must enter full name")]
        [StringLength(60, ErrorMessage = "Can not exceed 60 characters")]
        public string Name { get; set; }
     
        [Required]
        public decimal Price { get; set; }
        public string AvatarPatch { get; set; }
        [Required]
        
        public string Processor { get; set; }
        public string  Screen { get; set; }
        public string OperatingSystem { get; set; }
        public string RearCamera { get; set; }
        public string FrontCamera { get; set; }
        public string Graphics { get; set; }
        public string Memory { get; set; }
        public string HardDrive { get; set; }
        public string Sim { get; set; }
        public string BatteryCapacity { get; set; }
        public string ProductDescription { get; set; }
        public string Promotion { get; set; }
        public decimal OldPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
