using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string City { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
       
        [DataType(DataType.DateTime)]
        [Display(Name = "Day of birthday")]
        public DateTime DOB { get; set; }

    }
}
