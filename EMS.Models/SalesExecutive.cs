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
    public class SalesExecutive
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        [DisplayName("Sales Executive")]
        public int EmployeeId { get; set; }
        [Required]
        [DisplayName("Route")]
        public string? Sale_Exe_Route {  get; set; }
        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }
    }
}
