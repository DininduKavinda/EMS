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
    public class WhereHouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product")]
        public int ProductId { get; set; }
        [Required]
        [DisplayName("Physical Stock")]
        public int Physical_Stock { get; set; }
        [DisplayName("Receive Stock")]
        public int Receive_stock { get; set;}
        [DisplayName("Depatch Stock")]
        public int Depatch_Stock { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
