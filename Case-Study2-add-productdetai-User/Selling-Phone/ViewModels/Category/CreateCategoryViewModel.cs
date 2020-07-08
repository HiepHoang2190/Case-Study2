using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.ViewModels.Category
{
    public class CreateCategoryViewModel
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
