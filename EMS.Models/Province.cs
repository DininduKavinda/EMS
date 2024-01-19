using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Province
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? NameEn { get; set; }
        [Required]
        public string? NameSi { get; set; }
        [Required]
        public string? NameTa { get; set; }
    }
}
