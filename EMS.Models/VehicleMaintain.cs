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
    public class VehicleMaintain
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Vehicle Name")]
        public int VehicleId { get; set; }
        [Required]
        [DisplayName("Maintain Reason")]
        public string? Maintain_Reason { get; set; }
        [Required]
        [DisplayName("Maintain Date")]
        public DateTime Maintain_Date { get; set; }
        [Required]
        [DisplayName("Maintain Cost")]
        public int Maintain_Cost { get; set; }
        [Required]
        [DisplayName("Maintain Details")]
        public string? Maintain_Details { get; set; }
        [Required]
        [DisplayName("Maintain Status")]
        public string? Maintain_Status { get; set; }
        [Required]
        [DisplayName("Maintain By")]
        public string? Maintain_By { get; set; }
        [Required]
        public string? MaintainImage { get; set; }
        [ForeignKey("VehicleId")]
        public Vehicle? Vehicle { get; set; }
    }
}
