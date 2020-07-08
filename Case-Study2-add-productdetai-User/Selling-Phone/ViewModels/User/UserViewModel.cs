using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels
{
    public class UserViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string RolesName { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Day of birthday")]
        public DateTime DOB { get; set; }
    }
}
