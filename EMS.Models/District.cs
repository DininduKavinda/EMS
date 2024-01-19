using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProvinceId { get; set; }
        [Required]
        public string? NameEn { get; set; }
        [Required]
        public string? NameSi { get; set; }
        [Required]
        public string? NameTa { get; set; }

        [ForeignKey("ProvinceId")]
        public Province? Province { get; set; }
    }
}
