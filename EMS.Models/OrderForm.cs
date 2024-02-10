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
    public class OrderForm
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Order Status")]
        public int StatusId { get; set; }
        [Required]
        [DisplayName("Order Form No")]
        public int OrderForm_No { get; set; }
        [Required]
        [DisplayName("Customer Name")]
        public int CustomerId { get; set; }
        [Required]
        [DisplayName("Sales Executive")]
        public int SalesExecutiveId { get; set; }
        [Required]
        [DisplayName("Sub Route")]
        public string? SubRoute { get; set; }
        [Required]
        [DisplayName("Road")]
        public string? Road { get; set; }
        [Required]
        [DisplayName("Order Form Date")]
        public DateTime OrderForm_Date { get; set; }
        [Required]
        [DisplayName("Required Date")]
        public DateTime OrderRequired_Date { get; set; }
        [Required]
        [DisplayName("Entered Date")]
        public DateTime OrderForm_EnteredDate { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        [ForeignKey("SalesExecutiveId")]
        public SalesExecutive? SalesExecutive { get; set; }
        [ForeignKey("StatusId")]
        public Status? Status { get; set; }
    }
}
