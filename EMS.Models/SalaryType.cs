using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class SalaryType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Salary Type")]
        public string? st_name { get; set; }
    }
}
