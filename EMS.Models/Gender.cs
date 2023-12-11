using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Gender Name")]
        public string? GenderName { get; set; }
    }
}
