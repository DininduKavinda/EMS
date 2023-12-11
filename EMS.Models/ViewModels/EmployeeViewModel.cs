using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        [ValidateNever]
        public PayRoll PayRoll { get; set; }
        [ValidateNever]
        public List<Attendance> Attendance { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> JobTitleList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DepartmentList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GenderList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> SalaryTypeList { get; set; }
    }
} 
