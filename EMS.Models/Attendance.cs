using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public int attendance_e_id {  get; set; }
        [Required]
        [DisplayName("In Image")]
        public string? attendance_in_image { get; set; }
        [DisplayName("Out Image")]
        public string? attendance_out_image { get; set; }
        [DisplayName("Date")]
        public DateTime attendance_date { get; set; }
        [DisplayName("In Time")]
        public DateTime attendance_in_time { get; set; }
        [DisplayName("Out Time")]
        public DateTime attendance_out_time { get; set; }
        [ForeignKey("attendance_e_id")]
        public Employee? Employee { get; set; }
    }
}
