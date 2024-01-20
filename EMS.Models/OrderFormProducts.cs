using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class OrderFormProducts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Order Form No")]
        public int OrderForm_Id { get; set; }
        [Required]
        [DisplayName("Product")]
        public int ProductId { get; set; }
        [Required]
        [DisplayName("Required Quantity")]
        public int Required_Quantity { get; set; }
    }
}
