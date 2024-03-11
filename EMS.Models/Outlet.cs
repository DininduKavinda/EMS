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
    public class Outlet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Outlet Name")]
        public string? Outlet_Name { get; set; }
        [Required]
        [DisplayName("Outlet Address")]
        public string? Outlet_Address { get; set; }
        [Required]
        [DisplayName("Contact Number")]
        public string? Contact_number { get; set; }
        [Required]
        [DisplayName("Email")]
        public string? Email { get; set; }
        [Required]
        [DisplayName("Opening Hours")]
        public string? OpeningHours { get; set; }
    }
}
