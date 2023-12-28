using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string? Emp_full_name { get; set; }
        [DisplayName("Company Id")]
        public string? Emp_Cid { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public int Emp_job_title_id { get; set; }
        [Required]
        [DisplayName("Department")]
        public int Emp_Department_id { get; set; }
        [DisplayName("Email")]
        public string? Emp_Email { get; set; }
        [DisplayName("NIC")]
        public int Emp_NIC { get; set; }
        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime Emp_DateOfBirth { get; set; }
        [Required]
        [DisplayName("Address")]
        public string? Emp_Address { get; set; }
        [Required]
        [DisplayName("Gender")]
        public int Emp_Gender_id { get; set; }
        [DisplayName("Employment Start Date")]
        public DateTime Emp_start_date { get; set; }
        [DisplayName("Display Picture")]
        public string? Emp_dp { get; set; }
        [DisplayName("Contact Information")]
        public string? Emp_contact_info { get; set; }
        [DisplayName("Active")]
        public int Emp_Is_active { get; set; }
        [ForeignKey("Emp_job_title_id")]
        public JobTitle? JobTitle { get; set; }
        [ForeignKey("Emp_Gender_id")]
        public Gender? Gender { get; set; }
        [ForeignKey("Emp_Department_id")]
        public Department? Department { get; set; }
    }
}
