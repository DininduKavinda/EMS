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
    public class VehicleLicense
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Vehicle")]
        public int VehicleId { get; set; }
        [Required]
        [DisplayName("Last License Date")]
        public DateTime Last_License_Date { get; set; }
        [Required]
        [DisplayName("Next License Date")]
        public DateTime Next_License_Date { get; set; }
        [Required]
        [DisplayName("License Cost")]
        public int License_Cost { get; set; } 
        public string? LisenceImage { get; set; }
        [ForeignKey("VehicleId")]
        public Vehicle? Vehicle { get; set; }
    }
}
