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
    public class Leave
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public int Employees_Id { get; set; }
        [Required]
        [DisplayName("Leave Applying Date")]
        public DateTime? Leave_Apply_Date { get; set; }
        [Required]
        [DisplayName("Leave Type")]
        public int Leave_Type_Id { get; set; }
        [Required]
        [DisplayName("Leave Description")]
        public string? Leave_Description { get; set; }
        [Required]
        [DisplayName("Acommencement Date")]
        public DateTime? Leave_Acommencement_Date { get; set; }
        [Required]
        [DisplayName("Return Date")]
        public DateTime? Leave_Return_Date { get; set; }
        public int Number_of_Days { get; set; }
        public int Leave_Approved_by { get; set; }
        public DateTime? Leave_Approved_Date { get; set; }
        [ForeignKey("Employees_Id")]
        public Employee? Employee { get; set; }
        [ForeignKey("Leave_Type_Id")]
        public LeaveType? LeaveType { get; set; }
    }  
}
