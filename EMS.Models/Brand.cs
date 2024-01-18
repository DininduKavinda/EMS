using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Brand Name")]
        public string? Brand_Name { get; set; }
    }
}
