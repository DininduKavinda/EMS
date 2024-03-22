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
    public class VehicleService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Vehicle")]
        public int VehicleId { get; set; }
        [Required]
        [DisplayName("Next Service Date")]
        public DateTime Next_Service_Date { get; set; }
        [Required]
        [DisplayName("Last Service Cost")]
        public DateTime Last_Service_Date { get; set; }
        [Required]
        [DisplayName("Service Cost")]
        public int Service_Cost { get; set; }
        [DisplayName("Serviced By")]
        public string? Service_By { get; set; }
        public string? ServiceImage { get; set; }
        [ForeignKey("VehicleId")]
        public Vehicle? Vehicle { get; set; }
    }
}
