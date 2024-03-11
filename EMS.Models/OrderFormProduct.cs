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
    public class OrderFormProduct
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
        [Required]
        [DisplayName("Check")]
        public bool Check {  get; set; }
        [Required]
        [DisplayName("Send Quantity")]
        public int Send_Quantity { get; set; }
        [ForeignKey("OrderForm_Id")]
        public OrderForm? OrderForm { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set;  }
    }
}
