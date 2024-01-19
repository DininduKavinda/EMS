using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public string? NameEn { get; set; }
        [ForeignKey("DistrictId")]
        public District? District { get; set; }
    }
}
