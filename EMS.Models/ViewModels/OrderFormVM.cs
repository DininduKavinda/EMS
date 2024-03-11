using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models.ViewModels
{
    public class OrderFormVM
    {
        public OrderForm OrderForm { get; set; }
        [ValidateNever]
        public OrderFormProduct OrderFormProducts { get; set; }
        [ValidateNever]
        public List<OrderFormProduct> OrderFormProduct { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CustomerList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> SalesExecutiveList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> StatusList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ProductList { get; set; }
        [ValidateNever]
        public List<OrderFormProduct> OrderFormProductList { get; set; }
    }
}
