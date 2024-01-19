using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models.ViewModels
{
    public class ProductVM
    {
        public Product? Product { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> BrandList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ColorList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> SizeList { get; set; }
    }
}
