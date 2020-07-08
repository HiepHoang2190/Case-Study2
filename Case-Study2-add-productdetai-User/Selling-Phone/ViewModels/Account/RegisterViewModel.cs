﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels
{
    public class RegisterViewModel
    {   
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Confirm password not match")]
        public string ConfirmPassword { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Day of birthday")]
        public DateTime DOB { get; set; }
    }
}
