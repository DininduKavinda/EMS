using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class ApplicationUser:IdentityUser
    {
        [DisplayName("Employee Name")]
        public int User_Employee_Id { get; set; }
        [ForeignKey("User_Employee_Id")]
        public Employee? Employee { get; set; }
    }
}
