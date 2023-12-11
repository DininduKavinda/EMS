using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Leave Type")]
        public string? Leave_Type_Name { get; set; }
    }
}
