using EMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalaryType> SalaryTypes { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Attendance> Attendances {  get; set; }
        public DbSet<Leave> Leaves {  get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<PayRoll> PayRolls { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Emp_full_name = "Jeanie Norrie",
                Emp_Cid = "509280",
                Emp_job_title_id = 7,
                Emp_Department_id = 2,
                Emp_DateOfBirth = new DateTime(1972, 9, 22),
                Emp_NIC = 654654646,
                Emp_Address = "20403 Bunker Hill Lane",
                Emp_Gender_id = 2,
                Emp_start_date = new DateTime(2022, 1, 25),
                Emp_dp = "Crimson",
                Emp_contact_info = "190-481-6403",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 2,
                Emp_full_name = "Arabele Millwater",
                Emp_Cid = "583367",
                Emp_job_title_id = 7,
                Emp_Department_id = 5,
                Emp_DateOfBirth = new DateTime(1973, 9, 9),
                Emp_NIC = 654654646,
                Emp_Address = "05080 Village Place",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2016, 10, 3),
                Emp_dp = "Red",
                Emp_contact_info = "231-972-7579",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 3,
                Emp_full_name = "Karen Solomon",
                Emp_Cid = "751033",
                Emp_job_title_id = 1,
                Emp_Department_id = 3,
                Emp_DateOfBirth = new DateTime(1971, 4, 25),
                Emp_NIC = 654654646,
                Emp_Address = "81 Carioca Lane",
                Emp_Gender_id = 2,
                Emp_start_date = new DateTime(2012, 9, 24),
                Emp_dp = "Mauv",
                Emp_contact_info = "299-264-5583",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 4,
                Emp_full_name = "Seamus Yeoman",
                Emp_Cid = "239178",
                Emp_job_title_id = 6,
                Emp_Department_id = 4,
                Emp_DateOfBirth = new DateTime(1966, 10, 11),
                Emp_NIC = 654654646,
                Emp_Address = "94 Towne Avenue",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2012, 10, 14),
                Emp_dp = "Blue",
                Emp_contact_info = "496-189-7339",
                Emp_Is_active = 2
            },
            new Employee
            {
                Id = 5,
                Emp_full_name = "Vincenty Frankcombe",
                Emp_Cid = "663442",
                Emp_job_title_id = 10,
                Emp_Department_id = 3,
                Emp_DateOfBirth = new DateTime(1988, 8, 12),
                Emp_NIC = 654654646,
                Emp_Address = "59664 Gina Crossing",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2021, 9, 2),
                Emp_dp = "Goldenrod",
                Emp_contact_info = "260-523-1239",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 6,
                Emp_full_name = "Tybalt Alldridge",
                Emp_Cid = "723826",
                Emp_job_title_id = 8,
                Emp_Department_id = 3,
                Emp_DateOfBirth = new DateTime(1992, 9, 30),
                Emp_NIC = 654654646,
                Emp_Address = "9979 Vernon Street",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2013, 7, 15),
                Emp_dp = "Fuscia",
                Emp_contact_info = "773-437-6039",
                Emp_Is_active = 2
            },
            new Employee
            {
                Id = 7,
                Emp_full_name = "Amye Adcock",
                Emp_Cid = "332886",
                Emp_job_title_id = 4,
                Emp_Department_id = 4,
                Emp_DateOfBirth = new DateTime(1971, 5, 13),
                Emp_NIC = 654654646,
                Emp_Address = "0 7th Place",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2017, 9, 15),
                Emp_dp = "Puce",
                Emp_contact_info = "250-398-3300",
                Emp_Is_active = 2
            },
            new Employee
            {
                Id = 8,
                Emp_full_name = "Frasier Shrigley",
                Emp_Cid = "681434",
                Emp_job_title_id = 2,
                Emp_Department_id = 1,
                Emp_DateOfBirth = new DateTime(1988, 11, 1),
                Emp_NIC = 654654646,
                Emp_Address = "92 Pawling Alley",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2021, 1, 14),
                Emp_dp = "Aquamarine",
                Emp_contact_info = "752-372-2010",
                Emp_Is_active = 2
            },
            new Employee
            {
                Id = 9,
                Emp_full_name = "Magda Spraberry",
                Emp_Cid = "857369",
                Emp_job_title_id = 4,
                Emp_Department_id = 4,
                Emp_DateOfBirth = new DateTime(1983, 12, 24),
                Emp_NIC = 654654646,
                Emp_Address = "63 Manley Terrace",
                Emp_Gender_id = 2,
                Emp_start_date = new DateTime(2021, 5, 13),
                Emp_dp = "Red",
                Emp_contact_info = "512-765-9897",
                Emp_Is_active = 2
            },
            new Employee
            {
                Id = 10,
                Emp_full_name = "Maressa Gheorghe",
                Emp_Cid = "637020",
                Emp_job_title_id = 10,
                Emp_Department_id = 2,
                Emp_DateOfBirth = new DateTime(1961, 1, 31),
                Emp_NIC = 654654646,
                Emp_Address = "9 Caliangt Pass",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2019, 12, 25),
                Emp_dp = "Purple",
                Emp_contact_info = "426-464-2982",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 11,
                Emp_full_name = "Bambie Selbie",
                Emp_Cid = "685841",
                Emp_job_title_id = 6,
                Emp_Department_id = 2,
                Emp_DateOfBirth = new DateTime(1967, 12, 1),
                Emp_NIC = 654654646,
                Emp_Address = "114 Bonner Center",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2017, 2, 6),
                Emp_dp = "Fuscia",
                Emp_contact_info = "100-113-6495",
                Emp_Is_active = 2
            },
            new Employee
            {
                Id = 12,
                Emp_full_name = "Darwin Callington",
                Emp_Cid = "728440",
                Emp_job_title_id = 8,
                Emp_Department_id = 2,
                Emp_DateOfBirth = new DateTime(1965, 9, 17),
                Emp_NIC = 654654646,
                Emp_Address = "0658 Artisan Drive",
                Emp_Gender_id = 2,
                Emp_start_date = new DateTime(2021, 12, 22),
                Emp_dp = "Aquamarine",
                Emp_contact_info = "850-277-8474",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 13,
                Emp_full_name = "Basilio Longhi",
                Emp_Cid = "672909",
                Emp_job_title_id = 8,
                Emp_Department_id = 3,
                Emp_DateOfBirth = new DateTime(1998, 9, 14),
                Emp_NIC = 654654646,
                Emp_Address = "2305 Stuart Drive",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2021, 4, 9),
                Emp_dp = "Yellow",
                Emp_contact_info = "255-334-1273",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 14,
                Emp_full_name = "Hewet Sorrell",
                Emp_Cid = "275978",
                Emp_job_title_id = 1,
                Emp_Department_id = 3,
                Emp_DateOfBirth = new DateTime(1983, 7, 19),
                Emp_NIC = 654654646,
                Emp_Address = "574 Gulseth Crossing",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2016, 12, 29),
                Emp_dp = "Violet",
                Emp_contact_info = "157-963-7726",
                Emp_Is_active = 1
            },
            new Employee
            {
                Id = 15,
                Emp_full_name = "Dorothea Cantera",
                Emp_Cid = "466923",
                Emp_job_title_id = 9,
                Emp_Department_id = 1,
                Emp_DateOfBirth = new DateTime(1964, 12, 1),
                Emp_NIC = 654654646,
                Emp_Address = "06 Mayfield Junction",
                Emp_Gender_id = 1,
                Emp_start_date = new DateTime(2015, 4, 3),
                Emp_dp = "Violet",
                Emp_contact_info = "831-374-8100",
                Emp_Is_active = 1
            });

            modelBuilder.Entity<SalaryType>().HasData(
            new SalaryType
            {
                Id = 1,
                st_name = "Daily"
            },
            new SalaryType
            {
                Id = 2,
                st_name = "Monthly"
            });
            modelBuilder.Entity<Gender>().HasData(
            new Gender
            {
                Id = 1,
                GenderName = "Male"
            },
            new Gender
            {
                Id = 2,
                GenderName = "Female"
            });
            modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, Department_Name = "Legal" },
            new Department { Id = 2, Department_Name = "Human Resources" },
            new Department { Id = 3, Department_Name = "Training" },
            new Department { Id = 4, Department_Name = "Accounting" },
            new Department { Id = 5, Department_Name = "Sales" },
            new Department { Id = 6, Department_Name = "Engineering" },
            new Department { Id = 7, Department_Name = "Legal" },
            new Department { Id = 8, Department_Name = "Sales" },
            new Department { Id = 9, Department_Name = "Human Resources" },
            new Department { Id = 10, Department_Name = "Research and Development" }
            );

            modelBuilder.Entity<LeaveType>().HasData(
            new LeaveType
            {
                Id = 1,
                Leave_Type_Name = "Sick Leave"
            },
               new LeaveType
               {
                Id = 2,
                   Leave_Type_Name = "Personal Leave"
            },
               new LeaveType
               {
                Id = 4,
                   Leave_Type_Name = "Other Leave"
            },
             new LeaveType
             {
                Id = 3,
                 Leave_Type_Name = "Vacation Leave"
            });
            modelBuilder.Entity<JobTitle>().HasData(
            new JobTitle
            {
                Id = 1,
                jt_name = "Job Title 1",
                BaseSalary = 1500.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 2,
                jt_name = "Job Title 2",
                BaseSalary = 55000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 55000.00m * 0.08m,
                EmpoyeerEPF = 55000.00m * 0.12m,
                EmpoyeerETF = 55000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 3,
                jt_name = "Job Title 3",
                BaseSalary = 1600.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 4,
                jt_name = "Job Title 4",
                BaseSalary = 65000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 65000.00m * 0.08m,
                EmpoyeerEPF = 65000.00m * 0.12m,
                EmpoyeerETF = 65000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 5,
                jt_name = "Job Title 5",
                BaseSalary = 1700.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF =   0
            },
            new JobTitle
            {
                Id = 6,
                jt_name = "Job Title 6",
                BaseSalary = 75000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 75000.00m * 0.08m,
                EmpoyeerEPF = 75000.00m * 0.12m,
                EmpoyeerETF = 75000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 7,
                jt_name = "Job Title 7",
                BaseSalary = 1800.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 8,
                jt_name = "Job Title 8",
                BaseSalary = 85000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 85000.00m * 0.08m,
                EmpoyeerEPF = 85000.00m * 0.12m,
                EmpoyeerETF = 85000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 9,
                jt_name = "Job Title 9",
                BaseSalary = 2900.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF =   0
            },
            new JobTitle
            {
                Id = 10,
                jt_name = "Job Title 10",
                BaseSalary = 95000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 95000.00m * 0.08m,
                EmpoyeerEPF = 95000.00m * 0.12m,
                EmpoyeerETF = 95000.00m * 0.03m
            }
        );
        }
    }
}
