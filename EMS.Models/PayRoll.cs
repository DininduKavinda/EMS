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
    public class PayRoll
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public int EmployeeID { get; set; }
        [Required]
        public DateTime? PraperedDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Allowances { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Advanced { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NetBasicSalary { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NetSalary { get; set; }
        [Required]
        public int WorkDays { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime? PayedDate { get; set; }
        [ValidateNever]
        [ForeignKey("EmployeeID")]
        public Employee? Employee { get; set; }
    }
}
