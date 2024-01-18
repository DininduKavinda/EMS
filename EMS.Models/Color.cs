using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Color Name")]
        public string? Color_Name { get; set; }
        [DisplayName("Color Code")]
        public string? Color_Code { get; set; }
    }
}
