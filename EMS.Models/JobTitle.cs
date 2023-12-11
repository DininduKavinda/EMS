using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    public class JobTitle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Job TItle")]
        public string? jt_name { get; set; }
        [Required]
        [DisplayName("Basic Salary")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BaseSalary { get; set; }
        [Required]
        [DisplayName("Salary Type")]
        public int SalaryTypeID { get; set; }
        [Required]
        [DisplayName("Employee EPF")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal EmpoyeeEPF { get; set; }
        [Required]
        [DisplayName("Employer EPF")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal EmpoyeerEPF { get; set; }
        [Required]
        [DisplayName("Employer ETF")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal EmpoyeerETF { get; set; }
        [ForeignKey("SalaryTypeID")]
        public SalaryType? SalaryType { get; set; }
    }
}
