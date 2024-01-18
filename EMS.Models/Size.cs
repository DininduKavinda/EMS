using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Size
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Size Name")]
        public string? Size_Name { get; set; }
    }
}
