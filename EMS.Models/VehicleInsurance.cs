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
    public class VehicleInsurance
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Vehicle")]
        public int VehicleId { get; set; }
        [Required]
        [DisplayName("Last Insurance Date")]
        public DateTime Last_Insurance_Date { get; set; }
        [Required]
        [DisplayName("Next Insurance Date")]
        public DateTime Next_Insurance_Date { get; set; }
        [Required]
        [DisplayName("Insurance Cost")]
        public int Insurance_Cost { get; set; }
        public string? InsuranceImage { get; set; }
        [ForeignKey("VehicleId")]
        public Vehicle? Vehicle { get; set; }
    }
}
