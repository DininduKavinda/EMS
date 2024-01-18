using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Brand")]
        public int BrandId { get; set; }
        [Required]
        [DisplayName("Color")]
        public int ColorId { get; set; }
        [Required]
        [DisplayName("Size")]
        public int SizeId { get; set; }
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
        [ForeignKey("ColorId")]
        public Color? Color { get; set; }
        [ForeignKey("SizeId")]
        public Size? Size { get; set; }
    }
}
