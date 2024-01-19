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
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Shop Name")]
        public string? Customer_Shop_Name { get; set; }
        [Required]
        [DisplayName("Customer Name")]
        public string? Customer_Name { get; set; }
        [Required]
        [DisplayName("Address")]
        public string? Customer_Address { get; set; }
        [Required]
        [DisplayName("Contact No")]
        public string? Customer_Contact_No { get; set; }
        [Required]
        [DisplayName("City")]
        public int Customer_CityId { get; set; }
        [Required]
        [DisplayName("Road")]
        public string? Customer_Road { get; set; }
        [ForeignKey("Customer_CityId")]
        public City? City { get; set; }
    }
}
