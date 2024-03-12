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
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Vehicle Name")]
        public string? VehicleName { get; set; }
        [Required]
        [DisplayName("Vehicle Number")]
        public string? VehicleNumber { get; set; }
        [Required]
        [DisplayName("Vehicle Type")]
        public int? VehicleType_Id { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; } = 0;
        [ForeignKey("VehicleType_Id")]
        public VehicleType? VehicleType { get; set; }
    }
}
