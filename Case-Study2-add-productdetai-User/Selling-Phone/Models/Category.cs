using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
