using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels
{
    public class EditUserViewModel
    {  
        public string UserId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
       
        public string City { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string RoleId { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Day of birthday")]
        public DateTime DOB { get; set; }
    }
}
