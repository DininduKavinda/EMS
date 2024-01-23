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
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<WhereHouse> WhereHouses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesExecutive> SalesExecutives { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderForm> OrderForms { get; set; }
        public DbSet<OrderFormProduct> OrderFormProducts {  get; set; }
        public DbSet<Status> Statuses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Salary And Attendance
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Emp_full_name = "Jeanie Norrie",
                Emp_Email ="admin@gmail.com",
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
            new Department { Id = 7, Department_Name = "Shop" },
            new Department { Id = 8, Department_Name = "Loading" },
            new Department { Id = 9, Department_Name = "Distribution" },
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
                jt_name = "Software Engineer",
                BaseSalary = 1500.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 2,
                jt_name = "Chief Accountant",
                BaseSalary = 55000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 55000.00m * 0.08m,
                EmpoyeerEPF = 55000.00m * 0.12m,
                EmpoyeerETF = 55000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 3,
                jt_name = "Accountant",
                BaseSalary = 1600.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 4,
                jt_name = "Account Assistant",
                BaseSalary = 65000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 65000.00m * 0.08m,
                EmpoyeerEPF = 65000.00m * 0.12m,
                EmpoyeerETF = 65000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 5,
                jt_name = "Sales Executive",
                BaseSalary = 1700.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 6,
                jt_name = "Area Sales Manager",
                BaseSalary = 75000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 75000.00m * 0.08m,
                EmpoyeerEPF = 75000.00m * 0.12m,
                EmpoyeerETF = 75000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 7,
                jt_name = "Traninee Accountant",
                BaseSalary = 1800.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 8,
                jt_name = "Light Vehicle Driver",
                BaseSalary = 85000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 85000.00m * 0.08m,
                EmpoyeerEPF = 85000.00m * 0.12m,
                EmpoyeerETF = 85000.00m * 0.03m
            },
            new JobTitle
            {
                Id = 9,
                jt_name = "Heavy Vehicle Driver",
                BaseSalary = 2900.00m,
                SalaryTypeID = 1,
                EmpoyeeEPF = 0,
                EmpoyeerEPF = 0,
                EmpoyeerETF = 0
            },
            new JobTitle
            {
                Id = 10,
                jt_name = "Administrative",
                BaseSalary = 95000.00m,
                SalaryTypeID = 2,
                EmpoyeeEPF = 95000.00m * 0.08m,
                EmpoyeerEPF = 95000.00m * 0.12m,
                EmpoyeerETF = 95000.00m * 0.03m
            });
            modelBuilder.Entity<Color>().HasData(
            new Color 
            {
                Id = 1,
                Color_Name = "Red",
                Color_Code = "#FF0000"
            },
            new Color
            {
                Id = 2,
                Color_Name = "Yellow",
                Color_Code = "#FFFF00"
            },
            new Color
            {
                Id = 3,
                Color_Name = "Green",
                Color_Code = "#00FF00"
            },
            new Color { Id = 4, Color_Name = "Blue", Color_Code = "#0000FF" },
            new Color { Id = 5, Color_Name = "Orange", Color_Code = "#FFA500" },
            new Color { Id = 6, Color_Name = "Pink", Color_Code = "#FFC0CB" },
            new Color { Id = 7, Color_Name = "Brown", Color_Code = "#A52A2A" },
            new Color { Id = 8, Color_Name = "Cyan", Color_Code = "#00FFFF" },
            new Color { Id = 9, Color_Name = "Magenta", Color_Code = "#FF00FF" },
            new Color { Id = 10, Color_Name = "Lime", Color_Code = "#00FF00" },
            new Color { Id = 11, Color_Name = "Teal", Color_Code = "#008080" },
            new Color { Id = 12, Color_Name = "Indigo", Color_Code = "#4B0082" },
            new Color { Id = 13, Color_Name = "Violet", Color_Code = "#EE82EE" },
            new Color { Id = 14, Color_Name = "Maroon", Color_Code = "#800000" },
            new Color { Id = 15, Color_Name = "Gold", Color_Code = "#FFD700" },
            new Color { Id = 16, Color_Name = "Silver", Color_Code = "#C0C0C0" },
            new Color { Id = 17, Color_Name = "Navy", Color_Code = "#000080" },
            new Color { Id = 18, Color_Name = "Turquoise", Color_Code = "#40E0D0" },
            new Color { Id = 19, Color_Name = "Olive", Color_Code = "#808000" },
            new Color { Id = 20, Color_Name = "Peach", Color_Code = "#FFE5B4" },
            new Color { Id = 21, Color_Name = "Salmon", Color_Code = "#FA8072" },
            new Color { Id = 22, Color_Name = "Tomato", Color_Code = "#FF6347" },
            new Color { Id = 23, Color_Name = "Plum", Color_Code = "#DDA0DD" },
            new Color { Id = 24, Color_Name = "Khaki", Color_Code = "#F0E68C" }

        );
            modelBuilder.Entity<Size>().HasData(
            new Size
            {
                Id = 1,
                Size_Name = "500ML"
            },
            new Size
            {
                Id = 2,
                Size_Name = "1L"
            },
            new Size
            {
                Id = 3,
                Size_Name = "4L"
            },
            new Size
            {
                Id = 4,
                Size_Name = "10L"
            },
            new Size
            {
                Id = 5,
                Size_Name = "20L"
            },
            new Size
            {
                Id = 6,
                Size_Name = "20KG"
            }
           );
            modelBuilder.Entity<Brand>().HasData(
            new Brand
            {
                Id = 1,
                Brand_Name = "Aquaseale"
            },
            new Brand
            {
                Id = 2,
                Brand_Name = "Emultion"
            },
            new Brand
            {
                Id = 3,
                Brand_Name = "Tile Motar"
            },
            new Brand
            {
                Id = 4,
                Brand_Name = "Skim Coat"
            }
            );
            for (int i = 1; i <= 30; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        BrandId = (i % 2) + 1,
                        ColorId = (i % 20) + 1,
                        SizeId = (i % 5) + 1 
                    }
                );
            }
            #endregion
            #region NoEntry Or Delete
            modelBuilder.Entity<Province>().HasData(
            new Province { Id = 1, NameEn = "Western", NameSi = "බස්නාහිර", NameTa = "மேல்" },
            new Province { Id = 2, NameEn = "Central", NameSi = "මධ්‍යම", NameTa = "மத்திய" },
            new Province { Id = 3, NameEn = "Southern", NameSi = "දකුණු", NameTa = "தென்" },
            new Province { Id = 4, NameEn = "North Western", NameSi = "වයඹ", NameTa = "வட மேல்" },
            new Province { Id = 5, NameEn = "Sabaragamuwa", NameSi = "සබරගමුව", NameTa = "சபரகமுவ" },
            new Province { Id = 6, NameEn = "Eastern", NameSi = "නැගෙනහිර", NameTa = "கிழக்கு" },
            new Province { Id = 7, NameEn = "Uva", NameSi = "ඌව", NameTa = "ஊவா" },
            new Province { Id = 8, NameEn = "North Central", NameSi = "උතුරු මැද", NameTa = "வட மத்திய" },
            new Province { Id = 9, NameEn = "Northern", NameSi = "උතුරු", NameTa = "வட" }
            );

           modelBuilder.Entity<District>().HasData(
           new District { Id = 1, ProvinceId = 6, NameEn = "Ampara", NameSi = "අම්පාර", NameTa = "அம்பாறை" },
           new District { Id = 2, ProvinceId = 8, NameEn = "Anuradhapura", NameSi = "අනුරාධපුරය", NameTa = "அனுராதபுரம்" },
           new District { Id = 3, ProvinceId = 7, NameEn = "Badulla", NameSi = "බදුල්ල", NameTa = "பதுளை" },
           new District { Id = 4, ProvinceId = 6, NameEn = "Batticaloa", NameSi = "මඩකලපුව", NameTa = "மட்டக்களப்பு" },
           new District { Id = 5, ProvinceId = 1, NameEn = "Colombo", NameSi = "කොළඹ", NameTa = "கொழும்பு" },
           new District { Id = 6, ProvinceId = 3, NameEn = "Galle", NameSi = "ගාල්ල", NameTa = "காலி" },
           new District { Id = 7, ProvinceId = 1, NameEn = "Gampaha", NameSi = "ගම්පහ", NameTa = "கம்பஹா" },
           new District { Id = 8, ProvinceId = 3, NameEn = "Hambantota", NameSi = "හම්බන්තොට", NameTa = "அம்பாந்தோட்டை" },
           new District { Id = 9, ProvinceId = 9, NameEn = "Jaffna", NameSi = "යාපනය", NameTa = "யாழ்ப்பாணம்" },
           new District { Id = 10, ProvinceId = 1, NameEn = "Kalutara", NameSi = "කළුතර", NameTa = "களுத்துறை" },
           new District { Id = 11, ProvinceId = 2, NameEn = "Kandy", NameSi = "මහනුවර", NameTa = "கண்டி" },
           new District { Id = 12, ProvinceId = 5, NameEn = "Kegalle", NameSi = "කෑගල්ල", NameTa = "கேகாலை" },
           new District { Id = 13, ProvinceId = 9, NameEn = "Kilinochchi", NameSi = "කිලිනොච්චිය", NameTa = "கிளிநொச்சி" },
           new District { Id = 14, ProvinceId = 4, NameEn = "Kurunegala", NameSi = "කුරුණෑගල", NameTa = "குருணாகல்" },
           new District { Id = 15, ProvinceId = 9, NameEn = "Mannar", NameSi = "මන්නාරම", NameTa = "மன்னார்" },
           new District { Id = 16, ProvinceId = 2, NameEn = "Matale", NameSi = "මාතලේ", NameTa = "மாத்தளை" },
           new District { Id = 17, ProvinceId = 3, NameEn = "Matara", NameSi = "මාතර", NameTa = "மாத்தறை" },
           new District { Id = 18, ProvinceId = 7, NameEn = "Monaragala", NameSi = "මොණරාගල", NameTa = "மொணராகலை" },
           new District { Id = 19, ProvinceId = 9, NameEn = "Mullaitivu", NameSi = "මුලතිව්", NameTa = "முல்லைத்தீவு" },
           new District { Id = 20, ProvinceId = 2, NameEn = "Nuwara Eliya", NameSi = "නුවර එළිය", NameTa = "நுவரேலியா" },
           new District { Id = 21, ProvinceId = 8, NameEn = "Polonnaruwa", NameSi = "පොළොන්නරුව", NameTa = "பொலன்னறுவை" },
           new District { Id = 22, ProvinceId = 4, NameEn = "Puttalam", NameSi = "පුත්තලම", NameTa = "புத்தளம்" },
           new District { Id = 23, ProvinceId = 5, NameEn = "Ratnapura", NameSi = "රත්නපුර", NameTa = "இரத்தினபுரி" },
           new District { Id = 24, ProvinceId = 6, NameEn = "Trincomalee", NameSi = "ත්‍රිකුණාමලය", NameTa = "திருகோணமலை" },
           new District { Id = 25, ProvinceId = 9, NameEn = "Vavuniya", NameSi = "වව්නියාව", NameTa = "வவுனியா" }
            );
            modelBuilder.Entity<City>().HasData(

             new City
             {
                 Id = 1,
                 DistrictId = 1,
                 NameEn = "Akkaraipattu"
             },
             new City
             {
                 Id = 2,
                 DistrictId = 1,
                 NameEn = "Ambagahawatta"
             },
             new City
             {
                 Id = 3,
                 DistrictId = 1,
                 NameEn = "Ampara"
             },
             new City
             {
                 Id = 4,
                 DistrictId = 1,
                 NameEn = "Bakmitiyawa"
             },
             new City
             {
                 Id = 5,
                 DistrictId = 1,
                 NameEn = "Deegawapiya"
             },
             new City
             {
                 Id = 6,
                 DistrictId = 1,
                 NameEn = "Devalahinda"
             },
             new City
             {
                 Id = 7,
                 DistrictId = 1,
                 NameEn = "Digamadulla Weeragoda"
             },
             new City
             {
                 Id = 8,
                 DistrictId = 1,
                 NameEn = "Dorakumbura"
             },
             new City
             {
                 Id = 9,
                 DistrictId = 1,
                 NameEn = "Gonagolla"
             },
             new City
             {
                 Id = 10,
                 DistrictId = 1,
                 NameEn = "Hulannuge"
             },
             new City
             {
                 Id = 11,
                 DistrictId = 1,
                 NameEn = "Kalmunai"
             },
             new City
             {
                 Id = 12,
                 DistrictId = 1,
                 NameEn = "Kannakipuram"
             },
             new City
             {
                 Id = 13,
                 DistrictId = 1,
                 NameEn = "Karativu"
             },
             new City
             {
                 Id = 14,
                 DistrictId = 1,
                 NameEn = "Kekirihena"
             },
             new City
             {
                 Id = 15,
                 DistrictId = 1,
                 NameEn = "Koknahara"
             },
             new City
             {
                 Id = 16,
                 DistrictId = 1,
                 NameEn = "Kolamanthalawa"
             },
             new City
             {
                 Id = 17,
                 DistrictId = 1,
                 NameEn = "Komari"
             },
             new City
             {
                 Id = 18,
                 DistrictId = 1,
                 NameEn = "Lahugala"
             },
             new City
             {
                 Id = 19,
                 DistrictId = 1,
                 NameEn = "lmkkamam"
             },
             new City
             {
                 Id = 20,
                 DistrictId = 1,
                 NameEn = "Mahaoya"
             },
             new City
             {
                 Id = 21,
                 DistrictId = 1,
                 NameEn = "Marathamune"
             },
             new City
             {
                 Id = 22,
                 DistrictId = 1,
                 NameEn = "Namaloya"
             },
             new City
             {
                 Id = 23,
                 DistrictId = 1,
                 NameEn = "Navithanveli"
             },
             new City
             {
                 Id = 24,
                 DistrictId = 1,
                 NameEn = "Nintavur"
             },
             new City
             {
                 Id = 25,
                 DistrictId = 1,
                 NameEn = "Oluvil"
             },
             new City
             {
                 Id = 26,
                 DistrictId = 1,
                 NameEn = "Padiyatalawa"
             },
             new City
             {
                 Id = 27,
                 DistrictId = 1,
                 NameEn = "Pahalalanda"
             },
             new City
             {
                 Id = 28,
                 DistrictId = 1,
                 NameEn = "Panama"
             },
             new City
             {
                 Id = 29,
                 DistrictId = 1,
                 NameEn = "Pannalagama"
             },
             new City
             {
                 Id = 30,
                 DistrictId = 1,
                 NameEn = "Paragahakele"
             },
             new City
             {
                 Id = 31,
                 DistrictId = 1,
                 NameEn = "Periyaneelavanai"
             },
             new City
             {
                 Id = 32,
                 DistrictId = 1,
                 NameEn = "Polwaga Janapadaya"
             },
             new City
             {
                 Id = 33,
                 DistrictId = 1,
                 NameEn = "Pottuvil"
             },
             new City
             {
                 Id = 34,
                 DistrictId = 1,
                 NameEn = "Sainthamaruthu"
             },
             new City
             {
                 Id = 35,
                 DistrictId = 1,
                 NameEn = "Samanthurai"
             },
             new City
             {
                 Id = 36,
                 DistrictId = 1,
                 NameEn = "Serankada"
             },
             new City
             {
                 Id = 37,
                 DistrictId = 1,
                 NameEn = "Tempitiya"
             },
             new City
             {
                 Id = 38,
                 DistrictId = 1,
                 NameEn = "Thambiluvil"
             },
             new City
             {
                 Id = 39,
                 DistrictId = 1,
                 NameEn = "Tirukovil"
             },
             new City
             {
                 Id = 40,
                 DistrictId = 1,
                 NameEn = "Uhana"
             },
             new City
             {
                 Id = 41,
                 DistrictId = 1,
                 NameEn = "Wadinagala"
             },
             new City
             {
                 Id = 42,
                 DistrictId = 1,
                 NameEn = "Wanagamuwa"
             },
             new City
             {
                 Id = 43,
                 DistrictId = 2,
                 NameEn = "Angamuwa"
             },
             new City
             {
                 Id = 44,
                 DistrictId = 2,
                 NameEn = "Anuradhapura"
             },
             new City
             {
                 Id = 45,
                 DistrictId = 2,
                 NameEn = "Awukana"
             },
             new City
             {
                 Id = 46,
                 DistrictId = 2,
                 NameEn = "Bogahawewa"
             },
             new City
             {
                 Id = 47,
                 DistrictId = 2,
                 NameEn = "Dematawewa"
             },
             new City
             {
                 Id = 48,
                 DistrictId = 2,
                 NameEn = "Dimbulagala"
             },
             new City
             {
                 Id = 49,
                 DistrictId = 2,
                 NameEn = "Dutuwewa"
             },
             new City
             {
                 Id = 50,
                 DistrictId = 2,
                 NameEn = "Elayapattuwa"
             },
             new City
             {
                 Id = 51,
                 DistrictId = 2,
                 NameEn = "Ellewewa"
             },
             new City
             {
                 Id = 52,
                 DistrictId = 2,
                 NameEn = "Eppawala"
             },
             new City
             {
                 Id = 53,
                 DistrictId = 2,
                 NameEn = "Etawatunuwewa"
             },
             new City
             {
                 Id = 54,
                 DistrictId = 2,
                 NameEn = "Etaweeragollewa"
             },
             new City
             {
                 Id = 55,
                 DistrictId = 2,
                 NameEn = "Galapitagala"
             },
             new City
             {
                 Id = 56,
                 DistrictId = 2,
                 NameEn = "Galenbindunuwewa"
             },
             new City
             {
                 Id = 57,
                 DistrictId = 2,
                 NameEn = "Galkadawala"
             },
             new City
             {
                 Id = 58,
                 DistrictId = 2,
                 NameEn = "Galkiriyagama"
             },
             new City
             {
                 Id = 59,
                 DistrictId = 2,
                 NameEn = "Galkulama"
             },
             new City
             {
                 Id = 60,
                 DistrictId = 2,
                 NameEn = "Galnewa"
             },
             new City
             {
                 Id = 61,
                 DistrictId = 2,
                 NameEn = "Gambirigaswewa"
             },
             new City
             {
                 Id = 62,
                 DistrictId = 2,
                 NameEn = "Ganewalpola"
             },
             new City
             {
                 Id = 63,
                 DistrictId = 2,
                 NameEn = "Gemunupura"
             },
             new City
             {
                 Id = 64,
                 DistrictId = 2,
                 NameEn = "Getalawa"
             },
             new City
             {
                 Id = 65,
                 DistrictId = 2,
                 NameEn = "Gnanikulama"
             },
             new City
             {
                 Id = 66,
                 DistrictId = 2,
                 NameEn = "Gonahaddenawa"
             },
             new City
             {
                 Id = 67,
                 DistrictId = 2,
                 NameEn = "Habarana"
             },
             new City
             {
                 Id = 68,
                 DistrictId = 2,
                 NameEn = "Halmillawa Dambulla"
             },
             new City
             {
                 Id = 69,
                 DistrictId = 2,
                 NameEn = "Halmillawetiya"
             },
             new City
             {
                 Id = 70,
                 DistrictId = 2,
                 NameEn = "Hidogama"
             },
             new City
             {
                 Id = 71,
                 DistrictId = 2,
                 NameEn = "Horawpatana"
             },
             new City
             {
                 Id = 72,
                 DistrictId = 2,
                 NameEn = "Horiwila"
             },
             new City
             {
                 Id = 73,
                 DistrictId = 2,
                 NameEn = "Hurigaswewa"
             },
             new City
             {
                 Id = 74,
                 DistrictId = 2,
                 NameEn = "Hurulunikawewa"
             },
             new City
             {
                 Id = 75,
                 DistrictId = 2,
                 NameEn = "Ihala Puliyankulama"
             },
             new City
             {
                 Id = 76,
                 DistrictId = 2,
                 NameEn = "Kagama"
             },
             new City
             {
                 Id = 77,
                 DistrictId = 2,
                 NameEn = "Kahatagasdigiliya"
             },
             new City
             {
                 Id = 78,
                 DistrictId = 2,
                 NameEn = "Kahatagollewa"
             },
             new City
             {
                 Id = 79,
                 DistrictId = 2,
                 NameEn = "Kalakarambewa"
             },
             new City
             {
                 Id = 80,
                 DistrictId = 2,
                 NameEn = "Kalaoya"
             },
             new City
             {
                 Id = 81,
                 DistrictId = 2,
                 NameEn = "Kalawedi Ulpotha"
             },
             new City
             {
                 Id = 82,
                 DistrictId = 2,
                 NameEn = "Kallanchiya"
             },
             new City
             {
                 Id = 83,
                 DistrictId = 2,
                 NameEn = "Kalpitiya"
             },
             new City
             {
                 Id = 84,
                 DistrictId = 2,
                 NameEn = "Kalukele Badanagala"
             },
             new City
             {
                 Id = 85,
                 DistrictId = 2,
                 NameEn = "Kapugallawa"
             },
             new City
             {
                 Id = 86,
                 DistrictId = 2,
                 NameEn = "Karagahawewa"
             },
             new City
             {
                 Id = 87,
                 DistrictId = 2,
                 NameEn = "Kashyapapura"
             },
             new City
             {
                 Id = 88,
                 DistrictId = 2,
                 NameEn = "Kebithigollewa"
             },
             new City
             {
                 Id = 89,
                 DistrictId = 2,
                 NameEn = "Kekirawa"
             },
             new City
             {
                 Id = 90,
                 DistrictId = 2,
                 NameEn = "Kendewa"
             },
             new City
             {
                 Id = 91,
                 DistrictId = 2,
                 NameEn = "Kiralogama"
             },
             new City
             {
                 Id = 92,
                 DistrictId = 2,
                 NameEn = "Kirigalwewa"
             },
             new City
             {
                 Id = 93,
                 DistrictId = 2,
                 NameEn = "Kirimundalama"
             },
             new City
             {
                 Id = 94,
                 DistrictId = 2,
                 NameEn = "Kitulhitiyawa"
             },
             new City
             {
                 Id = 95,
                 DistrictId = 2,
                 NameEn = "Kurundankulama"
             },
             new City
             {
                 Id = 96,
                 DistrictId = 2,
                 NameEn = "Labunoruwa"
             },
             new City
             {
                 Id = 97,
                 DistrictId = 2,
                 NameEn = "Ihalagama"
             },
             new City
             {
                 Id = 98,
                 DistrictId = 2,
                 NameEn = "Ipologama"
             },
             new City
             {
                 Id = 99,
                 DistrictId = 2,
                 NameEn = "Madatugama"
             },
             new City
             {
                 Id = 100,
                 DistrictId = 2,
                 NameEn = "Maha Elagamuwa"
             },
             new City
             {
                 Id = 101,
                 DistrictId = 2,
                 NameEn = "Mahabulankulama"
             },
             new City
             {
                 Id = 102,
                 DistrictId = 2,
                 NameEn = "Mahailluppallama"
             },
             new City
             {
                 Id = 103,
                 DistrictId = 2,
                 NameEn = "Mahakanadarawa"
             },
             new City
             {
                 Id = 104,
                 DistrictId = 2,
                 NameEn = "Mahapothana"
             },
             new City
             {
                 Id = 105,
                 DistrictId = 2,
                 NameEn = "Mahasenpura"
             },
             new City
             {
                 Id = 106,
                 DistrictId = 2,
                 NameEn = "Mahawilachchiya"
             },
             new City
             {
                 Id = 107,
                 DistrictId = 2,
                 NameEn = "Mailagaswewa"
             },
             new City
             {
                 Id = 108,
                 DistrictId = 2,
                 NameEn = "Malwanagama"
             },
             new City
             {
                 Id = 109,
                 DistrictId = 2,
                 NameEn = "Maneruwa"
             },
             new City
             {
                 Id = 110,
                 DistrictId = 2,
                 NameEn = "Maradankadawala"
             },
             new City
             {
                 Id = 111,
                 DistrictId = 2,
                 NameEn = "Maradankalla"
             },
             new City
             {
                 Id = 112,
                 DistrictId = 2,
                 NameEn = "Medawachchiya"
             },
             new City
             {
                 Id = 113,
                 DistrictId = 2,
                 NameEn = "Megodawewa"
             },
             new City
             {
                 Id = 114,
                 DistrictId = 2,
                 NameEn = "Mihintale"
             },
             new City
             {
                 Id = 115,
                 DistrictId = 2,
                 NameEn = "Morakewa"
             },
             new City
             {
                 Id = 116,
                 DistrictId = 2,
                 NameEn = "Mulkiriyawa"
             },
             new City
             {
                 Id = 117,
                 DistrictId = 2,
                 NameEn = "Muriyakadawala"
             },
             new City
             {
                 Id = 118,
                 DistrictId = 5,
                 NameEn = "Colombo 15"
             },
             new City
             {
                 Id = 119,
                 DistrictId = 2,
                 NameEn = "Nachchaduwa"
             },
             new City
             {
                 Id = 120,
                 DistrictId = 2,
                 NameEn = "Namalpura"
             },
             new City
             {
                 Id = 121,
                 DistrictId = 2,
                 NameEn = "Negampaha"
             },
             new City
             {
                 Id = 122,
                 DistrictId = 2,
                 NameEn = "Nochchiyagama"
             },
             new City
             {
                 Id = 123,
                 DistrictId = 2,
                 NameEn = "Nuwaragala"
             },
             new City
             {
                 Id = 124,
                 DistrictId = 2,
                 NameEn = "Padavi Maithripura"
             },
             new City
             {
                 Id = 125,
                 DistrictId = 2,
                 NameEn = "Padavi Parakramapura"
             },
             new City
             {
                 Id = 126,
                 DistrictId = 2,
                 NameEn = "Padavi Sripura"
             },
             new City
             {
                 Id = 127,
                 DistrictId = 2,
                 NameEn = "Padavi Sritissapura"
             },
             new City
             {
                 Id = 128,
                 DistrictId = 2,
                 NameEn = "Padaviya"
             },
             new City
             {
                 Id = 129,
                 DistrictId = 2,
                 NameEn = "Padikaramaduwa"
             },
             new City
             {
                 Id = 130,
                 DistrictId = 2,
                 NameEn = "Pahala Halmillewa"
             },
             new City
             {
                 Id = 131,
                 DistrictId = 2,
                 NameEn = "Pahala Maragahawe"
             },
             new City
             {
                 Id = 132,
                 DistrictId = 2,
                 NameEn = "Pahalagama"
             },
             new City
             {
                 Id = 133,
                 DistrictId = 2,
                 NameEn = "Palugaswewa"
             },
             new City
             {
                 Id = 134,
                 DistrictId = 2,
                 NameEn = "Pandukabayapura"
             },
             new City
             {
                 Id = 135,
                 DistrictId = 2,
                 NameEn = "Pandulagama"
             },
             new City
             {
                 Id = 136,
                 DistrictId = 2,
                 NameEn = "Parakumpura"
             },
             new City
             {
                 Id = 137,
                 DistrictId = 2,
                 NameEn = "Parangiyawadiya"
             },
             new City
             {
                 Id = 138,
                 DistrictId = 2,
                 NameEn = "Parasangahawewa"
             },
             new City
             {
                 Id = 139,
                 DistrictId = 2,
                 NameEn = "Pelatiyawa"
             },
             new City
             {
                 Id = 140,
                 DistrictId = 2,
                 NameEn = "Pemaduwa"
             },
             new City
             {
                 Id = 141,
                 DistrictId = 2,
                 NameEn = "Perimiyankulama"
             },
             new City
             {
                 Id = 142,
                 DistrictId = 2,
                 NameEn = "Pihimbiyagolewa"
             },
             new City
             {
                 Id = 143,
                 DistrictId = 2,
                 NameEn = "Pubbogama"
             },
             new City
             {
                 Id = 144,
                 DistrictId = 2,
                 NameEn = "Punewa"
             },
             new City
             {
                 Id = 145,
                 DistrictId = 2,
                 NameEn = "Rajanganaya"
             },
             new City
             {
                 Id = 146,
                 DistrictId = 2,
                 NameEn = "Rambewa"
             },
             new City
             {
                 Id = 147,
                 DistrictId = 2,
                 NameEn = "Rampathwila"
             },
             new City
             {
                 Id = 148,
                 DistrictId = 2,
                 NameEn = "Rathmalgahawewa"
             },
             new City
             {
                 Id = 149,
                 DistrictId = 2,
                 NameEn = "Saliyapura"
             },
             new City
             {
                 Id = 150,
                 DistrictId = 2,
                 NameEn = "Seeppukulama"
             },
             new City
             {
                 Id = 151,
                 DistrictId = 2,
                 NameEn = "Senapura"
             },
             new City
             {
                 Id = 152,
                 DistrictId = 2,
                 NameEn = "Sivalakulama"
             },
             new City
             {
                 Id = 153,
                 DistrictId = 2,
                 NameEn = "Siyambalewa"
             },
             new City
             {
                 Id = 154,
                 DistrictId = 2,
                 NameEn = "Sravasthipura"
             },
             new City
             {
                 Id = 155,
                 DistrictId = 2,
                 NameEn = "Talawa"
             },
             new City
             {
                 Id = 156,
                 DistrictId = 2,
                 NameEn = "Tambuttegama"
             },
             new City
             {
                 Id = 157,
                 DistrictId = 2,
                 NameEn = "Tammennawa"
             },
             new City
             {
                 Id = 158,
                 DistrictId = 2,
                 NameEn = "Tantirimale"
             },
             new City
             {
                 Id = 159,
                 DistrictId = 2,
                 NameEn = "Telhiriyawa"
             },
             new City
             {
                 Id = 160,
                 DistrictId = 2,
                 NameEn = "Tirappane"
             },
             new City
             {
                 Id = 161,
                 DistrictId = 2,
                 NameEn = "Tittagonewa"
             },
             new City
             {
                 Id = 162,
                 DistrictId = 2,
                 NameEn = "Udunuwara Colony"
             },
             new City
             {
                 Id = 163,
                 DistrictId = 2,
                 NameEn = "Upuldeniya"
             },
             new City
             {
                 Id = 164,
                 DistrictId = 2,
                 NameEn = "Uttimaduwa"
             },
             new City
             {
                 Id = 165,
                 DistrictId = 2,
                 NameEn = "Vellamanal"
             },
             new City
             {
                 Id = 166,
                 DistrictId = 2,
                 NameEn = "Viharapalugama"
             },
             new City
             {
                 Id = 167,
                 DistrictId = 2,
                 NameEn = "Wahalkada"
             },
             new City
             {
                 Id = 168,
                 DistrictId = 2,
                 NameEn = "Wahamalgollewa"
             },
             new City
             {
                 Id = 169,
                 DistrictId = 2,
                 NameEn = "Walagambahuwa"
             },
             new City
             {
                 Id = 170,
                 DistrictId = 2,
                 NameEn = "Walahaviddawewa"
             },
             new City
             {
                 Id = 171,
                 DistrictId = 2,
                 NameEn = "Welimuwapotana"
             },
             new City
             {
                 Id = 172,
                 DistrictId = 2,
                 NameEn = "Welioya Project"
             },
             new City
             {
                 Id = 173,
                 DistrictId = 3,
                 NameEn = "Akkarasiyaya"
             },
             new City
             {
                 Id = 174,
                 DistrictId = 3,
                 NameEn = "Aluketiyawa"
             },
             new City
             {
                 Id = 175,
                 DistrictId = 3,
                 NameEn = "Aluttaramma"
             },
             new City
             {
                 Id = 176,
                 DistrictId = 3,
                 NameEn = "Ambadandegama"
             },
             new City
             {
                 Id = 177,
                 DistrictId = 3,
                 NameEn = "Ambagasdowa"
             },
             new City
             {
                 Id = 178,
                 DistrictId = 3,
                 NameEn = "Arawa"
             },
             new City
             {
                 Id = 179,
                 DistrictId = 3,
                 NameEn = "Arawakumbura"
             },
             new City
             {
                 Id = 180,
                 DistrictId = 3,
                 NameEn = "Arawatta"
             },
             new City
             {
                 Id = 181,
                 DistrictId = 3,
                 NameEn = "Atakiriya"
             },
             new City
             {
                 Id = 182,
                 DistrictId = 3,
                 NameEn = "Badulla"
             },
             new City
             {
                 Id = 183,
                 DistrictId = 3,
                 NameEn = "Baduluoya"
             },
             new City
             {
                 Id = 184,
                 DistrictId = 3,
                 NameEn = "Ballaketuwa"
             },
             new City
             {
                 Id = 185,
                 DistrictId = 3,
                 NameEn = "Bambarapana"
             },
             new City
             {
                 Id = 186,
                 DistrictId = 3,
                 NameEn = "Bandarawela"
             },
             new City
             {
                 Id = 187,
                 DistrictId = 3,
                 NameEn = "Beramada"
             },
             new City
             {
                 Id = 188,
                 DistrictId = 3,
                 NameEn = "Bibilegama"
             },
             new City
             {
                 Id = 189,
                 DistrictId = 3,
                 NameEn = "Boragas"
             },
             new City
             {
                 Id = 190,
                 DistrictId = 3,
                 NameEn = "Boralanda"
             },
             new City
             {
                 Id = 191,
                 DistrictId = 3,
                 NameEn = "Bowela"
             },
             new City
             {
                 Id = 192,
                 DistrictId = 3,
                 NameEn = "Central Camp"
             },
             new City
             {
                 Id = 193,
                 DistrictId = 3,
                 NameEn = "Damanewela"
             },
             new City
             {
                 Id = 194,
                 DistrictId = 3,
                 NameEn = "Dambana"
             },
             new City
             {
                 Id = 195,
                 DistrictId = 3,
                 NameEn = "Dehiattakandiya"
             },
             new City
             {
                 Id = 196,
                 DistrictId = 3,
                 NameEn = "Demodara"
             },
             new City
             {
                 Id = 197,
                 DistrictId = 3,
                 NameEn = "Diganatenna"
             },
             new City
             {
                 Id = 198,
                 DistrictId = 3,
                 NameEn = "Dikkapitiya"
             },
             new City
             {
                 Id = 199,
                 DistrictId = 3,
                 NameEn = "Dimbulana"
             },
             new City
             {
                 Id = 200,
                 DistrictId = 3,
                 NameEn = "Divulapelessa"
             },
             new City
             {
                 Id = 201,
                 DistrictId = 3,
                 NameEn = "Diyatalawa"
             },
             new City
             {
                 Id = 202,
                 DistrictId = 3,
                 NameEn = "Dulgolla"
             },
             new City
             {
                 Id = 203,
                 DistrictId = 3,
                 NameEn = "Ekiriyankumbura"
             },
             new City
             {
                 Id = 204,
                 DistrictId = 3,
                 NameEn = "Ella"
             },
             new City
             {
                 Id = 205,
                 DistrictId = 3,
                 NameEn = "Ettampitiya"
             },
             new City
             {
                 Id = 206,
                 DistrictId = 3,
                 NameEn = "Galauda"
             },
             new City
             {
                 Id = 207,
                 DistrictId = 3,
                 NameEn = "Galporuyaya"
             },
             new City
             {
                 Id = 208,
                 DistrictId = 3,
                 NameEn = "Gawarawela"
             },
             new City
             {
                 Id = 209,
                 DistrictId = 3,
                 NameEn = "Girandurukotte"
             },
             new City
             {
                 Id = 210,
                 DistrictId = 3,
                 NameEn = "Godunna"
             },
             new City
             {
                 Id = 211,
                 DistrictId = 3,
                 NameEn = "Gurutalawa"
             },
             new City
             {
                 Id = 212,
                 DistrictId = 3,
                 NameEn = "Haldummulla"
             },
             new City
             {
                 Id = 213,
                 DistrictId = 3,
                 NameEn = "Hali Ela"
             },
             new City
             {
                 Id = 214,
                 DistrictId = 3,
                 NameEn = "Hangunnawa"
             },
             new City
             {
                 Id = 215,
                 DistrictId = 3,
                 NameEn = "Haputale"
             },
             new City
             {
                 Id = 216,
                 DistrictId = 3,
                 NameEn = "Hebarawa"
             },
             new City
             {
                 Id = 217,
                 DistrictId = 3,
                 NameEn = "Heeloya"
             },
             new City
             {
                 Id = 218,
                 DistrictId = 3,
                 NameEn = "Helahalpe"
             },
             new City
             {
                 Id = 219,
                 DistrictId = 3,
                 NameEn = "Helapupula"
             },
             new City
             {
                 Id = 220,
                 DistrictId = 3,
                 NameEn = "Hopton"
             },
             new City
             {
                 Id = 221,
                 DistrictId = 3,
                 NameEn = "Idalgashinna"
             },
             new City
             {
                 Id = 222,
                 DistrictId = 3,
                 NameEn = "Kahataruppa"
             },
             new City
             {
                 Id = 223,
                 DistrictId = 3,
                 NameEn = "Kalugahakandura"
             },
             new City
             {
                 Id = 224,
                 DistrictId = 3,
                 NameEn = "Kalupahana"
             },
             new City
             {
                 Id = 225,
                 DistrictId = 3,
                 NameEn = "Kebillawela"
             },
             new City
             {
                 Id = 226,
                 DistrictId = 3,
                 NameEn = "Kendagolla"
             },
             new City
             {
                 Id = 227,
                 DistrictId = 3,
                 NameEn = "Keselpotha"
             },
             new City
             {
                 Id = 228,
                 DistrictId = 3,
                 NameEn = "Ketawatta"
             },
             new City
             {
                 Id = 229,
                 DistrictId = 3,
                 NameEn = "Kiriwanagama"
             },
             new City
             {
                 Id = 230,
                 DistrictId = 3,
                 NameEn = "Koslanda"
             },
             new City
             {
                 Id = 231,
                 DistrictId = 3,
                 NameEn = "Kuruwitenna"
             },
             new City
             {
                 Id = 232,
                 DistrictId = 3,
                 NameEn = "Kuttiyagolla"
             },
             new City
             {
                 Id = 233,
                 DistrictId = 3,
                 NameEn = "Landewela"
             },
             new City
             {
                 Id = 234,
                 DistrictId = 3,
                 NameEn = "Liyangahawela"
             },
             new City
             {
                 Id = 235,
                 DistrictId = 3,
                 NameEn = "Lunugala"
             },
             new City
             {
                 Id = 236,
                 DistrictId = 3,
                 NameEn = "Lunuwatta"
             },
             new City
             {
                 Id = 237,
                 DistrictId = 3,
                 NameEn = "Madulsima"
             },
             new City
             {
                 Id = 238,
                 DistrictId = 3,
                 NameEn = "Mahiyanganaya"
             },
             new City
             {
                 Id = 239,
                 DistrictId = 3,
                 NameEn = "Makulella"
             },
             new City
             {
                 Id = 240,
                 DistrictId = 3,
                 NameEn = "Malgoda"
             },
             new City
             {
                 Id = 241,
                 DistrictId = 3,
                 NameEn = "Mapakadawewa"
             },
             new City
             {
                 Id = 242,
                 DistrictId = 3,
                 NameEn = "Maspanna"
             },
             new City
             {
                 Id = 243,
                 DistrictId = 3,
                 NameEn = "Maussagolla"
             },
             new City
             {
                 Id = 244,
                 DistrictId = 3,
                 NameEn = "Mawanagama"
             },
             new City
             {
                 Id = 245,
                 DistrictId = 3,
                 NameEn = "Medawela Udukinda"
             },
             new City
             {
                 Id = 246,
                 DistrictId = 3,
                 NameEn = "Meegahakiula"
             },
             new City
             {
                 Id = 247,
                 DistrictId = 3,
                 NameEn = "Metigahatenna"
             },
             new City
             {
                 Id = 248,
                 DistrictId = 3,
                 NameEn = "Mirahawatta"
             },
             new City
             {
                 Id = 249,
                 DistrictId = 3,
                 NameEn = "Miriyabedda"
             },
             new City
             {
                 Id = 250,
                 DistrictId = 3,
                 NameEn = "Nawamedagama"
             },
             new City
             {
                 Id = 251,
                 DistrictId = 3,
                 NameEn = "Nelumgama"
             },
             new City
             {
                 Id = 252,
                 DistrictId = 3,
                 NameEn = "Nikapotha"
             },
             new City
             {
                 Id = 253,
                 DistrictId = 3,
                 NameEn = "Nugatalawa"
             },
             new City
             {
                 Id = 254,
                 DistrictId = 3,
                 NameEn = "Ohiya"
             },
             new City
             {
                 Id = 255,
                 DistrictId = 3,
                 NameEn = "Pahalarathkinda"
             },
             new City
             {
                 Id = 256,
                 DistrictId = 3,
                 NameEn = "Pallekiruwa"
             },
             new City
             {
                 Id = 257,
                 DistrictId = 3,
                 NameEn = "Passara"
             },
             new City
             {
                 Id = 258,
                 DistrictId = 3,
                 NameEn = "Pattiyagedara"
             },
             new City
             {
                 Id = 259,
                 DistrictId = 3,
                 NameEn = "Pelagahatenna"
             },
             new City
             {
                 Id = 260,
                 DistrictId = 3,
                 NameEn = "Perawella"
             },
             new City
             {
                 Id = 261,
                 DistrictId = 3,
                 NameEn = "Pitamaruwa"
             },
             new City
             {
                 Id = 262,
                 DistrictId = 3,
                 NameEn = "Pitapola"
             },
             new City
             {
                 Id = 263,
                 DistrictId = 3,
                 NameEn = "Puhulpola"
             },
             new City
             {
                 Id = 264,
                 DistrictId = 3,
                 NameEn = "Rajagalatenna"
             },
             new City
             {
                 Id = 265,
                 DistrictId = 3,
                 NameEn = "Ratkarawwa"
             },
             new City
             {
                 Id = 266,
                 DistrictId = 3,
                 NameEn = "Ridimaliyadda"
             },
             new City
             {
                 Id = 267,
                 DistrictId = 3,
                 NameEn = "Silmiyapura"
             },
             new City
             {
                 Id = 268,
                 DistrictId = 3,
                 NameEn = "Sirimalgoda"
             },
             new City
             {
                 Id = 269,
                 DistrictId = 3,
                 NameEn = "Siripura"
             },
             new City
             {
                 Id = 270,
                 DistrictId = 3,
                 NameEn = "Sorabora Colony"
             },
             new City
             {
                 Id = 271,
                 DistrictId = 3,
                 NameEn = "Soragune"
             },
             new City
             {
                 Id = 272,
                 DistrictId = 3,
                 NameEn = "Soranatota"
             },
             new City
             {
                 Id = 273,
                 DistrictId = 3,
                 NameEn = "Taldena"
             },
             new City
             {
                 Id = 274,
                 DistrictId = 3,
                 NameEn = "Timbirigaspitiya"
             },
             new City
             {
                 Id = 275,
                 DistrictId = 3,
                 NameEn = "Uduhawara"
             },
             new City
             {
                 Id = 276,
                 DistrictId = 3,
                 NameEn = "Uraniya"
             },
             new City
             {
                 Id = 277,
                 DistrictId = 3,
                 NameEn = "Uva Karandagolla"
             },
             new City
             {
                 Id = 278,
                 DistrictId = 3,
                 NameEn = "Uva Mawelagama"
             },
             new City
             {
                 Id = 279,
                 DistrictId = 3,
                 NameEn = "Uva Tenna"
             },
             new City
             {
                 Id = 280,
                 DistrictId = 3,
                 NameEn = "Uva Tissapura"
             },
             new City
             {
                 Id = 281,
                 DistrictId = 3,
                 NameEn = "Welimada"
             },
             new City
             {
                 Id = 282,
                 DistrictId = 3,
                 NameEn = "Werunketagoda"
             },
             new City
             {
                 Id = 283,
                 DistrictId = 3,
                 NameEn = "Wewatta"
             },
             new City
             {
                 Id = 284,
                 DistrictId = 3,
                 NameEn = "Wineethagama"
             },
             new City
             {
                 Id = 285,
                 DistrictId = 3,
                 NameEn = "Yalagamuwa"
             },
             new City
             {
                 Id = 286,
                 DistrictId = 3,
                 NameEn = "Yalwela"
             },
             new City
             {
                 Id = 287,
                 DistrictId = 4,
                 NameEn = "Addalaichenai"
             },
             new City
             {
                 Id = 288,
                 DistrictId = 4,
                 NameEn = "Ampilanthurai"
             },
             new City
             {
                 Id = 289,
                 DistrictId = 4,
                 NameEn = "Araipattai"
             },
             new City
             {
                 Id = 290,
                 DistrictId = 4,
                 NameEn = "Ayithiyamalai"
             },
             new City
             {
                 Id = 291,
                 DistrictId = 4,
                 NameEn = "Bakiella"
             },
             new City
             {
                 Id = 292,
                 DistrictId = 4,
                 NameEn = "Batticaloa"
             },
             new City
             {
                 Id = 293,
                 DistrictId = 4,
                 NameEn = "Cheddipalayam"
             },
             new City
             {
                 Id = 294,
                 DistrictId = 4,
                 NameEn = "Chenkaladi"
             },
             new City
             {
                 Id = 295,
                 DistrictId = 4,
                 NameEn = "Eravur"
             },
             new City
             {
                 Id = 296,
                 DistrictId = 4,
                 NameEn = "Kaluwanchikudi"
             },
             new City
             {
                 Id = 297,
                 DistrictId = 4,
                 NameEn = "Kaluwankemy"
             },
             new City
             {
                 Id = 298,
                 DistrictId = 4,
                 NameEn = "Kannankudah"
             },
             new City
             {
                 Id = 299,
                 DistrictId = 4,
                 NameEn = "Karadiyanaru"
             },
             new City
             {
                 Id = 300,
                 DistrictId = 4,
                 NameEn = "Kathiraveli"
             },
             new City
             {
                 Id = 301,
                 DistrictId = 4,
                 NameEn = "Kattankudi"
             },
             new City
             {
                 Id = 302,
                 DistrictId = 4,
                 NameEn = "Kiran"
             },
             new City
             {
                 Id = 303,
                 DistrictId = 4,
                 NameEn = "Kirankulam"
             },
             new City
             {
                 Id = 304,
                 DistrictId = 4,
                 NameEn = "Koddaikallar"
             },
             new City
             {
                 Id = 305,
                 DistrictId = 4,
                 NameEn = "Kokkaddichcholai"
             },
             new City
             {
                 Id = 306,
                 DistrictId = 4,
                 NameEn = "Kurukkalmadam"
             },
             new City
             {
                 Id = 307,
                 DistrictId = 4,
                 NameEn = "Mandur"
             },
             new City
             {
                 Id = 308,
                 DistrictId = 4,
                 NameEn = "Miravodai"
             },
             new City
             {
                 Id = 309,
                 DistrictId = 4,
                 NameEn = "Murakottanchanai"
             },
             new City
             {
                 Id = 310,
                 DistrictId = 4,
                 NameEn = "Navagirinagar"
             },
             new City
             {
                 Id = 311,
                 DistrictId = 4,
                 NameEn = "Navatkadu"
             },
             new City
             {
                 Id = 312,
                 DistrictId = 4,
                 NameEn = "Oddamavadi"
             },
             new City
             {
                 Id = 313,
                 DistrictId = 4,
                 NameEn = "Palamunai"
             },
             new City
             {
                 Id = 314,
                 DistrictId = 4,
                 NameEn = "Pankudavely"
             },
             new City
             {
                 Id = 315,
                 DistrictId = 4,
                 NameEn = "Periyaporativu"
             },
             new City
             {
                 Id = 316,
                 DistrictId = 4,
                 NameEn = "Periyapullumalai"
             },
             new City
             {
                 Id = 317,
                 DistrictId = 4,
                 NameEn = "Pillaiyaradi"
             },
             new City
             {
                 Id = 318,
                 DistrictId = 4,
                 NameEn = "Punanai"
             },
             new City
             {
                 Id = 319,
                 DistrictId = 4,
                 NameEn = "Thannamunai"
             },
             new City
             {
                 Id = 320,
                 DistrictId = 4,
                 NameEn = "Thettativu"
             },
             new City
             {
                 Id = 321,
                 DistrictId = 4,
                 NameEn = "Thikkodai"
             },
             new City
             {
                 Id = 322,
                 DistrictId = 4,
                 NameEn = "Thirupalugamam"
             },
             new City
             {
                 Id = 323,
                 DistrictId = 4,
                 NameEn = "Unnichchai"
             },
             new City
             {
                 Id = 324,
                 DistrictId = 4,
                 NameEn = "Vakaneri"
             },
             new City
             {
                 Id = 325,
                 DistrictId = 4,
                 NameEn = "Vakarai"
             },
             new City
             {
                 Id = 326,
                 DistrictId = 4,
                 NameEn = "Valaichenai"
             },
             new City
             {
                 Id = 327,
                 DistrictId = 4,
                 NameEn = "Vantharumoolai"
             },
             new City
             {
                 Id = 328,
                 DistrictId = 4,
                 NameEn = "Vellavely"
             },
             new City
             {
                 Id = 329,
                 DistrictId = 5,
                 NameEn = "Akarawita"
             },
             new City
             {
                 Id = 330,
                 DistrictId = 5,
                 NameEn = "Ambalangoda"
             },
             new City
             {
                 Id = 331,
                 DistrictId = 5,
                 NameEn = "Athurugiriya"
             },
             new City
             {
                 Id = 332,
                 DistrictId = 5,
                 NameEn = "Avissawella"
             },
             new City
             {
                 Id = 333,
                 DistrictId = 5,
                 NameEn = "Batawala"
             },
             new City
             {
                 Id = 334,
                 DistrictId = 5,
                 NameEn = "Battaramulla"
             },
             new City
             {
                 Id = 335,
                 DistrictId = 5,
                 NameEn = "Biyagama"
             },
             new City
             {
                 Id = 336,
                 DistrictId = 5,
                 NameEn = "Bope"
             },
             new City
             {
                 Id = 337,
                 DistrictId = 5,
                 NameEn = "Boralesgamuwa"
             },
             new City
             {
                 Id = 338,
                 DistrictId = 5,
                 NameEn = "Colombo 8"
             },
             new City
             {
                 Id = 339,
                 DistrictId = 5,
                 NameEn = "Dedigamuwa"
             },
             new City
             {
                 Id = 340,
                 DistrictId = 5,
                 NameEn = "Dehiwala"
             },
             new City
             {
                 Id = 341,
                 DistrictId = 5,
                 NameEn = "Deltara"
             },
             new City
             {
                 Id = 342,
                 DistrictId = 5,
                 NameEn = "Habarakada"
             },
             new City
             {
                 Id = 343,
                 DistrictId = 5,
                 NameEn = "Hanwella"
             },
             new City
             {
                 Id = 344,
                 DistrictId = 5,
                 NameEn = "Hiripitya"
             },
             new City
             {
                 Id = 345,
                 DistrictId = 5,
                 NameEn = "Hokandara"
             },
             new City
             {
                 Id = 346,
                 DistrictId = 5,
                 NameEn = "Homagama"
             },
             new City
             {
                 Id = 347,
                 DistrictId = 5,
                 NameEn = "Horagala"
             },
             new City
             {
                 Id = 348,
                 DistrictId = 5,
                 NameEn = "Kaduwela"
             },
             new City
             {
                 Id = 349,
                 DistrictId = 5,
                 NameEn = "Kaluaggala"
             },
             new City
             {
                 Id = 350,
                 DistrictId = 5,
                 NameEn = "Kapugoda"
             },
             new City
             {
                 Id = 351,
                 DistrictId = 5,
                 NameEn = "Kehelwatta"
             },
             new City
             {
                 Id = 352,
                 DistrictId = 5,
                 NameEn = "Kiriwattuduwa"
             },
             new City
             {
                 Id = 353,
                 DistrictId = 5,
                 NameEn = "Kolonnawa"
             },
             new City
             {
                 Id = 354,
                 DistrictId = 5,
                 NameEn = "Kosgama"
             },
             new City
             {
                 Id = 355,
                 DistrictId = 5,
                 NameEn = "Madapatha"
             },
             new City
             {
                 Id = 356,
                 DistrictId = 5,
                 NameEn = "Maharagama"
             },
             new City
             {
                 Id = 357,
                 DistrictId = 5,
                 NameEn = "Malabe"
             },
             new City
             {
                 Id = 358,
                 DistrictId = 5,
                 NameEn = "Moratuwa"
             },
             new City
             {
                 Id = 359,
                 DistrictId = 5,
                 NameEn = "Mount Lavinia"
             },
             new City
             {
                 Id = 360,
                 DistrictId = 5,
                 NameEn = "Mullegama"
             },
             new City
             {
                 Id = 361,
                 DistrictId = 5,
                 NameEn = "Napawela"
             },
             new City
             {
                 Id = 362,
                 DistrictId = 5,
                 NameEn = "Nugegoda"
             },
             new City
             {
                 Id = 363,
                 DistrictId = 5,
                 NameEn = "Padukka"
             },
             new City
             {
                 Id = 364,
                 DistrictId = 5,
                 NameEn = "Pannipitiya"
             },
             new City
             {
                 Id = 365,
                 DistrictId = 5,
                 NameEn = "Piliyandala"
             },
             new City
             {
                 Id = 366,
                 DistrictId = 5,
                 NameEn = "Pitipana Homagama"
             },
             new City
             {
                 Id = 367,
                 DistrictId = 5,
                 NameEn = "Polgasowita"
             },
             new City
             {
                 Id = 368,
                 DistrictId = 5,
                 NameEn = "Pugoda"
             },
             new City
             {
                 Id = 369,
                 DistrictId = 5,
                 NameEn = "Ranala"
             },
             new City
             {
                 Id = 370,
                 DistrictId = 5,
                 NameEn = "Siddamulla"
             },
             new City
             {
                 Id = 371,
                 DistrictId = 5,
                 NameEn = "Siyambalagoda"
             },
             new City
             {
                 Id = 372,
                 DistrictId = 5,
                 NameEn = "Sri Jayawardenepu"
             },
             new City
             {
                 Id = 373,
                 DistrictId = 5,
                 NameEn = "Talawatugoda"
             },
             new City
             {
                 Id = 374,
                 DistrictId = 5,
                 NameEn = "Tummodara"
             },
             new City
             {
                 Id = 375,
                 DistrictId = 5,
                 NameEn = "Waga"
             },
             new City
             {
                 Id = 376,
                 DistrictId = 5,
                 NameEn = "Colombo 6"
             },
             new City
             {
                 Id = 377,
                 DistrictId = 6,
                 NameEn = "Agaliya"
             },
             new City
             {
                 Id = 378,
                 DistrictId = 6,
                 NameEn = "Ahangama"
             },
             new City
             {
                 Id = 379,
                 DistrictId = 6,
                 NameEn = "Ahungalla"
             },
             new City
             {
                 Id = 380,
                 DistrictId = 6,
                 NameEn = "Akmeemana"
             },
             new City
             {
                 Id = 381,
                 DistrictId = 6,
                 NameEn = "Alawatugoda"
             },
             new City
             {
                 Id = 382,
                 DistrictId = 6,
                 NameEn = "Aluthwala"
             },
             new City
             {
                 Id = 383,
                 DistrictId = 6,
                 NameEn = "Ampegama"
             },
             new City
             {
                 Id = 384,
                 DistrictId = 6,
                 NameEn = "Amugoda"
             },
             new City
             {
                 Id = 385,
                 DistrictId = 6,
                 NameEn = "Anangoda"
             },
             new City
             {
                 Id = 386,
                 DistrictId = 6,
                 NameEn = "Angulugaha"
             },
             new City
             {
                 Id = 387,
                 DistrictId = 6,
                 NameEn = "Ankokkawala"
             },
             new City
             {
                 Id = 388,
                 DistrictId = 6,
                 NameEn = "Aselapura"
             },
             new City
             {
                 Id = 389,
                 DistrictId = 6,
                 NameEn = "Baddegama"
             },
             new City
             {
                 Id = 390,
                 DistrictId = 6,
                 NameEn = "Balapitiya"
             },
             new City
             {
                 Id = 391,
                 DistrictId = 6,
                 NameEn = "Banagala"
             },
             new City
             {
                 Id = 392,
                 DistrictId = 6,
                 NameEn = "Batapola"
             },
             new City
             {
                 Id = 393,
                 DistrictId = 6,
                 NameEn = "Bentota"
             },
             new City
             {
                 Id = 394,
                 DistrictId = 6,
                 NameEn = "Boossa"
             },
             new City
             {
                 Id = 395,
                 DistrictId = 6,
                 NameEn = "Dellawa"
             },
             new City
             {
                 Id = 396,
                 DistrictId = 6,
                 NameEn = "Dikkumbura"
             },
             new City
             {
                 Id = 397,
                 DistrictId = 6,
                 NameEn = "Dodanduwa"
             },
             new City
             {
                 Id = 398,
                 DistrictId = 6,
                 NameEn = "Ella Tanabaddegama"
             },
             new City
             {
                 Id = 399,
                 DistrictId = 6,
                 NameEn = "Elpitiya"
             },
             new City
             {
                 Id = 400,
                 DistrictId = 6,
                 NameEn = "Galle"
             },
             new City
             {
                 Id = 401,
                 DistrictId = 6,
                 NameEn = "Ginimellagaha"
             },
             new City
             {
                 Id = 402,
                 DistrictId = 6,
                 NameEn = "Gintota"
             },
             new City
             {
                 Id = 403,
                 DistrictId = 6,
                 NameEn = "Godahena"
             },
             new City
             {
                 Id = 404,
                 DistrictId = 6,
                 NameEn = "Gonamulla Junction"
             },
             new City
             {
                 Id = 405,
                 DistrictId = 6,
                 NameEn = "Gonapinuwala"
             },
             new City
             {
                 Id = 406,
                 DistrictId = 6,
                 NameEn = "Habaraduwa"
             },
             new City
             {
                 Id = 407,
                 DistrictId = 6,
                 NameEn = "Haburugala"
             },
             new City
             {
                 Id = 408,
                 DistrictId = 6,
                 NameEn = "Hikkaduwa"
             },
             new City
             {
                 Id = 409,
                 DistrictId = 6,
                 NameEn = "Hiniduma"
             },
             new City
             {
                 Id = 410,
                 DistrictId = 6,
                 NameEn = "Hiyare"
             },
             new City
             {
                 Id = 411,
                 DistrictId = 6,
                 NameEn = "Kahaduwa"
             },
             new City
             {
                 Id = 412,
                 DistrictId = 6,
                 NameEn = "Kahawa"
             },
             new City
             {
                 Id = 413,
                 DistrictId = 6,
                 NameEn = "Karagoda"
             },
             new City
             {
                 Id = 414,
                 DistrictId = 6,
                 NameEn = "Karandeniya"
             },
             new City
             {
                 Id = 415,
                 DistrictId = 6,
                 NameEn = "Kosgoda"
             },
             new City
             {
                 Id = 416,
                 DistrictId = 6,
                 NameEn = "Kottawagama"
             },
             new City
             {
                 Id = 417,
                 DistrictId = 6,
                 NameEn = "Kottegoda"
             },
             new City
             {
                 Id = 418,
                 DistrictId = 6,
                 NameEn = "Kuleegoda"
             },
             new City
             {
                 Id = 419,
                 DistrictId = 6,
                 NameEn = "Magedara"
             },
             new City
             {
                 Id = 420,
                 DistrictId = 6,
                 NameEn = "Mahawela Sinhapura"
             },
             new City
             {
                 Id = 421,
                 DistrictId = 6,
                 NameEn = "Mapalagama"
             },
             new City
             {
                 Id = 422,
                 DistrictId = 6,
                 NameEn = "Mapalagama Central"
             },
             new City
             {
                 Id = 423,
                 DistrictId = 6,
                 NameEn = "Mattaka"
             },
             new City
             {
                 Id = 424,
                 DistrictId = 6,
                 NameEn = "Meda-Keembiya"
             },
             new City
             {
                 Id = 425,
                 DistrictId = 6,
                 NameEn = "Meetiyagoda"
             },
             new City
             {
                 Id = 426,
                 DistrictId = 6,
                 NameEn = "Nagoda"
             },
             new City
             {
                 Id = 427,
                 DistrictId = 6,
                 NameEn = "Nakiyadeniya"
             },
             new City
             {
                 Id = 428,
                 DistrictId = 6,
                 NameEn = "Nawadagala"
             },
             new City
             {
                 Id = 429,
                 DistrictId = 6,
                 NameEn = "Neluwa"
             },
             new City
             {
                 Id = 430,
                 DistrictId = 6,
                 NameEn = "Nindana"
             },
             new City
             {
                 Id = 431,
                 DistrictId = 6,
                 NameEn = "Pahala Millawa"
             },
             new City
             {
                 Id = 432,
                 DistrictId = 6,
                 NameEn = "Panangala"
             },
             new City
             {
                 Id = 433,
                 DistrictId = 6,
                 NameEn = "Pannimulla Panagoda"
             },
             new City
             {
                 Id = 434,
                 DistrictId = 6,
                 NameEn = "Parana ThanaYamgoda"
             },
             new City
             {
                 Id = 435,
                 DistrictId = 6,
                 NameEn = "Patana"
             },
             new City
             {
                 Id = 436,
                 DistrictId = 6,
                 NameEn = "Pitigala"
             },
             new City
             {
                 Id = 437,
                 DistrictId = 6,
                 NameEn = "Poddala"
             },
             new City
             {
                 Id = 438,
                 DistrictId = 6,
                 NameEn = "Polgampola"
             },
             new City
             {
                 Id = 439,
                 DistrictId = 6,
                 NameEn = "Porawagama"
             },
             new City
             {
                 Id = 440,
                 DistrictId = 6,
                 NameEn = "Rantotuwila"
             },
             new City
             {
                 Id = 441,
                 DistrictId = 6,
                 NameEn = "Talagampola"
             },
             new City
             {
                 Id = 442,
                 DistrictId = 6,
                 NameEn = "Talgaspe"
             },
             new City
             {
                 Id = 443,
                 DistrictId = 6,
                 NameEn = "Talpe"
             },
             new City
             {
                 Id = 444,
                 DistrictId = 6,
                 NameEn = "Tawalama"
             },
             new City
             {
                 Id = 445,
                 DistrictId = 6,
                 NameEn = "Tiranagama"
             },
             new City
             {
                 Id = 446,
                 DistrictId = 6,
                 NameEn = "Udalamatta"
             },
             new City
             {
                 Id = 447,
                 DistrictId = 6,
                 NameEn = "Udugama"
             },
             new City
             {
                 Id = 448,
                 DistrictId = 6,
                 NameEn = "Uluvitike"
             },
             new City
             {
                 Id = 449,
                 DistrictId = 6,
                 NameEn = "Unawatuna"
             },
             new City
             {
                 Id = 450,
                 DistrictId = 6,
                 NameEn = "Unenwitiya"
             },
             new City
             {
                 Id = 451,
                 DistrictId = 6,
                 NameEn = "Uragaha"
             },
             new City
             {
                 Id = 452,
                 DistrictId = 6,
                 NameEn = "Uragasmanhandiya"
             },
             new City
             {
                 Id = 453,
                 DistrictId = 6,
                 NameEn = "Wakwella"
             },
             new City
             {
                 Id = 454,
                 DistrictId = 6,
                 NameEn = "Walahanduwa"
             },
             new City
             {
                 Id = 455,
                 DistrictId = 6,
                 NameEn = "Wanchawela"
             },
             new City
             {
                 Id = 456,
                 DistrictId = 6,
                 NameEn = "Wanduramba"
             },
             new City
             {
                 Id = 457,
                 DistrictId = 6,
                 NameEn = "Warukandeniya"
             },
             new City
             {
                 Id = 458,
                 DistrictId = 6,
                 NameEn = "Watugedara"
             },
             new City
             {
                 Id = 459,
                 DistrictId = 6,
                 NameEn = "Weihena"
             },
             new City
             {
                 Id = 460,
                 DistrictId = 6,
                 NameEn = "Welikanda"
             },
             new City
             {
                 Id = 461,
                 DistrictId = 6,
                 NameEn = "Wilanagama"
             },
             new City
             {
                 Id = 462,
                 DistrictId = 6,
                 NameEn = "Yakkalamulla"
             },
             new City
             {
                 Id = 463,
                 DistrictId = 6,
                 NameEn = "Yatalamatta"
             },
             new City
             {
                 Id = 464,
                 DistrictId = 7,
                 NameEn = "Akaragama"
             },
             new City
             {
                 Id = 465,
                 DistrictId = 7,
                 NameEn = "Ambagaspitiya"
             },
             new City
             {
                 Id = 466,
                 DistrictId = 7,
                 NameEn = "Ambepussa"
             },
             new City
             {
                 Id = 467,
                 DistrictId = 7,
                 NameEn = "Andiambalama"
             },
             new City
             {
                 Id = 468,
                 DistrictId = 7,
                 NameEn = "Attanagalla"
             },
             new City
             {
                 Id = 469,
                 DistrictId = 7,
                 NameEn = "Badalgama"
             },
             new City
             {
                 Id = 470,
                 DistrictId = 7,
                 NameEn = "Banduragoda"
             },
             new City
             {
                 Id = 471,
                 DistrictId = 7,
                 NameEn = "Batuwatta"
             },
             new City
             {
                 Id = 472,
                 DistrictId = 7,
                 NameEn = "Bemmulla"
             },
             new City
             {
                 Id = 473,
                 DistrictId = 7,
                 NameEn = "Biyagama IPZ"
             },
             new City
             {
                 Id = 474,
                 DistrictId = 7,
                 NameEn = "Bokalagama"
             },
             new City
             {
                 Id = 475,
                 DistrictId = 7,
                 NameEn = "Bollete (WP)"
             },
             new City
             {
                 Id = 476,
                 DistrictId = 7,
                 NameEn = "Bopagama"
             },
             new City
             {
                 Id = 477,
                 DistrictId = 7,
                 NameEn = "Buthpitiya"
             },
             new City
             {
                 Id = 478,
                 DistrictId = 7,
                 NameEn = "Dagonna"
             },
             new City
             {
                 Id = 479,
                 DistrictId = 7,
                 NameEn = "Danowita"
             },
             new City
             {
                 Id = 480,
                 DistrictId = 7,
                 NameEn = "Debahera"
             },
             new City
             {
                 Id = 481,
                 DistrictId = 7,
                 NameEn = "Dekatana"
             },
             new City
             {
                 Id = 482,
                 DistrictId = 7,
                 NameEn = "Delgoda"
             },
             new City
             {
                 Id = 483,
                 DistrictId = 7,
                 NameEn = "Delwagura"
             },
             new City
             {
                 Id = 484,
                 DistrictId = 7,
                 NameEn = "Demalagama"
             },
             new City
             {
                 Id = 485,
                 DistrictId = 7,
                 NameEn = "Demanhandiya"
             },
             new City
             {
                 Id = 486,
                 DistrictId = 7,
                 NameEn = "Dewalapola"
             },
             new City
             {
                 Id = 487,
                 DistrictId = 7,
                 NameEn = "Divulapitiya"
             },
             new City
             {
                 Id = 488,
                 DistrictId = 7,
                 NameEn = "Divuldeniya"
             },
             new City
             {
                 Id = 489,
                 DistrictId = 7,
                 NameEn = "Dompe"
             },
             new City
             {
                 Id = 490,
                 DistrictId = 7,
                 NameEn = "Dunagaha"
             },
             new City
             {
                 Id = 491,
                 DistrictId = 7,
                 NameEn = "Ekala"
             },
             new City
             {
                 Id = 492,
                 DistrictId = 7,
                 NameEn = "Ellakkala"
             },
             new City
             {
                 Id = 493,
                 DistrictId = 7,
                 NameEn = "Essella"
             },
             new City
             {
                 Id = 494,
                 DistrictId = 7,
                 NameEn = "Galedanda"
             },
             new City
             {
                 Id = 495,
                 DistrictId = 7,
                 NameEn = "Gampaha"
             },
             new City
             {
                 Id = 496,
                 DistrictId = 7,
                 NameEn = "Ganemulla"
             },
             new City
             {
                 Id = 497,
                 DistrictId = 7,
                 NameEn = "Giriulla"
             },
             new City
             {
                 Id = 498,
                 DistrictId = 7,
                 NameEn = "Gonawala"
             },
             new City
             {
                 Id = 499,
                 DistrictId = 7,
                 NameEn = "Halpe"
             },
             new City
             {
                 Id = 500,
                 DistrictId = 7,
                 NameEn = "Hapugastenna"
             },
             new City
             {
                 Id = 501,
                 DistrictId = 7,
                 NameEn = "Heiyanthuduwa"
             },
             new City
             {
                 Id = 502,
                 DistrictId = 7,
                 NameEn = "Hinatiyana Madawala"
             },
             new City
             {
                 Id = 503,
                 DistrictId = 7,
                 NameEn = "Hiswella"
             },
             new City
             {
                 Id = 504,
                 DistrictId = 7,
                 NameEn = "Horampella"
             },
             new City
             {
                 Id = 505,
                 DistrictId = 7,
                 NameEn = "Hunumulla"
             },
             new City
             {
                 Id = 506,
                 DistrictId = 7,
                 NameEn = "Hunupola"
             },
             new City
             {
                 Id = 507,
                 DistrictId = 7,
                 NameEn = "Ihala Madampella"
             },
             new City
             {
                 Id = 508,
                 DistrictId = 7,
                 NameEn = "Imbulgoda"
             },
             new City
             {
                 Id = 509,
                 DistrictId = 7,
                 NameEn = "Ja-Ela"
             },
             new City
             {
                 Id = 510,
                 DistrictId = 7,
                 NameEn = "Kadawatha"
             },
             new City
             {
                 Id = 511,
                 DistrictId = 7,
                 NameEn = "Kahatowita"
             },
             new City
             {
                 Id = 512,
                 DistrictId = 7,
                 NameEn = "Kalagedihena"
             },
             new City
             {
                 Id = 513,
                 DistrictId = 7,
                 NameEn = "Kaleliya"
             },
             new City
             {
                 Id = 514,
                 DistrictId = 7,
                 NameEn = "Kandana"
             },
             new City
             {
                 Id = 515,
                 DistrictId = 7,
                 NameEn = "Katana"
             },
             new City
             {
                 Id = 516,
                 DistrictId = 7,
                 NameEn = "Katudeniya"
             },
             new City
             {
                 Id = 517,
                 DistrictId = 7,
                 NameEn = "Katunayake"
             },
             new City
             {
                 Id = 518,
                 DistrictId = 7,
                 NameEn = "Katunayake Air Force Camp"
             },
             new City
             {
                 Id = 519,
                 DistrictId = 7,
                 NameEn = "Katunayake(FTZ)"
             },
             new City
             {
                 Id = 520,
                 DistrictId = 7,
                 NameEn = "Katuwellegama"
             },
             new City
             {
                 Id = 521,
                 DistrictId = 7,
                 NameEn = "Kelaniya"
             },
             new City
             {
                 Id = 522,
                 DistrictId = 7,
                 NameEn = "Kimbulapitiya"
             },
             new City
             {
                 Id = 523,
                 DistrictId = 7,
                 NameEn = "Kirindiwela"
             },
             new City
             {
                 Id = 524,
                 DistrictId = 7,
                 NameEn = "Kitalawalana"
             },
             new City
             {
                 Id = 525,
                 DistrictId = 7,
                 NameEn = "Kochchikade"
             },
             new City
             {
                 Id = 526,
                 DistrictId = 7,
                 NameEn = "Kotadeniyawa"
             },
             new City
             {
                 Id = 527,
                 DistrictId = 7,
                 NameEn = "Kotugoda"
             },
             new City
             {
                 Id = 528,
                 DistrictId = 7,
                 NameEn = "Kumbaloluwa"
             },
             new City
             {
                 Id = 529,
                 DistrictId = 7,
                 NameEn = "Loluwagoda"
             },
             new City
             {
                 Id = 530,
                 DistrictId = 7,
                 NameEn = "Mabodale"
             },
             new City
             {
                 Id = 531,
                 DistrictId = 7,
                 NameEn = "Madelgamuwa"
             },
             new City
             {
                 Id = 532,
                 DistrictId = 7,
                 NameEn = "Makewita"
             },
             new City
             {
                 Id = 533,
                 DistrictId = 7,
                 NameEn = "Makola"
             },
             new City
             {
                 Id = 534,
                 DistrictId = 7,
                 NameEn = "Malwana"
             },
             new City
             {
                 Id = 535,
                 DistrictId = 7,
                 NameEn = "Mandawala"
             },
             new City
             {
                 Id = 536,
                 DistrictId = 7,
                 NameEn = "Marandagahamula"
             },
             new City
             {
                 Id = 537,
                 DistrictId = 7,
                 NameEn = "Mellawagedara"
             },
             new City
             {
                 Id = 538,
                 DistrictId = 7,
                 NameEn = "Minuwangoda"
             },
             new City
             {
                 Id = 539,
                 DistrictId = 7,
                 NameEn = "Mirigama"
             },
             new City
             {
                 Id = 540,
                 DistrictId = 7,
                 NameEn = "Miriswatta"
             },
             new City
             {
                 Id = 541,
                 DistrictId = 7,
                 NameEn = "Mithirigala"
             },
             new City
             {
                 Id = 542,
                 DistrictId = 7,
                 NameEn = "Muddaragama"
             },
             new City
             {
                 Id = 543,
                 DistrictId = 7,
                 NameEn = "Mudungoda"
             },
             new City
             {
                 Id = 544,
                 DistrictId = 7,
                 NameEn = "Mulleriyawa New Town"
             },
             new City
             {
                 Id = 545,
                 DistrictId = 7,
                 NameEn = "Naranwala"
             },
             new City
             {
                 Id = 546,
                 DistrictId = 7,
                 NameEn = "Nawana"
             },
             new City
             {
                 Id = 547,
                 DistrictId = 7,
                 NameEn = "Nedungamuwa"
             },
             new City
             {
                 Id = 548,
                 DistrictId = 7,
                 NameEn = "Negombo"
             },
             new City
             {
                 Id = 549,
                 DistrictId = 7,
                 NameEn = "Nikadalupotha"
             },
             new City
             {
                 Id = 550,
                 DistrictId = 7,
                 NameEn = "Nikahetikanda"
             },
             new City
             {
                 Id = 551,
                 DistrictId = 7,
                 NameEn = "Nittambuwa"
             },
             new City
             {
                 Id = 552,
                 DistrictId = 7,
                 NameEn = "Niwandama"
             },
             new City
             {
                 Id = 553,
                 DistrictId = 7,
                 NameEn = "Opatha"
             },
             new City
             {
                 Id = 554,
                 DistrictId = 7,
                 NameEn = "Pamunugama"
             },
             new City
             {
                 Id = 555,
                 DistrictId = 7,
                 NameEn = "Pamunuwatta"
             },
             new City
             {
                 Id = 556,
                 DistrictId = 7,
                 NameEn = "Panawala"
             },
             new City
             {
                 Id = 557,
                 DistrictId = 7,
                 NameEn = "Pasyala"
             },
             new City
             {
                 Id = 558,
                 DistrictId = 7,
                 NameEn = "Peliyagoda"
             },
             new City
             {
                 Id = 559,
                 DistrictId = 7,
                 NameEn = "Pepiliyawala"
             },
             new City
             {
                 Id = 560,
                 DistrictId = 7,
                 NameEn = "Pethiyagoda"
             },
             new City
             {
                 Id = 561,
                 DistrictId = 7,
                 NameEn = "Polpithimukulana"
             },
             new City
             {
                 Id = 562,
                 DistrictId = 7,
                 NameEn = "Puwakpitiya"
             },
             new City
             {
                 Id = 563,
                 DistrictId = 7,
                 NameEn = "Radawadunna"
             },
             new City
             {
                 Id = 564,
                 DistrictId = 7,
                 NameEn = "Radawana"
             },
             new City
             {
                 Id = 565,
                 DistrictId = 7,
                 NameEn = "Raddolugama"
             },
             new City
             {
                 Id = 566,
                 DistrictId = 7,
                 NameEn = "Ragama"
             },
             new City
             {
                 Id = 567,
                 DistrictId = 7,
                 NameEn = "Ruggahawila"
             },
             new City
             {
                 Id = 568,
                 DistrictId = 7,
                 NameEn = "Seeduwa"
             },
             new City
             {
                 Id = 569,
                 DistrictId = 7,
                 NameEn = "Siyambalape"
             },
             new City
             {
                 Id = 570,
                 DistrictId = 7,
                 NameEn = "Talahena"
             },
             new City
             {
                 Id = 571,
                 DistrictId = 7,
                 NameEn = "Thambagalla"
             },
             new City
             {
                 Id = 572,
                 DistrictId = 7,
                 NameEn = "Thimbirigaskatuwa"
             },
             new City
             {
                 Id = 573,
                 DistrictId = 7,
                 NameEn = "Tittapattara"
             },
             new City
             {
                 Id = 574,
                 DistrictId = 7,
                 NameEn = "Udathuthiripitiya"
             },
             new City
             {
                 Id = 575,
                 DistrictId = 7,
                 NameEn = "Udugampola"
             },
             new City
             {
                 Id = 576,
                 DistrictId = 7,
                 NameEn = "Uggalboda"
             },
             new City
             {
                 Id = 577,
                 DistrictId = 7,
                 NameEn = "Urapola"
             },
             new City
             {
                 Id = 578,
                 DistrictId = 7,
                 NameEn = "Uswetakeiyawa"
             },
             new City
             {
                 Id = 579,
                 DistrictId = 7,
                 NameEn = "Veyangoda"
             },
             new City
             {
                 Id = 580,
                 DistrictId = 7,
                 NameEn = "Walgammulla"
             },
             new City
             {
                 Id = 581,
                 DistrictId = 7,
                 NameEn = "Walpita"
             },
             new City
             {
                 Id = 582,
                 DistrictId = 7,
                 NameEn = "Walpola (WP)"
             },
             new City
             {
                 Id = 583,
                 DistrictId = 7,
                 NameEn = "Wathurugama"
             },
             new City
             {
                 Id = 584,
                 DistrictId = 7,
                 NameEn = "Watinapaha"
             },
             new City
             {
                 Id = 585,
                 DistrictId = 7,
                 NameEn = "Wattala"
             },
             new City
             {
                 Id = 586,
                 DistrictId = 7,
                 NameEn = "Weboda"
             },
             new City
             {
                 Id = 587,
                 DistrictId = 7,
                 NameEn = "Wegowwa"
             },
             new City
             {
                 Id = 588,
                 DistrictId = 7,
                 NameEn = "Weweldeniya"
             },
             new City
             {
                 Id = 589,
                 DistrictId = 7,
                 NameEn = "Yakkala"
             },
             new City
             {
                 Id = 590,
                 DistrictId = 7,
                 NameEn = "Yatiyana"
             },
             new City
             {
                 Id = 591,
                 DistrictId = 8,
                 NameEn = "Ambalantota"
             },
             new City
             {
                 Id = 592,
                 DistrictId = 8,
                 NameEn = "Angunakolapelessa"
             },
             new City
             {
                 Id = 593,
                 DistrictId = 8,
                 NameEn = "Angunakolawewa"
             },
             new City
             {
                 Id = 594,
                 DistrictId = 8,
                 NameEn = "Bandagiriya Colony"
             },
             new City
             {
                 Id = 595,
                 DistrictId = 8,
                 NameEn = "Barawakumbuka"
             },
             new City
             {
                 Id = 596,
                 DistrictId = 8,
                 NameEn = "Beliatta"
             },
             new City
             {
                 Id = 597,
                 DistrictId = 8,
                 NameEn = "Beragama"
             },
             new City
             {
                 Id = 598,
                 DistrictId = 8,
                 NameEn = "Beralihela"
             },
             new City
             {
                 Id = 599,
                 DistrictId = 8,
                 NameEn = "Bundala"
             },
             new City
             {
                 Id = 600,
                 DistrictId = 8,
                 NameEn = "Ellagala"
             },
             new City
             {
                 Id = 601,
                 DistrictId = 8,
                 NameEn = "Gangulandeniya"
             },
             new City
             {
                 Id = 602,
                 DistrictId = 8,
                 NameEn = "Getamanna"
             },
             new City
             {
                 Id = 603,
                 DistrictId = 8,
                 NameEn = "Goda Koggalla"
             },
             new City
             {
                 Id = 604,
                 DistrictId = 8,
                 NameEn = "Gonagamuwa Uduwila"
             },
             new City
             {
                 Id = 605,
                 DistrictId = 8,
                 NameEn = "Gonnoruwa"
             },
             new City
             {
                 Id = 606,
                 DistrictId = 8,
                 NameEn = "Hakuruwela"
             },
             new City
             {
                 Id = 607,
                 DistrictId = 8,
                 NameEn = "Hambantota"
             },
             new City
             {
                 Id = 608,
                 DistrictId = 8,
                 NameEn = "Handugala"
             },
             new City
             {
                 Id = 609,
                 DistrictId = 8,
                 NameEn = "Hungama"
             },
             new City
             {
                 Id = 610,
                 DistrictId = 8,
                 NameEn = "Ihala Beligalla"
             },
             new City
             {
                 Id = 611,
                 DistrictId = 8,
                 NameEn = "Ittademaliya"
             },
             new City
             {
                 Id = 612,
                 DistrictId = 8,
                 NameEn = "Julampitiya"
             },
             new City
             {
                 Id = 613,
                 DistrictId = 8,
                 NameEn = "Kahandamodara"
             },
             new City
             {
                 Id = 614,
                 DistrictId = 8,
                 NameEn = "Kariyamaditta"
             },
             new City
             {
                 Id = 615,
                 DistrictId = 8,
                 NameEn = "Katuwana"
             },
             new City
             {
                 Id = 616,
                 DistrictId = 8,
                 NameEn = "Kawantissapura"
             },
             new City
             {
                 Id = 617,
                 DistrictId = 8,
                 NameEn = "Kirama"
             },
             new City
             {
                 Id = 618,
                 DistrictId = 8,
                 NameEn = "Kirinda"
             },
             new City
             {
                 Id = 619,
                 DistrictId = 8,
                 NameEn = "Lunama"
             },
             new City
             {
                 Id = 620,
                 DistrictId = 8,
                 NameEn = "Lunugamwehera"
             },
             new City
             {
                 Id = 621,
                 DistrictId = 8,
                 NameEn = "Magama"
             },
             new City
             {
                 Id = 622,
                 DistrictId = 8,
                 NameEn = "Mahagalwewa"
             },
             new City
             {
                 Id = 623,
                 DistrictId = 8,
                 NameEn = "Mamadala"
             },
             new City
             {
                 Id = 624,
                 DistrictId = 8,
                 NameEn = "Medamulana"
             },
             new City
             {
                 Id = 625,
                 DistrictId = 8,
                 NameEn = "Middeniya"
             },
             new City
             {
                 Id = 626,
                 DistrictId = 8,
                 NameEn = "Migahajandur"
             },
             new City
             {
                 Id = 627,
                 DistrictId = 8,
                 NameEn = "Modarawana"
             },
             new City
             {
                 Id = 628,
                 DistrictId = 8,
                 NameEn = "Mulkirigala"
             },
             new City
             {
                 Id = 629,
                 DistrictId = 8,
                 NameEn = "Nakulugamuwa"
             },
             new City
             {
                 Id = 630,
                 DistrictId = 8,
                 NameEn = "Netolpitiya"
             },
             new City
             {
                 Id = 631,
                 DistrictId = 8,
                 NameEn = "Nihiluwa"
             },
             new City
             {
                 Id = 632,
                 DistrictId = 8,
                 NameEn = "Padawkema"
             },
             new City
             {
                 Id = 633,
                 DistrictId = 8,
                 NameEn = "Pahala Andarawewa"
             },
             new City
             {
                 Id = 634,
                 DistrictId = 8,
                 NameEn = "Rammalawarapitiya"
             },
             new City
             {
                 Id = 635,
                 DistrictId = 8,
                 NameEn = "Ranakeliya"
             },
             new City
             {
                 Id = 636,
                 DistrictId = 8,
                 NameEn = "Ranmuduwewa"
             },
             new City
             {
                 Id = 637,
                 DistrictId = 8,
                 NameEn = "Ranna"
             },
             new City
             {
                 Id = 638,
                 DistrictId = 8,
                 NameEn = "Ratmalwala"
             },
             new City
             {
                 Id = 639,
                 DistrictId = 8,
                 NameEn = "Ridiyagama"
             },
             new City
             {
                 Id = 640,
                 DistrictId = 8,
                 NameEn = "Sooriyawewa Town"
             },
             new City
             {
                 Id = 641,
                 DistrictId = 8,
                 NameEn = "Tangalla"
             },
             new City
             {
                 Id = 642,
                 DistrictId = 8,
                 NameEn = "Tissamaharama"
             },
             new City
             {
                 Id = 643,
                 DistrictId = 8,
                 NameEn = "Uda Gomadiya"
             },
             new City
             {
                 Id = 644,
                 DistrictId = 8,
                 NameEn = "Udamattala"
             },
             new City
             {
                 Id = 645,
                 DistrictId = 8,
                 NameEn = "Uswewa"
             },
             new City
             {
                 Id = 646,
                 DistrictId = 8,
                 NameEn = "Vitharandeniya"
             },
             new City
             {
                 Id = 647,
                 DistrictId = 8,
                 NameEn = "Walasmulla"
             },
             new City
             {
                 Id = 648,
                 DistrictId = 8,
                 NameEn = "Weeraketiya"
             },
             new City
             {
                 Id = 649,
                 DistrictId = 8,
                 NameEn = "Weerawila"
             },
             new City
             {
                 Id = 650,
                 DistrictId = 8,
                 NameEn = "Weerawila NewTown"
             },
             new City
             {
                 Id = 651,
                 DistrictId = 8,
                 NameEn = "Wekandawela"
             },
             new City
             {
                 Id = 652,
                 DistrictId = 8,
                 NameEn = "Weligatta"
             },
             new City
             {
                 Id = 653,
                 DistrictId = 8,
                 NameEn = "Yatigala"
             },
             new City
             {
                 Id = 654,
                 DistrictId = 9,
                 NameEn = "Jaffna"
             },
             new City
             {
                 Id = 655,
                 DistrictId = 10,
                 NameEn = "Agalawatta"
             },
             new City
             {
                 Id = 656,
                 DistrictId = 10,
                 NameEn = "Alubomulla"
             },
             new City
             {
                 Id = 657,
                 DistrictId = 10,
                 NameEn = "Anguruwatota"
             },
             new City
             {
                 Id = 658,
                 DistrictId = 10,
                 NameEn = "Atale"
             },
             new City
             {
                 Id = 659,
                 DistrictId = 10,
                 NameEn = "Baduraliya"
             },
             new City
             {
                 Id = 660,
                 DistrictId = 10,
                 NameEn = "Bandaragama"
             },
             new City
             {
                 Id = 661,
                 DistrictId = 10,
                 NameEn = "Batugampola"
             },
             new City
             {
                 Id = 662,
                 DistrictId = 10,
                 NameEn = "Bellana"
             },
             new City
             {
                 Id = 663,
                 DistrictId = 10,
                 NameEn = "Beruwala"
             },
             new City
             {
                 Id = 664,
                 DistrictId = 10,
                 NameEn = "Bolossagama"
             },
             new City
             {
                 Id = 665,
                 DistrictId = 10,
                 NameEn = "Bombuwala"
             },
             new City
             {
                 Id = 666,
                 DistrictId = 10,
                 NameEn = "Boralugoda"
             },
             new City
             {
                 Id = 667,
                 DistrictId = 10,
                 NameEn = "Bulathsinhala"
             },
             new City
             {
                 Id = 668,
                 DistrictId = 10,
                 NameEn = "Danawala Thiniyawala"
             },
             new City
             {
                 Id = 669,
                 DistrictId = 10,
                 NameEn = "Delmella"
             },
             new City
             {
                 Id = 670,
                 DistrictId = 10,
                 NameEn = "Dharga Town"
             },
             new City
             {
                 Id = 671,
                 DistrictId = 10,
                 NameEn = "Diwalakada"
             },
             new City
             {
                 Id = 672,
                 DistrictId = 10,
                 NameEn = "Dodangoda"
             },
             new City
             {
                 Id = 673,
                 DistrictId = 10,
                 NameEn = "Dombagoda"
             },
             new City
             {
                 Id = 674,
                 DistrictId = 10,
                 NameEn = "Ethkandura"
             },
             new City
             {
                 Id = 675,
                 DistrictId = 10,
                 NameEn = "Galpatha"
             },
             new City
             {
                 Id = 676,
                 DistrictId = 10,
                 NameEn = "Gamagoda"
             },
             new City
             {
                 Id = 677,
                 DistrictId = 10,
                 NameEn = "Gonagalpura"
             },
             new City
             {
                 Id = 678,
                 DistrictId = 10,
                 NameEn = "Gonapola Junction"
             },
             new City
             {
                 Id = 679,
                 DistrictId = 10,
                 NameEn = "Govinna"
             },
             new City
             {
                 Id = 680,
                 DistrictId = 10,
                 NameEn = "Gurulubadda"
             },
             new City
             {
                 Id = 681,
                 DistrictId = 10,
                 NameEn = "Halkandawila"
             },
             new City
             {
                 Id = 682,
                 DistrictId = 10,
                 NameEn = "Haltota"
             },
             new City
             {
                 Id = 683,
                 DistrictId = 10,
                 NameEn = "Halvitigala Colony"
             },
             new City
             {
                 Id = 684,
                 DistrictId = 10,
                 NameEn = "Halwala"
             },
             new City
             {
                 Id = 685,
                 DistrictId = 10,
                 NameEn = "Halwatura"
             },
             new City
             {
                 Id = 686,
                 DistrictId = 10,
                 NameEn = "Handapangoda"
             },
             new City
             {
                 Id = 687,
                 DistrictId = 10,
                 NameEn = "Hedigalla Colony"
             },
             new City
             {
                 Id = 688,
                 DistrictId = 10,
                 NameEn = "Henegama"
             },
             new City
             {
                 Id = 689,
                 DistrictId = 10,
                 NameEn = "Hettimulla"
             },
             new City
             {
                 Id = 690,
                 DistrictId = 10,
                 NameEn = "Horana"
             },
             new City
             {
                 Id = 691,
                 DistrictId = 10,
                 NameEn = "Ittapana"
             },
             new City
             {
                 Id = 692,
                 DistrictId = 10,
                 NameEn = "Kahawala"
             },
             new City
             {
                 Id = 693,
                 DistrictId = 10,
                 NameEn = "Kalawila Kiranthidiya"
             },
             new City
             {
                 Id = 694,
                 DistrictId = 10,
                 NameEn = "Kalutara"
             },
             new City
             {
                 Id = 695,
                 DistrictId = 10,
                 NameEn = "Kananwila"
             },
             new City
             {
                 Id = 696,
                 DistrictId = 10,
                 NameEn = "Kandanagama"
             },
             new City
             {
                 Id = 697,
                 DistrictId = 10,
                 NameEn = "Kelinkanda"
             },
             new City
             {
                 Id = 698,
                 DistrictId = 10,
                 NameEn = "Kitulgoda"
             },
             new City
             {
                 Id = 699,
                 DistrictId = 10,
                 NameEn = "Koholana"
             },
             new City
             {
                 Id = 700,
                 DistrictId = 10,
                 NameEn = "Kuda Uduwa"
             },
             new City
             {
                 Id = 701,
                 DistrictId = 10,
                 NameEn = "Labbala"
             },
             new City
             {
                 Id = 702,
                 DistrictId = 10,
                 NameEn = "lhalahewessa"
             },
             new City
             {
                 Id = 703,
                 DistrictId = 10,
                 NameEn = "lnduruwa"
             },
             new City
             {
                 Id = 704,
                 DistrictId = 10,
                 NameEn = "lngiriya"
             },
             new City
             {
                 Id = 705,
                 DistrictId = 10,
                 NameEn = "Maggona"
             },
             new City
             {
                 Id = 706,
                 DistrictId = 10,
                 NameEn = "Mahagama"
             },
             new City
             {
                 Id = 707,
                 DistrictId = 10,
                 NameEn = "Mahakalupahana"
             },
             new City
             {
                 Id = 708,
                 DistrictId = 10,
                 NameEn = "Maharangalla"
             },
             new City
             {
                 Id = 709,
                 DistrictId = 10,
                 NameEn = "Malgalla Talangalla"
             },
             new City
             {
                 Id = 710,
                 DistrictId = 10,
                 NameEn = "Matugama"
             },
             new City
             {
                 Id = 711,
                 DistrictId = 10,
                 NameEn = "Meegahatenna"
             },
             new City
             {
                 Id = 712,
                 DistrictId = 10,
                 NameEn = "Meegama"
             },
             new City
             {
                 Id = 713,
                 DistrictId = 10,
                 NameEn = "Meegoda"
             },
             new City
             {
                 Id = 714,
                 DistrictId = 10,
                 NameEn = "Millaniya"
             },
             new City
             {
                 Id = 715,
                 DistrictId = 10,
                 NameEn = "Millewa"
             },
             new City
             {
                 Id = 716,
                 DistrictId = 10,
                 NameEn = "Miwanapalana"
             },
             new City
             {
                 Id = 717,
                 DistrictId = 10,
                 NameEn = "Molkawa"
             },
             new City
             {
                 Id = 718,
                 DistrictId = 10,
                 NameEn = "Morapitiya"
             },
             new City
             {
                 Id = 719,
                 DistrictId = 10,
                 NameEn = "Morontuduwa"
             },
             new City
             {
                 Id = 720,
                 DistrictId = 10,
                 NameEn = "Nawattuduwa"
             },
             new City
             {
                 Id = 721,
                 DistrictId = 10,
                 NameEn = "Neboda"
             },
             new City
             {
                 Id = 722,
                 DistrictId = 10,
                 NameEn = "Padagoda"
             },
             new City
             {
                 Id = 723,
                 DistrictId = 10,
                 NameEn = "Pahalahewessa"
             },
             new City
             {
                 Id = 724,
                 DistrictId = 10,
                 NameEn = "Paiyagala"
             },
             new City
             {
                 Id = 725,
                 DistrictId = 10,
                 NameEn = "Panadura"
             },
             new City
             {
                 Id = 726,
                 DistrictId = 10,
                 NameEn = "Pannala"
             },
             new City
             {
                 Id = 727,
                 DistrictId = 10,
                 NameEn = "Paragastota"
             },
             new City
             {
                 Id = 728,
                 DistrictId = 10,
                 NameEn = "Paragoda"
             },
             new City
             {
                 Id = 729,
                 DistrictId = 10,
                 NameEn = "Paraigama"
             },
             new City
             {
                 Id = 730,
                 DistrictId = 10,
                 NameEn = "Pelanda"
             },
             new City
             {
                 Id = 731,
                 DistrictId = 10,
                 NameEn = "Pelawatta"
             },
             new City
             {
                 Id = 732,
                 DistrictId = 10,
                 NameEn = "Pimbura"
             },
             new City
             {
                 Id = 733,
                 DistrictId = 10,
                 NameEn = "Pitagaldeniya"
             },
             new City
             {
                 Id = 734,
                 DistrictId = 10,
                 NameEn = "Pokunuwita"
             },
             new City
             {
                 Id = 735,
                 DistrictId = 10,
                 NameEn = "Poruwedanda"
             },
             new City
             {
                 Id = 736,
                 DistrictId = 10,
                 NameEn = "Ratmale"
             },
             new City
             {
                 Id = 737,
                 DistrictId = 10,
                 NameEn = "Remunagoda"
             },
             new City
             {
                 Id = 738,
                 DistrictId = 10,
                 NameEn = "Talgaswela"
             },
             new City
             {
                 Id = 739,
                 DistrictId = 10,
                 NameEn = "Tebuwana"
             },
             new City
             {
                 Id = 740,
                 DistrictId = 10,
                 NameEn = "Uduwara"
             },
             new City
             {
                 Id = 741,
                 DistrictId = 10,
                 NameEn = "Utumgama"
             },
             new City
             {
                 Id = 742,
                 DistrictId = 10,
                 NameEn = "Veyangalla"
             },
             new City
             {
                 Id = 743,
                 DistrictId = 10,
                 NameEn = "Wadduwa"
             },
             new City
             {
                 Id = 744,
                 DistrictId = 10,
                 NameEn = "Walagedara"
             },
             new City
             {
                 Id = 745,
                 DistrictId = 10,
                 NameEn = "Walallawita"
             },
             new City
             {
                 Id = 746,
                 DistrictId = 10,
                 NameEn = "Waskaduwa"
             },
             new City
             {
                 Id = 747,
                 DistrictId = 10,
                 NameEn = "Welipenna"
             },
             new City
             {
                 Id = 748,
                 DistrictId = 10,
                 NameEn = "Weliveriya"
             },
             new City
             {
                 Id = 749,
                 DistrictId = 10,
                 NameEn = "Welmilla Junction"
             },
             new City
             {
                 Id = 750,
                 DistrictId = 10,
                 NameEn = "Weragala"
             },
             new City
             {
                 Id = 751,
                 DistrictId = 10,
                 NameEn = "Yagirala"
             },
             new City
             {
                 Id = 752,
                 DistrictId = 10,
                 NameEn = "Yatadolawatta"
             },
             new City
             {
                 Id = 753,
                 DistrictId = 10,
                 NameEn = "Yatawara Junction"
             },
             new City
             {
                 Id = 754,
                 DistrictId = 11,
                 NameEn = "Aludeniya"
             },
             new City
             {
                 Id = 755,
                 DistrictId = 11,
                 NameEn = "Ambagahapelessa"
             },
             new City
             {
                 Id = 756,
                 DistrictId = 11,
                 NameEn = "Ambagamuwa Udabulathgama"
             },
             new City
             {
                 Id = 757,
                 DistrictId = 11,
                 NameEn = "Ambatenna"
             },
             new City
             {
                 Id = 758,
                 DistrictId = 11,
                 NameEn = "Ampitiya"
             },
             new City
             {
                 Id = 759,
                 DistrictId = 11,
                 NameEn = "Ankumbura"
             },
             new City
             {
                 Id = 760,
                 DistrictId = 11,
                 NameEn = "Atabage"
             },
             new City
             {
                 Id = 761,
                 DistrictId = 11,
                 NameEn = "Balana"
             },
             new City
             {
                 Id = 762,
                 DistrictId = 11,
                 NameEn = "Bambaragahaela"
             },
             new City
             {
                 Id = 763,
                 DistrictId = 11,
                 NameEn = "Batagolladeniya"
             },
             new City
             {
                 Id = 764,
                 DistrictId = 11,
                 NameEn = "Batugoda"
             },
             new City
             {
                 Id = 765,
                 DistrictId = 11,
                 NameEn = "Batumulla"
             },
             new City
             {
                 Id = 766,
                 DistrictId = 11,
                 NameEn = "Bawlana"
             },
             new City
             {
                 Id = 767,
                 DistrictId = 11,
                 NameEn = "Bopana"
             },
             new City
             {
                 Id = 768,
                 DistrictId = 11,
                 NameEn = "Danture"
             },
             new City
             {
                 Id = 769,
                 DistrictId = 11,
                 NameEn = "Dedunupitiya"
             },
             new City
             {
                 Id = 770,
                 DistrictId = 11,
                 NameEn = "Dekinda"
             },
             new City
             {
                 Id = 771,
                 DistrictId = 11,
                 NameEn = "Deltota"
             },
             new City
             {
                 Id = 772,
                 DistrictId = 11,
                 NameEn = "Divulankadawala"
             },
             new City
             {
                 Id = 773,
                 DistrictId = 11,
                 NameEn = "Dolapihilla"
             },
             new City
             {
                 Id = 774,
                 DistrictId = 11,
                 NameEn = "Dolosbage"
             },
             new City
             {
                 Id = 775,
                 DistrictId = 11,
                 NameEn = "Dunuwila"
             },
             new City
             {
                 Id = 776,
                 DistrictId = 11,
                 NameEn = "Etulgama"
             },
             new City
             {
                 Id = 777,
                 DistrictId = 11,
                 NameEn = "Galaboda"
             },
             new City
             {
                 Id = 778,
                 DistrictId = 11,
                 NameEn = "Galagedara"
             },
             new City
             {
                 Id = 779,
                 DistrictId = 11,
                 NameEn = "Galaha"
             },
             new City
             {
                 Id = 780,
                 DistrictId = 11,
                 NameEn = "Galhinna"
             },
             new City
             {
                 Id = 781,
                 DistrictId = 11,
                 NameEn = "Gampola"
             },
             new City
             {
                 Id = 782,
                 DistrictId = 11,
                 NameEn = "Gelioya"
             },
             new City
             {
                 Id = 783,
                 DistrictId = 11,
                 NameEn = "Godamunna"
             },
             new City
             {
                 Id = 784,
                 DistrictId = 11,
                 NameEn = "Gomagoda"
             },
             new City
             {
                 Id = 785,
                 DistrictId = 11,
                 NameEn = "Gonagantenna"
             },
             new City
             {
                 Id = 786,
                 DistrictId = 11,
                 NameEn = "Gonawalapatana"
             },
             new City
             {
                 Id = 787,
                 DistrictId = 11,
                 NameEn = "Gunnepana"
             },
             new City
             {
                 Id = 788,
                 DistrictId = 11,
                 NameEn = "Gurudeniya"
             },
             new City
             {
                 Id = 789,
                 DistrictId = 11,
                 NameEn = "Hakmana"
             },
             new City
             {
                 Id = 790,
                 DistrictId = 11,
                 NameEn = "Handaganawa"
             },
             new City
             {
                 Id = 791,
                 DistrictId = 11,
                 NameEn = "Handawalapitiya"
             },
             new City
             {
                 Id = 792,
                 DistrictId = 11,
                 NameEn = "Handessa"
             },
             new City
             {
                 Id = 793,
                 DistrictId = 11,
                 NameEn = "Hanguranketha"
             },
             new City
             {
                 Id = 794,
                 DistrictId = 11,
                 NameEn = "Harangalagama"
             },
             new City
             {
                 Id = 795,
                 DistrictId = 11,
                 NameEn = "Hataraliyadda"
             },
             new City
             {
                 Id = 796,
                 DistrictId = 11,
                 NameEn = "Hindagala"
             },
             new City
             {
                 Id = 797,
                 DistrictId = 11,
                 NameEn = "Hondiyadeniya"
             },
             new City
             {
                 Id = 798,
                 DistrictId = 11,
                 NameEn = "Hunnasgiriya"
             },
             new City
             {
                 Id = 799,
                 DistrictId = 11,
                 NameEn = "Inguruwatta"
             },
             new City
             {
                 Id = 800,
                 DistrictId = 11,
                 NameEn = "Jambugahapitiya"
             },
             new City
             {
                 Id = 801,
                 DistrictId = 11,
                 NameEn = "Kadugannawa"
             },
             new City
             {
                 Id = 802,
                 DistrictId = 11,
                 NameEn = "Kahataliyadda"
             },
             new City
             {
                 Id = 803,
                 DistrictId = 11,
                 NameEn = "Kalugala"
             },
             new City
             {
                 Id = 804,
                 DistrictId = 11,
                 NameEn = "Kandy"
             },
             new City
             {
                 Id = 805,
                 DistrictId = 11,
                 NameEn = "Kapuliyadde"
             },
             new City
             {
                 Id = 806,
                 DistrictId = 11,
                 NameEn = "Katugastota"
             },
             new City
             {
                 Id = 807,
                 DistrictId = 11,
                 NameEn = "Katukitula"
             },
             new City
             {
                 Id = 808,
                 DistrictId = 11,
                 NameEn = "Kelanigama"
             },
             new City
             {
                 Id = 809,
                 DistrictId = 11,
                 NameEn = "Kengalla"
             },
             new City
             {
                 Id = 810,
                 DistrictId = 11,
                 NameEn = "Ketaboola"
             },
             new City
             {
                 Id = 811,
                 DistrictId = 11,
                 NameEn = "Ketakumbura"
             },
             new City
             {
                 Id = 812,
                 DistrictId = 11,
                 NameEn = "Kobonila"
             },
             new City
             {
                 Id = 813,
                 DistrictId = 11,
                 NameEn = "Kolabissa"
             },
             new City
             {
                 Id = 814,
                 DistrictId = 11,
                 NameEn = "Kolongoda"
             },
             new City
             {
                 Id = 815,
                 DistrictId = 11,
                 NameEn = "Kulugammana"
             },
             new City
             {
                 Id = 816,
                 DistrictId = 11,
                 NameEn = "Kumbukkandura"
             },
             new City
             {
                 Id = 817,
                 DistrictId = 11,
                 NameEn = "Kumburegama"
             },
             new City
             {
                 Id = 818,
                 DistrictId = 11,
                 NameEn = "Kundasale"
             },
             new City
             {
                 Id = 819,
                 DistrictId = 11,
                 NameEn = "Leemagahakotuwa"
             },
             new City
             {
                 Id = 820,
                 DistrictId = 11,
                 NameEn = "lhala Kobbekaduwa"
             },
             new City
             {
                 Id = 821,
                 DistrictId = 11,
                 NameEn = "Lunugama"
             },
             new City
             {
                 Id = 822,
                 DistrictId = 11,
                 NameEn = "Lunuketiya Maditta"
             },
             new City
             {
                 Id = 823,
                 DistrictId = 11,
                 NameEn = "Madawala Bazaar"
             },
             new City
             {
                 Id = 824,
                 DistrictId = 11,
                 NameEn = "Madawalalanda"
             },
             new City
             {
                 Id = 825,
                 DistrictId = 11,
                 NameEn = "Madugalla"
             },
             new City
             {
                 Id = 826,
                 DistrictId = 11,
                 NameEn = "Madulkele"
             },
             new City
             {
                 Id = 827,
                 DistrictId = 11,
                 NameEn = "Mahadoraliyadda"
             },
             new City
             {
                 Id = 828,
                 DistrictId = 11,
                 NameEn = "Mahamedagama"
             },
             new City
             {
                 Id = 829,
                 DistrictId = 11,
                 NameEn = "Mahanagapura"
             },
             new City
             {
                 Id = 830,
                 DistrictId = 11,
                 NameEn = "Mailapitiya"
             },
             new City
             {
                 Id = 831,
                 DistrictId = 11,
                 NameEn = "Makkanigama"
             },
             new City
             {
                 Id = 832,
                 DistrictId = 11,
                 NameEn = "Makuldeniya"
             },
             new City
             {
                 Id = 833,
                 DistrictId = 11,
                 NameEn = "Mangalagama"
             },
             new City
             {
                 Id = 834,
                 DistrictId = 11,
                 NameEn = "Mapakanda"
             },
             new City
             {
                 Id = 835,
                 DistrictId = 11,
                 NameEn = "Marassana"
             },
             new City
             {
                 Id = 836,
                 DistrictId = 11,
                 NameEn = "Marymount Colony"
             },
             new City
             {
                 Id = 837,
                 DistrictId = 11,
                 NameEn = "Mawatura"
             },
             new City
             {
                 Id = 838,
                 DistrictId = 11,
                 NameEn = "Medamahanuwara"
             },
             new City
             {
                 Id = 839,
                 DistrictId = 11,
                 NameEn = "Medawala Harispattuwa"
             },
             new City
             {
                 Id = 840,
                 DistrictId = 11,
                 NameEn = "Meetalawa"
             },
             new City
             {
                 Id = 841,
                 DistrictId = 11,
                 NameEn = "Megoda Kalugamuwa"
             },
             new City
             {
                 Id = 842,
                 DistrictId = 11,
                 NameEn = "Menikdiwela"
             },
             new City
             {
                 Id = 843,
                 DistrictId = 11,
                 NameEn = "Menikhinna"
             },
             new City
             {
                 Id = 844,
                 DistrictId = 11,
                 NameEn = "Mimure"
             },
             new City
             {
                 Id = 845,
                 DistrictId = 11,
                 NameEn = "Minigamuwa"
             },
             new City
             {
                 Id = 846,
                 DistrictId = 11,
                 NameEn = "Minipe"
             },
             new City
             {
                 Id = 847,
                 DistrictId = 11,
                 NameEn = "Moragahapallama"
             },
             new City
             {
                 Id = 848,
                 DistrictId = 11,
                 NameEn = "Murutalawa"
             },
             new City
             {
                 Id = 849,
                 DistrictId = 11,
                 NameEn = "Muruthagahamulla"
             },
             new City
             {
                 Id = 850,
                 DistrictId = 11,
                 NameEn = "Nanuoya"
             },
             new City
             {
                 Id = 851,
                 DistrictId = 11,
                 NameEn = "Naranpanawa"
             },
             new City
             {
                 Id = 852,
                 DistrictId = 11,
                 NameEn = "Narawelpita"
             },
             new City
             {
                 Id = 853,
                 DistrictId = 11,
                 NameEn = "Nawalapitiya"
             },
             new City
             {
                 Id = 854,
                 DistrictId = 11,
                 NameEn = "Nawathispane"
             },
             new City
             {
                 Id = 855,
                 DistrictId = 11,
                 NameEn = "Nillambe"
             },
             new City
             {
                 Id = 856,
                 DistrictId = 11,
                 NameEn = "Nugaliyadda"
             },
             new City
             {
                 Id = 857,
                 DistrictId = 11,
                 NameEn = "Ovilikanda"
             },
             new City
             {
                 Id = 858,
                 DistrictId = 11,
                 NameEn = "Pallekotuwa"
             },
             new City
             {
                 Id = 859,
                 DistrictId = 11,
                 NameEn = "Panwilatenna"
             },
             new City
             {
                 Id = 860,
                 DistrictId = 11,
                 NameEn = "Paradeka"
             },
             new City
             {
                 Id = 861,
                 DistrictId = 11,
                 NameEn = "Pasbage"
             },
             new City
             {
                 Id = 862,
                 DistrictId = 11,
                 NameEn = "Pattitalawa"
             },
             new City
             {
                 Id = 863,
                 DistrictId = 11,
                 NameEn = "Peradeniya"
             },
             new City
             {
                 Id = 864,
                 DistrictId = 11,
                 NameEn = "Pilimatalawa"
             },
             new City
             {
                 Id = 865,
                 DistrictId = 11,
                 NameEn = "Poholiyadda"
             },
             new City
             {
                 Id = 866,
                 DistrictId = 11,
                 NameEn = "Pubbiliya"
             },
             new City
             {
                 Id = 867,
                 DistrictId = 11,
                 NameEn = "Pupuressa"
             },
             new City
             {
                 Id = 868,
                 DistrictId = 11,
                 NameEn = "Pussellawa"
             },
             new City
             {
                 Id = 869,
                 DistrictId = 11,
                 NameEn = "Putuhapuwa"
             },
             new City
             {
                 Id = 870,
                 DistrictId = 11,
                 NameEn = "Rajawella"
             },
             new City
             {
                 Id = 871,
                 DistrictId = 11,
                 NameEn = "Rambukpitiya"
             },
             new City
             {
                 Id = 872,
                 DistrictId = 11,
                 NameEn = "Rambukwella"
             },
             new City
             {
                 Id = 873,
                 DistrictId = 11,
                 NameEn = "Rangala"
             },
             new City
             {
                 Id = 874,
                 DistrictId = 11,
                 NameEn = "Rantembe"
             },
             new City
             {
                 Id = 875,
                 DistrictId = 11,
                 NameEn = "Sangarajapura"
             },
             new City
             {
                 Id = 876,
                 DistrictId = 11,
                 NameEn = "Senarathwela"
             },
             new City
             {
                 Id = 877,
                 DistrictId = 11,
                 NameEn = "Talatuoya"
             },
             new City
             {
                 Id = 878,
                 DistrictId = 11,
                 NameEn = "Teldeniya"
             },
             new City
             {
                 Id = 879,
                 DistrictId = 11,
                 NameEn = "Tennekumbura"
             },
             new City
             {
                 Id = 880,
                 DistrictId = 11,
                 NameEn = "Uda Peradeniya"
             },
             new City
             {
                 Id = 881,
                 DistrictId = 11,
                 NameEn = "Udahentenna"
             },
             new City
             {
                 Id = 882,
                 DistrictId = 11,
                 NameEn = "Udatalawinna"
             },
             new City
             {
                 Id = 883,
                 DistrictId = 11,
                 NameEn = "Udispattuwa"
             },
             new City
             {
                 Id = 884,
                 DistrictId = 11,
                 NameEn = "Ududumbara"
             },
             new City
             {
                 Id = 885,
                 DistrictId = 11,
                 NameEn = "Uduwahinna"
             },
             new City
             {
                 Id = 886,
                 DistrictId = 11,
                 NameEn = "Uduwela"
             },
             new City
             {
                 Id = 887,
                 DistrictId = 11,
                 NameEn = "Ulapane"
             },
             new City
             {
                 Id = 888,
                 DistrictId = 11,
                 NameEn = "Unuwinna"
             },
             new City
             {
                 Id = 889,
                 DistrictId = 11,
                 NameEn = "Velamboda"
             },
             new City
             {
                 Id = 890,
                 DistrictId = 11,
                 NameEn = "Watagoda"
             },
             new City
             {
                 Id = 891,
                 DistrictId = 11,
                 NameEn = "Watagoda Harispattuwa"
             },
             new City
             {
                 Id = 892,
                 DistrictId = 11,
                 NameEn = "Wattappola"
             },
             new City
             {
                 Id = 893,
                 DistrictId = 11,
                 NameEn = "Weligampola"
             },
             new City
             {
                 Id = 894,
                 DistrictId = 11,
                 NameEn = "Wendaruwa"
             },
             new City
             {
                 Id = 895,
                 DistrictId = 11,
                 NameEn = "Weragantota"
             },
             new City
             {
                 Id = 896,
                 DistrictId = 11,
                 NameEn = "Werapitya"
             },
             new City
             {
                 Id = 897,
                 DistrictId = 11,
                 NameEn = "Werellagama"
             },
             new City
             {
                 Id = 898,
                 DistrictId = 11,
                 NameEn = "Wettawa"
             },
             new City
             {
                 Id = 899,
                 DistrictId = 11,
                 NameEn = "Yahalatenna"
             },
             new City
             {
                 Id = 900,
                 DistrictId = 11,
                 NameEn = "Yatihalagala"
             },
             new City
             {
                 Id = 901,
                 DistrictId = 12,
                 NameEn = "Alawala"
             },
             new City
             {
                 Id = 902,
                 DistrictId = 12,
                 NameEn = "Alawatura"
             },
             new City
             {
                 Id = 903,
                 DistrictId = 12,
                 NameEn = "Alawwa"
             },
             new City
             {
                 Id = 904,
                 DistrictId = 12,
                 NameEn = "Algama"
             },
             new City
             {
                 Id = 905,
                 DistrictId = 12,
                 NameEn = "Alutnuwara"
             },
             new City
             {
                 Id = 906,
                 DistrictId = 12,
                 NameEn = "Ambalakanda"
             },
             new City
             {
                 Id = 907,
                 DistrictId = 12,
                 NameEn = "Ambulugala"
             },
             new City
             {
                 Id = 908,
                 DistrictId = 12,
                 NameEn = "Amitirigala"
             },
             new City
             {
                 Id = 909,
                 DistrictId = 12,
                 NameEn = "Ampagala"
             },
             new City
             {
                 Id = 910,
                 DistrictId = 12,
                 NameEn = "Anhandiya"
             },
             new City
             {
                 Id = 911,
                 DistrictId = 12,
                 NameEn = "Anhettigama"
             },
             new City
             {
                 Id = 912,
                 DistrictId = 12,
                 NameEn = "Aranayaka"
             },
             new City
             {
                 Id = 913,
                 DistrictId = 12,
                 NameEn = "Aruggammana"
             },
             new City
             {
                 Id = 914,
                 DistrictId = 12,
                 NameEn = "Batuwita"
             },
             new City
             {
                 Id = 915,
                 DistrictId = 12,
                 NameEn = "Beligala(Sab)"
             },
             new City
             {
                 Id = 916,
                 DistrictId = 12,
                 NameEn = "Belihuloya"
             },
             new City
             {
                 Id = 917,
                 DistrictId = 12,
                 NameEn = "Berannawa"
             },
             new City
             {
                 Id = 918,
                 DistrictId = 12,
                 NameEn = "Bopitiya"
             },
             new City
             {
                 Id = 919,
                 DistrictId = 12,
                 NameEn = "Bopitiya (SAB)"
             },
             new City
             {
                 Id = 920,
                 DistrictId = 12,
                 NameEn = "Boralankada"
             },
             new City
             {
                 Id = 921,
                 DistrictId = 12,
                 NameEn = "Bossella"
             },
             new City
             {
                 Id = 922,
                 DistrictId = 12,
                 NameEn = "Bulathkohupitiya"
             },
             new City
             {
                 Id = 923,
                 DistrictId = 12,
                 NameEn = "Damunupola"
             },
             new City
             {
                 Id = 924,
                 DistrictId = 12,
                 NameEn = "Debathgama"
             },
             new City
             {
                 Id = 925,
                 DistrictId = 12,
                 NameEn = "Dedugala"
             },
             new City
             {
                 Id = 926,
                 DistrictId = 12,
                 NameEn = "Deewala Pallegama"
             },
             new City
             {
                 Id = 927,
                 DistrictId = 12,
                 NameEn = "Dehiowita"
             },
             new City
             {
                 Id = 928,
                 DistrictId = 12,
                 NameEn = "Deldeniya"
             },
             new City
             {
                 Id = 929,
                 DistrictId = 12,
                 NameEn = "Deloluwa"
             },
             new City
             {
                 Id = 930,
                 DistrictId = 12,
                 NameEn = "Deraniyagala"
             },
             new City
             {
                 Id = 931,
                 DistrictId = 12,
                 NameEn = "Dewalegama"
             },
             new City
             {
                 Id = 932,
                 DistrictId = 12,
                 NameEn = "Dewanagala"
             },
             new City
             {
                 Id = 933,
                 DistrictId = 12,
                 NameEn = "Dombemada"
             },
             new City
             {
                 Id = 934,
                 DistrictId = 12,
                 NameEn = "Dorawaka"
             },
             new City
             {
                 Id = 935,
                 DistrictId = 12,
                 NameEn = "Dunumala"
             },
             new City
             {
                 Id = 936,
                 DistrictId = 12,
                 NameEn = "Galapitamada"
             },
             new City
             {
                 Id = 937,
                 DistrictId = 12,
                 NameEn = "Galatara"
             },
             new City
             {
                 Id = 938,
                 DistrictId = 12,
                 NameEn = "Galigamuwa Town"
             },
             new City
             {
                 Id = 939,
                 DistrictId = 12,
                 NameEn = "Gallella"
             },
             new City
             {
                 Id = 940,
                 DistrictId = 12,
                 NameEn = "Galpatha(Sab)"
             },
             new City
             {
                 Id = 941,
                 DistrictId = 12,
                 NameEn = "Gantuna"
             },
             new City
             {
                 Id = 942,
                 DistrictId = 12,
                 NameEn = "Getahetta"
             },
             new City
             {
                 Id = 943,
                 DistrictId = 12,
                 NameEn = "Godagampola"
             },
             new City
             {
                 Id = 944,
                 DistrictId = 12,
                 NameEn = "Gonagala"
             },
             new City
             {
                 Id = 945,
                 DistrictId = 12,
                 NameEn = "Hakahinna"
             },
             new City
             {
                 Id = 946,
                 DistrictId = 12,
                 NameEn = "Hakbellawaka"
             },
             new City
             {
                 Id = 947,
                 DistrictId = 12,
                 NameEn = "Halloluwa"
             },
             new City
             {
                 Id = 948,
                 DistrictId = 12,
                 NameEn = "Hedunuwewa"
             },
             new City
             {
                 Id = 949,
                 DistrictId = 12,
                 NameEn = "Hemmatagama"
             },
             new City
             {
                 Id = 950,
                 DistrictId = 12,
                 NameEn = "Hewadiwela"
             },
             new City
             {
                 Id = 951,
                 DistrictId = 12,
                 NameEn = "Hingula"
             },
             new City
             {
                 Id = 952,
                 DistrictId = 12,
                 NameEn = "Hinguralakanda"
             },
             new City
             {
                 Id = 953,
                 DistrictId = 12,
                 NameEn = "Hingurana"
             },
             new City
             {
                 Id = 954,
                 DistrictId = 12,
                 NameEn = "Hiriwadunna"
             },
             new City
             {
                 Id = 955,
                 DistrictId = 12,
                 NameEn = "Ihala Walpola"
             },
             new City
             {
                 Id = 956,
                 DistrictId = 12,
                 NameEn = "Ihalagama"
             },
             new City
             {
                 Id = 957,
                 DistrictId = 12,
                 NameEn = "Imbulana"
             },
             new City
             {
                 Id = 958,
                 DistrictId = 12,
                 NameEn = "Imbulgasdeniya"
             },
             new City
             {
                 Id = 959,
                 DistrictId = 12,
                 NameEn = "Kabagamuwa"
             },
             new City
             {
                 Id = 960,
                 DistrictId = 12,
                 NameEn = "Kahapathwala"
             },
             new City
             {
                 Id = 961,
                 DistrictId = 12,
                 NameEn = "Kandaketya"
             },
             new City
             {
                 Id = 962,
                 DistrictId = 12,
                 NameEn = "Kannattota"
             },
             new City
             {
                 Id = 963,
                 DistrictId = 12,
                 NameEn = "Karagahinna"
             },
             new City
             {
                 Id = 964,
                 DistrictId = 12,
                 NameEn = "Kegalle"
             },
             new City
             {
                 Id = 965,
                 DistrictId = 12,
                 NameEn = "Kehelpannala"
             },
             new City
             {
                 Id = 966,
                 DistrictId = 12,
                 NameEn = "Ketawala Leula"
             },
             new City
             {
                 Id = 967,
                 DistrictId = 12,
                 NameEn = "Kitulgala"
             },
             new City
             {
                 Id = 968,
                 DistrictId = 12,
                 NameEn = "Kondeniya"
             },
             new City
             {
                 Id = 969,
                 DistrictId = 12,
                 NameEn = "Kotiyakumbura"
             },
             new City
             {
                 Id = 970,
                 DistrictId = 12,
                 NameEn = "Lewangama"
             },
             new City
             {
                 Id = 971,
                 DistrictId = 12,
                 NameEn = "Mahabage"
             },
             new City
             {
                 Id = 972,
                 DistrictId = 12,
                 NameEn = "Makehelwala"
             },
             new City
             {
                 Id = 973,
                 DistrictId = 12,
                 NameEn = "Malalpola"
             },
             new City
             {
                 Id = 974,
                 DistrictId = 12,
                 NameEn = "Maldeniya"
             },
             new City
             {
                 Id = 975,
                 DistrictId = 12,
                 NameEn = "Maliboda"
             },
             new City
             {
                 Id = 976,
                 DistrictId = 12,
                 NameEn = "Maliyadda"
             },
             new City
             {
                 Id = 977,
                 DistrictId = 12,
                 NameEn = "Malmaduwa"
             },
             new City
             {
                 Id = 978,
                 DistrictId = 12,
                 NameEn = "Marapana"
             },
             new City
             {
                 Id = 979,
                 DistrictId = 12,
                 NameEn = "Mawanella"
             },
             new City
             {
                 Id = 980,
                 DistrictId = 12,
                 NameEn = "Meetanwala"
             },
             new City
             {
                 Id = 981,
                 DistrictId = 12,
                 NameEn = "Migastenna Sabara"
             },
             new City
             {
                 Id = 982,
                 DistrictId = 12,
                 NameEn = "Miyanawita"
             },
             new City
             {
                 Id = 983,
                 DistrictId = 12,
                 NameEn = "Molagoda"
             },
             new City
             {
                 Id = 984,
                 DistrictId = 12,
                 NameEn = "Morontota"
             },
             new City
             {
                 Id = 985,
                 DistrictId = 12,
                 NameEn = "Narangala"
             },
             new City
             {
                 Id = 986,
                 DistrictId = 12,
                 NameEn = "Narangoda"
             },
             new City
             {
                 Id = 987,
                 DistrictId = 12,
                 NameEn = "Nattarampotha"
             },
             new City
             {
                 Id = 988,
                 DistrictId = 12,
                 NameEn = "Nelundeniya"
             },
             new City
             {
                 Id = 989,
                 DistrictId = 12,
                 NameEn = "Niyadurupola"
             },
             new City
             {
                 Id = 990,
                 DistrictId = 12,
                 NameEn = "Noori"
             },
             new City
             {
                 Id = 991,
                 DistrictId = 12,
                 NameEn = "Pannila"
             },
             new City
             {
                 Id = 992,
                 DistrictId = 12,
                 NameEn = "Pattampitiya"
             },
             new City
             {
                 Id = 993,
                 DistrictId = 12,
                 NameEn = "Pilawala"
             },
             new City
             {
                 Id = 994,
                 DistrictId = 12,
                 NameEn = "Pothukoladeniya"
             },
             new City
             {
                 Id = 995,
                 DistrictId = 12,
                 NameEn = "Puswelitenna"
             },
             new City
             {
                 Id = 996,
                 DistrictId = 12,
                 NameEn = "Rambukkana"
             },
             new City
             {
                 Id = 997,
                 DistrictId = 12,
                 NameEn = "Rilpola"
             },
             new City
             {
                 Id = 998,
                 DistrictId = 12,
                 NameEn = "Rukmale"
             },
             new City
             {
                 Id = 999,
                 DistrictId = 12,
                 NameEn = "Ruwanwella"
             },
             new City
             {
                 Id = 1000,
                 DistrictId = 12,
                 NameEn = "Samanalawewa"
             },
             new City
             {
                 Id = 1001,
                 DistrictId = 12,
                 NameEn = "Seaforth Colony"
             },
             new City
             {
                 Id = 1002,
                 DistrictId = 5,
                 NameEn = "Colombo 2"
             },
             new City
             {
                 Id = 1003,
                 DistrictId = 12,
                 NameEn = "Spring Valley"
             },
             new City
             {
                 Id = 1004,
                 DistrictId = 12,
                 NameEn = "Talgaspitiya"
             },
             new City
             {
                 Id = 1005,
                 DistrictId = 12,
                 NameEn = "Teligama"
             },
             new City
             {
                 Id = 1006,
                 DistrictId = 12,
                 NameEn = "Tholangamuwa"
             },
             new City
             {
                 Id = 1007,
                 DistrictId = 12,
                 NameEn = "Thotawella"
             },
             new City
             {
                 Id = 1008,
                 DistrictId = 12,
                 NameEn = "Udaha Hawupe"
             },
             new City
             {
                 Id = 1009,
                 DistrictId = 12,
                 NameEn = "Udapotha"
             },
             new City
             {
                 Id = 1010,
                 DistrictId = 12,
                 NameEn = "Uduwa"
             },
             new City
             {
                 Id = 1011,
                 DistrictId = 12,
                 NameEn = "Undugoda"
             },
             new City
             {
                 Id = 1012,
                 DistrictId = 12,
                 NameEn = "Ussapitiya"
             },
             new City
             {
                 Id = 1013,
                 DistrictId = 12,
                 NameEn = "Wahakula"
             },
             new City
             {
                 Id = 1014,
                 DistrictId = 12,
                 NameEn = "Waharaka"
             },
             new City
             {
                 Id = 1015,
                 DistrictId = 12,
                 NameEn = "Wanaluwewa"
             },
             new City
             {
                 Id = 1016,
                 DistrictId = 12,
                 NameEn = "Warakapola"
             },
             new City
             {
                 Id = 1017,
                 DistrictId = 12,
                 NameEn = "Watura"
             },
             new City
             {
                 Id = 1018,
                 DistrictId = 12,
                 NameEn = "Weeoya"
             },
             new City
             {
                 Id = 1019,
                 DistrictId = 12,
                 NameEn = "Wegalla"
             },
             new City
             {
                 Id = 1020,
                 DistrictId = 12,
                 NameEn = "Weligalla"
             },
             new City
             {
                 Id = 1021,
                 DistrictId = 12,
                 NameEn = "Welihelatenna"
             },
             new City
             {
                 Id = 1022,
                 DistrictId = 12,
                 NameEn = "Wewelwatta"
             },
             new City
             {
                 Id = 1023,
                 DistrictId = 12,
                 NameEn = "Yatagama"
             },
             new City
             {
                 Id = 1024,
                 DistrictId = 12,
                 NameEn = "Yatapana"
             },
             new City
             {
                 Id = 1025,
                 DistrictId = 12,
                 NameEn = "Yatiyantota"
             },
             new City
             {
                 Id = 1026,
                 DistrictId = 12,
                 NameEn = "Yattogoda"
             },
             new City
             {
                 Id = 1027,
                 DistrictId = 13,
                 NameEn = "Kandavalai"
             },
             new City
             {
                 Id = 1028,
                 DistrictId = 13,
                 NameEn = "Karachchi"
             },
             new City
             {
                 Id = 1029,
                 DistrictId = 13,
                 NameEn = "Kilinochchi"
             },
             new City
             {
                 Id = 1030,
                 DistrictId = 13,
                 NameEn = "Pachchilaipalli"
             },
             new City
             {
                 Id = 1031,
                 DistrictId = 13,
                 NameEn = "Poonakary"
             },
             new City
             {
                 Id = 1032,
                 DistrictId = 14,
                 NameEn = "Akurana"
             },
             new City
             {
                 Id = 1033,
                 DistrictId = 14,
                 NameEn = "Alahengama"
             },
             new City
             {
                 Id = 1034,
                 DistrictId = 14,
                 NameEn = "Alahitiyawa"
             },
             new City
             {
                 Id = 1035,
                 DistrictId = 14,
                 NameEn = "Ambakote"
             },
             new City
             {
                 Id = 1036,
                 DistrictId = 14,
                 NameEn = "Ambanpola"
             },
             new City
             {
                 Id = 1037,
                 DistrictId = 14,
                 NameEn = "Andiyagala"
             },
             new City
             {
                 Id = 1038,
                 DistrictId = 14,
                 NameEn = "Anukkane"
             },
             new City
             {
                 Id = 1039,
                 DistrictId = 14,
                 NameEn = "Aragoda"
             },
             new City
             {
                 Id = 1040,
                 DistrictId = 14,
                 NameEn = "Ataragalla"
             },
             new City
             {
                 Id = 1041,
                 DistrictId = 14,
                 NameEn = "Awulegama"
             },
             new City
             {
                 Id = 1042,
                 DistrictId = 14,
                 NameEn = "Balalla"
             },
             new City
             {
                 Id = 1043,
                 DistrictId = 14,
                 NameEn = "Bamunukotuwa"
             },
             new City
             {
                 Id = 1044,
                 DistrictId = 14,
                 NameEn = "Bandara Koswatta"
             },
             new City
             {
                 Id = 1045,
                 DistrictId = 14,
                 NameEn = "Bingiriya"
             },
             new City
             {
                 Id = 1046,
                 DistrictId = 14,
                 NameEn = "Bogamulla"
             },
             new City
             {
                 Id = 1047,
                 DistrictId = 14,
                 NameEn = "Boraluwewa"
             },
             new City
             {
                 Id = 1048,
                 DistrictId = 14,
                 NameEn = "Boyagane"
             },
             new City
             {
                 Id = 1049,
                 DistrictId = 14,
                 NameEn = "Bujjomuwa"
             },
             new City
             {
                 Id = 1050,
                 DistrictId = 14,
                 NameEn = "Buluwala"
             },
             new City
             {
                 Id = 1051,
                 DistrictId = 14,
                 NameEn = "Dadayamtalawa"
             },
             new City
             {
                 Id = 1052,
                 DistrictId = 14,
                 NameEn = "Dambadeniya"
             },
             new City
             {
                 Id = 1053,
                 DistrictId = 14,
                 NameEn = "Daraluwa"
             },
             new City
             {
                 Id = 1054,
                 DistrictId = 14,
                 NameEn = "Deegalla"
             },
             new City
             {
                 Id = 1055,
                 DistrictId = 14,
                 NameEn = "Demataluwa"
             },
             new City
             {
                 Id = 1056,
                 DistrictId = 14,
                 NameEn = "Demuwatha"
             },
             new City
             {
                 Id = 1057,
                 DistrictId = 14,
                 NameEn = "Diddeniya"
             },
             new City
             {
                 Id = 1058,
                 DistrictId = 14,
                 NameEn = "Digannewa"
             },
             new City
             {
                 Id = 1059,
                 DistrictId = 14,
                 NameEn = "Divullegoda"
             },
             new City
             {
                 Id = 1060,
                 DistrictId = 14,
                 NameEn = "Diyasenpura"
             },
             new City
             {
                 Id = 1061,
                 DistrictId = 14,
                 NameEn = "Dodangaslanda"
             },
             new City
             {
                 Id = 1062,
                 DistrictId = 14,
                 NameEn = "Doluwa"
             },
             new City
             {
                 Id = 1063,
                 DistrictId = 14,
                 NameEn = "Doragamuwa"
             },
             new City
             {
                 Id = 1064,
                 DistrictId = 14,
                 NameEn = "Doratiyawa"
             },
             new City
             {
                 Id = 1065,
                 DistrictId = 14,
                 NameEn = "Dunumadalawa"
             },
             new City
             {
                 Id = 1066,
                 DistrictId = 14,
                 NameEn = "Dunuwilapitiya"
             },
             new City
             {
                 Id = 1067,
                 DistrictId = 14,
                 NameEn = "Ehetuwewa"
             },
             new City
             {
                 Id = 1068,
                 DistrictId = 14,
                 NameEn = "Elibichchiya"
             },
             new City
             {
                 Id = 1069,
                 DistrictId = 14,
                 NameEn = "Embogama"
             },
             new City
             {
                 Id = 1070,
                 DistrictId = 14,
                 NameEn = "Etungahakotuwa"
             },
             new City
             {
                 Id = 1071,
                 DistrictId = 14,
                 NameEn = "Galadivulwewa"
             },
             new City
             {
                 Id = 1072,
                 DistrictId = 14,
                 NameEn = "Galgamuwa"
             },
             new City
             {
                 Id = 1073,
                 DistrictId = 14,
                 NameEn = "Gallellagama"
             },
             new City
             {
                 Id = 1074,
                 DistrictId = 14,
                 NameEn = "Gallewa"
             },
             new City
             {
                 Id = 1075,
                 DistrictId = 14,
                 NameEn = "Ganegoda"
             },
             new City
             {
                 Id = 1076,
                 DistrictId = 14,
                 NameEn = "Girathalana"
             },
             new City
             {
                 Id = 1077,
                 DistrictId = 14,
                 NameEn = "Gokaralla"
             },
             new City
             {
                 Id = 1078,
                 DistrictId = 14,
                 NameEn = "Gonawila"
             },
             new City
             {
                 Id = 1079,
                 DistrictId = 14,
                 NameEn = "Halmillawewa"
             },
             new City
             {
                 Id = 1080,
                 DistrictId = 14,
                 NameEn = "Handungamuwa"
             },
             new City
             {
                 Id = 1081,
                 DistrictId = 14,
                 NameEn = "Harankahawa"
             },
             new City
             {
                 Id = 1082,
                 DistrictId = 14,
                 NameEn = "Helamada"
             },
             new City
             {
                 Id = 1083,
                 DistrictId = 14,
                 NameEn = "Hengamuwa"
             },
             new City
             {
                 Id = 1084,
                 DistrictId = 14,
                 NameEn = "Hettipola"
             },
             new City
             {
                 Id = 1085,
                 DistrictId = 14,
                 NameEn = "Hewainna"
             },
             new City
             {
                 Id = 1086,
                 DistrictId = 14,
                 NameEn = "Hilogama"
             },
             new City
             {
                 Id = 1087,
                 DistrictId = 14,
                 NameEn = "Hindagolla"
             },
             new City
             {
                 Id = 1088,
                 DistrictId = 14,
                 NameEn = "Hiriyala Lenawa"
             },
             new City
             {
                 Id = 1089,
                 DistrictId = 14,
                 NameEn = "Hiruwalpola"
             },
             new City
             {
                 Id = 1090,
                 DistrictId = 14,
                 NameEn = "Horambawa"
             },
             new City
             {
                 Id = 1091,
                 DistrictId = 14,
                 NameEn = "Hulogedara"
             },
             new City
             {
                 Id = 1092,
                 DistrictId = 14,
                 NameEn = "Hulugalla"
             },
             new City
             {
                 Id = 1093,
                 DistrictId = 14,
                 NameEn = "Ihala Gomugomuwa"
             },
             new City
             {
                 Id = 1094,
                 DistrictId = 14,
                 NameEn = "Ihala Katugampala"
             },
             new City
             {
                 Id = 1095,
                 DistrictId = 14,
                 NameEn = "Indulgodakanda"
             },
             new City
             {
                 Id = 1096,
                 DistrictId = 14,
                 NameEn = "Ithanawatta"
             },
             new City
             {
                 Id = 1097,
                 DistrictId = 14,
                 NameEn = "Kadigawa"
             },
             new City
             {
                 Id = 1098,
                 DistrictId = 14,
                 NameEn = "Kalankuttiya"
             },
             new City
             {
                 Id = 1099,
                 DistrictId = 14,
                 NameEn = "Kalatuwawa"
             },
             new City
             {
                 Id = 1100,
                 DistrictId = 14,
                 NameEn = "Kalugamuwa"
             },
             new City
             {
                 Id = 1101,
                 DistrictId = 14,
                 NameEn = "Kanadeniyawala"
             },
             new City
             {
                 Id = 1102,
                 DistrictId = 14,
                 NameEn = "Kanattewewa"
             },
             new City
             {
                 Id = 1103,
                 DistrictId = 14,
                 NameEn = "Kandegedara"
             },
             new City
             {
                 Id = 1104,
                 DistrictId = 14,
                 NameEn = "Karagahagedara"
             },
             new City
             {
                 Id = 1105,
                 DistrictId = 14,
                 NameEn = "Karambe"
             },
             new City
             {
                 Id = 1106,
                 DistrictId = 14,
                 NameEn = "Katiyawa"
             },
             new City
             {
                 Id = 1107,
                 DistrictId = 14,
                 NameEn = "Katupota"
             },
             new City
             {
                 Id = 1108,
                 DistrictId = 14,
                 NameEn = "Kawudulla"
             },
             new City
             {
                 Id = 1109,
                 DistrictId = 14,
                 NameEn = "Kawuduluwewa Stagell"
             },
             new City
             {
                 Id = 1110,
                 DistrictId = 14,
                 NameEn = "Kekunagolla"
             },
             new City
             {
                 Id = 1111,
                 DistrictId = 14,
                 NameEn = "Keppitiwalana"
             },
             new City
             {
                 Id = 1112,
                 DistrictId = 14,
                 NameEn = "Kimbulwanaoya"
             },
             new City
             {
                 Id = 1113,
                 DistrictId = 14,
                 NameEn = "Kirimetiyawa"
             },
             new City
             {
                 Id = 1114,
                 DistrictId = 14,
                 NameEn = "Kirindawa"
             },
             new City
             {
                 Id = 1115,
                 DistrictId = 14,
                 NameEn = "Kirindigalla"
             },
             new City
             {
                 Id = 1116,
                 DistrictId = 14,
                 NameEn = "Kithalawa"
             },
             new City
             {
                 Id = 1117,
                 DistrictId = 14,
                 NameEn = "Kitulwala"
             },
             new City
             {
                 Id = 1118,
                 DistrictId = 14,
                 NameEn = "Kobeigane"
             },
             new City
             {
                 Id = 1119,
                 DistrictId = 14,
                 NameEn = "Kohilagedara"
             },
             new City
             {
                 Id = 1120,
                 DistrictId = 14,
                 NameEn = "Konwewa"
             },
             new City
             {
                 Id = 1121,
                 DistrictId = 14,
                 NameEn = "Kosdeniya"
             },
             new City
             {
                 Id = 1122,
                 DistrictId = 14,
                 NameEn = "Kosgolla"
             },
             new City
             {
                 Id = 1123,
                 DistrictId = 14,
                 NameEn = "Kotagala"
             },
             new City
             {
                 Id = 1124,
                 DistrictId = 5,
                 NameEn = "Colombo 13"
             },
             new City
             {
                 Id = 1125,
                 DistrictId = 14,
                 NameEn = "Kotawehera"
             },
             new City
             {
                 Id = 1126,
                 DistrictId = 14,
                 NameEn = "Kudagalgamuwa"
             },
             new City
             {
                 Id = 1127,
                 DistrictId = 14,
                 NameEn = "Kudakatnoruwa"
             },
             new City
             {
                 Id = 1128,
                 DistrictId = 14,
                 NameEn = "Kuliyapitiya"
             },
             new City
             {
                 Id = 1129,
                 DistrictId = 14,
                 NameEn = "Kumaragama"
             },
             new City
             {
                 Id = 1130,
                 DistrictId = 14,
                 NameEn = "Kumbukgeta"
             },
             new City
             {
                 Id = 1131,
                 DistrictId = 14,
                 NameEn = "Kumbukwewa"
             },
             new City
             {
                 Id = 1132,
                 DistrictId = 14,
                 NameEn = "Kuratihena"
             },
             new City
             {
                 Id = 1133,
                 DistrictId = 14,
                 NameEn = "Kurunegala"
             },
             new City
             {
                 Id = 1134,
                 DistrictId = 14,
                 NameEn = "lbbagamuwa"
             },
             new City
             {
                 Id = 1135,
                 DistrictId = 14,
                 NameEn = "lhala Kadigamuwa"
             },
             new City
             {
                 Id = 1136,
                 DistrictId = 14,
                 NameEn = "Lihiriyagama"
             },
             new City
             {
                 Id = 1137,
                 DistrictId = 14,
                 NameEn = "lllagolla"
             },
             new City
             {
                 Id = 1138,
                 DistrictId = 14,
                 NameEn = "llukhena"
             },
             new City
             {
                 Id = 1139,
                 DistrictId = 14,
                 NameEn = "Lonahettiya"
             },
             new City
             {
                 Id = 1140,
                 DistrictId = 14,
                 NameEn = "Madahapola"
             },
             new City
             {
                 Id = 1141,
                 DistrictId = 14,
                 NameEn = "Madakumburumulla"
             },
             new City
             {
                 Id = 1142,
                 DistrictId = 14,
                 NameEn = "Madalagama"
             },
             new City
             {
                 Id = 1143,
                 DistrictId = 14,
                 NameEn = "Madawala Ulpotha"
             },
             new City
             {
                 Id = 1144,
                 DistrictId = 14,
                 NameEn = "Maduragoda"
             },
             new City
             {
                 Id = 1145,
                 DistrictId = 14,
                 NameEn = "Maeliya"
             },
             new City
             {
                 Id = 1146,
                 DistrictId = 14,
                 NameEn = "Magulagama"
             },
             new City
             {
                 Id = 1147,
                 DistrictId = 14,
                 NameEn = "Maha Ambagaswewa"
             },
             new City
             {
                 Id = 1148,
                 DistrictId = 14,
                 NameEn = "Mahagalkadawala"
             },
             new City
             {
                 Id = 1149,
                 DistrictId = 14,
                 NameEn = "Mahagirilla"
             },
             new City
             {
                 Id = 1150,
                 DistrictId = 14,
                 NameEn = "Mahamukalanyaya"
             },
             new City
             {
                 Id = 1151,
                 DistrictId = 14,
                 NameEn = "Mahananneriya"
             },
             new City
             {
                 Id = 1152,
                 DistrictId = 14,
                 NameEn = "Mahapallegama"
             },
             new City
             {
                 Id = 1153,
                 DistrictId = 14,
                 NameEn = "Maharachchimulla"
             },
             new City
             {
                 Id = 1154,
                 DistrictId = 14,
                 NameEn = "Mahatalakolawewa"
             },
             new City
             {
                 Id = 1155,
                 DistrictId = 14,
                 NameEn = "Mahawewa"
             },
             new City
             {
                 Id = 1156,
                 DistrictId = 14,
                 NameEn = "Maho"
             },
             new City
             {
                 Id = 1157,
                 DistrictId = 14,
                 NameEn = "Makulewa"
             },
             new City
             {
                 Id = 1158,
                 DistrictId = 14,
                 NameEn = "Makulpotha"
             },
             new City
             {
                 Id = 1159,
                 DistrictId = 14,
                 NameEn = "Makulwewa"
             },
             new City
             {
                 Id = 1160,
                 DistrictId = 14,
                 NameEn = "Malagane"
             },
             new City
             {
                 Id = 1161,
                 DistrictId = 14,
                 NameEn = "Mandapola"
             },
             new City
             {
                 Id = 1162,
                 DistrictId = 14,
                 NameEn = "Maspotha"
             },
             new City
             {
                 Id = 1163,
                 DistrictId = 14,
                 NameEn = "Mawathagama"
             },
             new City
             {
                 Id = 1164,
                 DistrictId = 14,
                 NameEn = "Medirigiriya"
             },
             new City
             {
                 Id = 1165,
                 DistrictId = 14,
                 NameEn = "Medivawa"
             },
             new City
             {
                 Id = 1166,
                 DistrictId = 14,
                 NameEn = "Meegalawa"
             },
             new City
             {
                 Id = 1167,
                 DistrictId = 14,
                 NameEn = "Meegaswewa"
             },
             new City
             {
                 Id = 1168,
                 DistrictId = 14,
                 NameEn = "Meewellawa"
             },
             new City
             {
                 Id = 1169,
                 DistrictId = 14,
                 NameEn = "Melsiripura"
             },
             new City
             {
                 Id = 1170,
                 DistrictId = 14,
                 NameEn = "Metikumbura"
             },
             new City
             {
                 Id = 1171,
                 DistrictId = 14,
                 NameEn = "Metiyagane"
             },
             new City
             {
                 Id = 1172,
                 DistrictId = 14,
                 NameEn = "Minhettiya"
             },
             new City
             {
                 Id = 1173,
                 DistrictId = 14,
                 NameEn = "Minuwangete"
             },
             new City
             {
                 Id = 1174,
                 DistrictId = 14,
                 NameEn = "Mirihanagama"
             },
             new City
             {
                 Id = 1175,
                 DistrictId = 14,
                 NameEn = "Monnekulama"
             },
             new City
             {
                 Id = 1176,
                 DistrictId = 14,
                 NameEn = "Moragane"
             },
             new City
             {
                 Id = 1177,
                 DistrictId = 14,
                 NameEn = "Moragollagama"
             },
             new City
             {
                 Id = 1178,
                 DistrictId = 14,
                 NameEn = "Morathiha"
             },
             new City
             {
                 Id = 1179,
                 DistrictId = 14,
                 NameEn = "Munamaldeniya"
             },
             new City
             {
                 Id = 1180,
                 DistrictId = 14,
                 NameEn = "Muruthenge"
             },
             new City
             {
                 Id = 1181,
                 DistrictId = 14,
                 NameEn = "Mutugala"
             },
             new City
             {
                 Id = 1182,
                 DistrictId = 14,
                 NameEn = "Nabadewa"
             },
             new City
             {
                 Id = 1183,
                 DistrictId = 14,
                 NameEn = "Nagollagama"
             },
             new City
             {
                 Id = 1184,
                 DistrictId = 14,
                 NameEn = "Nagollagoda"
             },
             new City
             {
                 Id = 1185,
                 DistrictId = 14,
                 NameEn = "Nakkawatta"
             },
             new City
             {
                 Id = 1186,
                 DistrictId = 14,
                 NameEn = "Narammala"
             },
             new City
             {
                 Id = 1187,
                 DistrictId = 14,
                 NameEn = "Nawasenapura"
             },
             new City
             {
                 Id = 1188,
                 DistrictId = 14,
                 NameEn = "Nawatalwatta"
             },
             new City
             {
                 Id = 1189,
                 DistrictId = 14,
                 NameEn = "Nelliya"
             },
             new City
             {
                 Id = 1190,
                 DistrictId = 14,
                 NameEn = "Nikaweratiya"
             },
             new City
             {
                 Id = 1191,
                 DistrictId = 14,
                 NameEn = "Nugagolla"
             },
             new City
             {
                 Id = 1192,
                 DistrictId = 14,
                 NameEn = "Nugawela"
             },
             new City
             {
                 Id = 1193,
                 DistrictId = 14,
                 NameEn = "Padeniya"
             },
             new City
             {
                 Id = 1194,
                 DistrictId = 14,
                 NameEn = "Padiwela"
             },
             new City
             {
                 Id = 1195,
                 DistrictId = 14,
                 NameEn = "Pahalagiribawa"
             },
             new City
             {
                 Id = 1196,
                 DistrictId = 14,
                 NameEn = "Pahamune"
             },
             new City
             {
                 Id = 1197,
                 DistrictId = 14,
                 NameEn = "Palagala"
             },
             new City
             {
                 Id = 1198,
                 DistrictId = 14,
                 NameEn = "Palapathwela"
             },
             new City
             {
                 Id = 1199,
                 DistrictId = 14,
                 NameEn = "Palaviya"
             },
             new City
             {
                 Id = 1200,
                 DistrictId = 14,
                 NameEn = "Pallewela"
             },
             new City
             {
                 Id = 1201,
                 DistrictId = 14,
                 NameEn = "Palukadawala"
             },
             new City
             {
                 Id = 1202,
                 DistrictId = 14,
                 NameEn = "Panadaragama"
             },
             new City
             {
                 Id = 1203,
                 DistrictId = 14,
                 NameEn = "Panagamuwa"
             },
             new City
             {
                 Id = 1204,
                 DistrictId = 14,
                 NameEn = "Panaliya"
             },
             new City
             {
                 Id = 1205,
                 DistrictId = 14,
                 NameEn = "Panapitiya"
             },
             new City
             {
                 Id = 1206,
                 DistrictId = 14,
                 NameEn = "Panliyadda"
             },
             new City
             {
                 Id = 1207,
                 DistrictId = 14,
                 NameEn = "Pansiyagama"
             },
             new City
             {
                 Id = 1208,
                 DistrictId = 14,
                 NameEn = "Parape"
             },
             new City
             {
                 Id = 1209,
                 DistrictId = 14,
                 NameEn = "Pathanewatta"
             },
             new City
             {
                 Id = 1210,
                 DistrictId = 14,
                 NameEn = "Pattiya Watta"
             },
             new City
             {
                 Id = 1211,
                 DistrictId = 14,
                 NameEn = "Perakanatta"
             },
             new City
             {
                 Id = 1212,
                 DistrictId = 14,
                 NameEn = "Periyakadneluwa"
             },
             new City
             {
                 Id = 1213,
                 DistrictId = 14,
                 NameEn = "Pihimbiya Ratmale"
             },
             new City
             {
                 Id = 1214,
                 DistrictId = 14,
                 NameEn = "Pihimbuwa"
             },
             new City
             {
                 Id = 1215,
                 DistrictId = 14,
                 NameEn = "Pilessa"
             },
             new City
             {
                 Id = 1216,
                 DistrictId = 14,
                 NameEn = "Polgahawela"
             },
             new City
             {
                 Id = 1217,
                 DistrictId = 14,
                 NameEn = "Polgolla"
             },
             new City
             {
                 Id = 1218,
                 DistrictId = 14,
                 NameEn = "Polpitigama"
             },
             new City
             {
                 Id = 1219,
                 DistrictId = 14,
                 NameEn = "Pothuhera"
             },
             new City
             {
                 Id = 1220,
                 DistrictId = 14,
                 NameEn = "Pothupitiya"
             },
             new City
             {
                 Id = 1221,
                 DistrictId = 14,
                 NameEn = "Pujapitiya"
             },
             new City
             {
                 Id = 1222,
                 DistrictId = 14,
                 NameEn = "Rakwana"
             },
             new City
             {
                 Id = 1223,
                 DistrictId = 14,
                 NameEn = "Ranorawa"
             },
             new City
             {
                 Id = 1224,
                 DistrictId = 14,
                 NameEn = "Rathukohodigala"
             },
             new City
             {
                 Id = 1225,
                 DistrictId = 14,
                 NameEn = "Ridibendiella"
             },
             new City
             {
                 Id = 1226,
                 DistrictId = 14,
                 NameEn = "Ridigama"
             },
             new City
             {
                 Id = 1227,
                 DistrictId = 14,
                 NameEn = "Saliya Asokapura"
             },
             new City
             {
                 Id = 1228,
                 DistrictId = 14,
                 NameEn = "Sandalankawa"
             },
             new City
             {
                 Id = 1229,
                 DistrictId = 14,
                 NameEn = "Sevanapitiya"
             },
             new City
             {
                 Id = 1230,
                 DistrictId = 14,
                 NameEn = "Sirambiadiya"
             },
             new City
             {
                 Id = 1231,
                 DistrictId = 14,
                 NameEn = "Sirisetagama"
             },
             new City
             {
                 Id = 1232,
                 DistrictId = 14,
                 NameEn = "Siyambalangamuwa"
             },
             new City
             {
                 Id = 1233,
                 DistrictId = 14,
                 NameEn = "Siyambalawewa"
             },
             new City
             {
                 Id = 1234,
                 DistrictId = 14,
                 NameEn = "Solepura"
             },
             new City
             {
                 Id = 1235,
                 DistrictId = 14,
                 NameEn = "Solewewa"
             },
             new City
             {
                 Id = 1236,
                 DistrictId = 14,
                 NameEn = "Sunandapura"
             },
             new City
             {
                 Id = 1237,
                 DistrictId = 14,
                 NameEn = "Talawattegedara"
             },
             new City
             {
                 Id = 1238,
                 DistrictId = 14,
                 NameEn = "Tambutta"
             },
             new City
             {
                 Id = 1239,
                 DistrictId = 14,
                 NameEn = "Tennepanguwa"
             },
             new City
             {
                 Id = 1240,
                 DistrictId = 14,
                 NameEn = "Thalahitimulla"
             },
             new City
             {
                 Id = 1241,
                 DistrictId = 14,
                 NameEn = "Thalakolawewa"
             },
             new City
             {
                 Id = 1242,
                 DistrictId = 14,
                 NameEn = "Thalwita"
             },
             new City
             {
                 Id = 1243,
                 DistrictId = 14,
                 NameEn = "Tharana Udawela"
             },
             new City
             {
                 Id = 1244,
                 DistrictId = 14,
                 NameEn = "Thimbiriyawa"
             },
             new City
             {
                 Id = 1245,
                 DistrictId = 14,
                 NameEn = "Tisogama"
             },
             new City
             {
                 Id = 1246,
                 DistrictId = 14,
                 NameEn = "Torayaya"
             },
             new City
             {
                 Id = 1247,
                 DistrictId = 14,
                 NameEn = "Tulhiriya"
             },
             new City
             {
                 Id = 1248,
                 DistrictId = 14,
                 NameEn = "Tuntota"
             },
             new City
             {
                 Id = 1249,
                 DistrictId = 14,
                 NameEn = "Tuttiripitigama"
             },
             new City
             {
                 Id = 1250,
                 DistrictId = 14,
                 NameEn = "Udagaldeniya"
             },
             new City
             {
                 Id = 1251,
                 DistrictId = 14,
                 NameEn = "Udahingulwala"
             },
             new City
             {
                 Id = 1252,
                 DistrictId = 14,
                 NameEn = "Udawatta"
             },
             new City
             {
                 Id = 1253,
                 DistrictId = 14,
                 NameEn = "Udubaddawa"
             },
             new City
             {
                 Id = 1254,
                 DistrictId = 14,
                 NameEn = "Udumulla"
             },
             new City
             {
                 Id = 1255,
                 DistrictId = 14,
                 NameEn = "Uhumiya"
             },
             new City
             {
                 Id = 1256,
                 DistrictId = 14,
                 NameEn = "Ulpotha Pallekele"
             },
             new City
             {
                 Id = 1257,
                 DistrictId = 14,
                 NameEn = "Ulpothagama"
             },
             new City
             {
                 Id = 1258,
                 DistrictId = 14,
                 NameEn = "Usgala Siyabmalangamuwa"
             },
             new City
             {
                 Id = 1259,
                 DistrictId = 14,
                 NameEn = "Vijithapura"
             },
             new City
             {
                 Id = 1260,
                 DistrictId = 14,
                 NameEn = "Wadakada"
             },
             new City
             {
                 Id = 1261,
                 DistrictId = 14,
                 NameEn = "Wadumunnegedara"
             },
             new City
             {
                 Id = 1262,
                 DistrictId = 14,
                 NameEn = "Walakumburumulla"
             },
             new City
             {
                 Id = 1263,
                 DistrictId = 14,
                 NameEn = "Wannigama"
             },
             new City
             {
                 Id = 1264,
                 DistrictId = 14,
                 NameEn = "Wannikudawewa"
             },
             new City
             {
                 Id = 1265,
                 DistrictId = 14,
                 NameEn = "Wannilhalagama"
             },
             new City
             {
                 Id = 1266,
                 DistrictId = 14,
                 NameEn = "Wannirasnayakapura"
             },
             new City
             {
                 Id = 1267,
                 DistrictId = 14,
                 NameEn = "Warawewa"
             },
             new City
             {
                 Id = 1268,
                 DistrictId = 14,
                 NameEn = "Wariyapola"
             },
             new City
             {
                 Id = 1269,
                 DistrictId = 14,
                 NameEn = "Watareka"
             },
             new City
             {
                 Id = 1270,
                 DistrictId = 14,
                 NameEn = "Wattegama"
             },
             new City
             {
                 Id = 1271,
                 DistrictId = 14,
                 NameEn = "Watuwatta"
             },
             new City
             {
                 Id = 1272,
                 DistrictId = 14,
                 NameEn = "Weerapokuna"
             },
             new City
             {
                 Id = 1273,
                 DistrictId = 14,
                 NameEn = "Welawa Juncton"
             },
             new City
             {
                 Id = 1274,
                 DistrictId = 14,
                 NameEn = "Welipennagahamulla"
             },
             new City
             {
                 Id = 1275,
                 DistrictId = 14,
                 NameEn = "Wellagala"
             },
             new City
             {
                 Id = 1276,
                 DistrictId = 14,
                 NameEn = "Wellarawa"
             },
             new City
             {
                 Id = 1277,
                 DistrictId = 14,
                 NameEn = "Wellawa"
             },
             new City
             {
                 Id = 1278,
                 DistrictId = 14,
                 NameEn = "Welpalla"
             },
             new City
             {
                 Id = 1279,
                 DistrictId = 14,
                 NameEn = "Wennoruwa"
             },
             new City
             {
                 Id = 1280,
                 DistrictId = 14,
                 NameEn = "Weuda"
             },
             new City
             {
                 Id = 1281,
                 DistrictId = 14,
                 NameEn = "Wewagama"
             },
             new City
             {
                 Id = 1282,
                 DistrictId = 14,
                 NameEn = "Wilgamuwa"
             },
             new City
             {
                 Id = 1283,
                 DistrictId = 14,
                 NameEn = "Yakwila"
             },
             new City
             {
                 Id = 1284,
                 DistrictId = 14,
                 NameEn = "Yatigaloluwa"
             },
             new City
             {
                 Id = 1285,
                 DistrictId = 15,
                 NameEn = "Mannar"
             },
             new City
             {
                 Id = 1286,
                 DistrictId = 15,
                 NameEn = "Puthukudiyiruppu"
             },
             new City
             {
                 Id = 1287,
                 DistrictId = 16,
                 NameEn = "Akuramboda"
             },
             new City
             {
                 Id = 1288,
                 DistrictId = 16,
                 NameEn = "Alawatuwala"
             },
             new City
             {
                 Id = 1289,
                 DistrictId = 16,
                 NameEn = "Alwatta"
             },
             new City
             {
                 Id = 1290,
                 DistrictId = 16,
                 NameEn = "Ambana"
             },
             new City
             {
                 Id = 1291,
                 DistrictId = 16,
                 NameEn = "Aralaganwila"
             },
             new City
             {
                 Id = 1292,
                 DistrictId = 16,
                 NameEn = "Ataragallewa"
             },
             new City
             {
                 Id = 1293,
                 DistrictId = 16,
                 NameEn = "Bambaragaswewa"
             },
             new City
             {
                 Id = 1294,
                 DistrictId = 16,
                 NameEn = "Barawardhana Oya"
             },
             new City
             {
                 Id = 1295,
                 DistrictId = 16,
                 NameEn = "Beligamuwa"
             },
             new City
             {
                 Id = 1296,
                 DistrictId = 16,
                 NameEn = "Damana"
             },
             new City
             {
                 Id = 1297,
                 DistrictId = 16,
                 NameEn = "Dambulla"
             },
             new City
             {
                 Id = 1298,
                 DistrictId = 16,
                 NameEn = "Damminna"
             },
             new City
             {
                 Id = 1299,
                 DistrictId = 16,
                 NameEn = "Dankanda"
             },
             new City
             {
                 Id = 1300,
                 DistrictId = 16,
                 NameEn = "Delwite"
             },
             new City
             {
                 Id = 1301,
                 DistrictId = 16,
                 NameEn = "Devagiriya"
             },
             new City
             {
                 Id = 1302,
                 DistrictId = 16,
                 NameEn = "Dewahuwa"
             },
             new City
             {
                 Id = 1303,
                 DistrictId = 16,
                 NameEn = "Divuldamana"
             },
             new City
             {
                 Id = 1304,
                 DistrictId = 16,
                 NameEn = "Dullewa"
             },
             new City
             {
                 Id = 1305,
                 DistrictId = 16,
                 NameEn = "Dunkolawatta"
             },
             new City
             {
                 Id = 1306,
                 DistrictId = 16,
                 NameEn = "Elkaduwa"
             },
             new City
             {
                 Id = 1307,
                 DistrictId = 16,
                 NameEn = "Erawula Junction"
             },
             new City
             {
                 Id = 1308,
                 DistrictId = 16,
                 NameEn = "Etanawala"
             },
             new City
             {
                 Id = 1309,
                 DistrictId = 16,
                 NameEn = "Galewela"
             },
             new City
             {
                 Id = 1310,
                 DistrictId = 16,
                 NameEn = "Galoya Junction"
             },
             new City
             {
                 Id = 1311,
                 DistrictId = 16,
                 NameEn = "Gammaduwa"
             },
             new City
             {
                 Id = 1312,
                 DistrictId = 16,
                 NameEn = "Gangala Puwakpitiya"
             },
             new City
             {
                 Id = 1313,
                 DistrictId = 16,
                 NameEn = "Hasalaka"
             },
             new City
             {
                 Id = 1314,
                 DistrictId = 16,
                 NameEn = "Hattota Amuna"
             },
             new City
             {
                 Id = 1315,
                 DistrictId = 16,
                 NameEn = "Imbulgolla"
             },
             new City
             {
                 Id = 1316,
                 DistrictId = 16,
                 NameEn = "Inamaluwa"
             },
             new City
             {
                 Id = 1317,
                 DistrictId = 16,
                 NameEn = "Iriyagolla"
             },
             new City
             {
                 Id = 1318,
                 DistrictId = 16,
                 NameEn = "Kaikawala"
             },
             new City
             {
                 Id = 1319,
                 DistrictId = 16,
                 NameEn = "Kalundawa"
             },
             new City
             {
                 Id = 1320,
                 DistrictId = 16,
                 NameEn = "Kandalama"
             },
             new City
             {
                 Id = 1321,
                 DistrictId = 16,
                 NameEn = "Kavudupelella"
             },
             new City
             {
                 Id = 1322,
                 DistrictId = 16,
                 NameEn = "Kibissa"
             },
             new City
             {
                 Id = 1323,
                 DistrictId = 16,
                 NameEn = "Kiwula"
             },
             new City
             {
                 Id = 1324,
                 DistrictId = 16,
                 NameEn = "Kongahawela"
             },
             new City
             {
                 Id = 1325,
                 DistrictId = 16,
                 NameEn = "Laggala Pallegama"
             },
             new City
             {
                 Id = 1326,
                 DistrictId = 16,
                 NameEn = "Leliambe"
             },
             new City
             {
                 Id = 1327,
                 DistrictId = 16,
                 NameEn = "Lenadora"
             },
             new City
             {
                 Id = 1328,
                 DistrictId = 16,
                 NameEn = "lhala Halmillewa"
             },
             new City
             {
                 Id = 1329,
                 DistrictId = 16,
                 NameEn = "lllukkumbura"
             },
             new City
             {
                 Id = 1330,
                 DistrictId = 16,
                 NameEn = "Madipola"
             },
             new City
             {
                 Id = 1331,
                 DistrictId = 16,
                 NameEn = "Maduruoya"
             },
             new City
             {
                 Id = 1332,
                 DistrictId = 16,
                 NameEn = "Mahawela"
             },
             new City
             {
                 Id = 1333,
                 DistrictId = 16,
                 NameEn = "Mananwatta"
             },
             new City
             {
                 Id = 1334,
                 DistrictId = 16,
                 NameEn = "Maraka"
             },
             new City
             {
                 Id = 1335,
                 DistrictId = 16,
                 NameEn = "Matale"
             },
             new City
             {
                 Id = 1336,
                 DistrictId = 16,
                 NameEn = "Melipitiya"
             },
             new City
             {
                 Id = 1337,
                 DistrictId = 16,
                 NameEn = "Metihakka"
             },
             new City
             {
                 Id = 1338,
                 DistrictId = 16,
                 NameEn = "Millawana"
             },
             new City
             {
                 Id = 1339,
                 DistrictId = 16,
                 NameEn = "Muwandeniya"
             },
             new City
             {
                 Id = 1340,
                 DistrictId = 16,
                 NameEn = "Nalanda"
             },
             new City
             {
                 Id = 1341,
                 DistrictId = 16,
                 NameEn = "Naula"
             },
             new City
             {
                 Id = 1342,
                 DistrictId = 16,
                 NameEn = "Opalgala"
             },
             new City
             {
                 Id = 1343,
                 DistrictId = 16,
                 NameEn = "Pallepola"
             },
             new City
             {
                 Id = 1344,
                 DistrictId = 16,
                 NameEn = "Pimburattewa"
             },
             new City
             {
                 Id = 1345,
                 DistrictId = 16,
                 NameEn = "Pulastigama"
             },
             new City
             {
                 Id = 1346,
                 DistrictId = 16,
                 NameEn = "Ranamuregama"
             },
             new City
             {
                 Id = 1347,
                 DistrictId = 16,
                 NameEn = "Rattota"
             },
             new City
             {
                 Id = 1348,
                 DistrictId = 16,
                 NameEn = "Selagama"
             },
             new City
             {
                 Id = 1349,
                 DistrictId = 16,
                 NameEn = "Sigiriya"
             },
             new City
             {
                 Id = 1350,
                 DistrictId = 16,
                 NameEn = "Sinhagama"
             },
             new City
             {
                 Id = 1351,
                 DistrictId = 16,
                 NameEn = "Sungavila"
             },
             new City
             {
                 Id = 1352,
                 DistrictId = 16,
                 NameEn = "Talagoda Junction"
             },
             new City
             {
                 Id = 1353,
                 DistrictId = 16,
                 NameEn = "Talakiriyagama"
             },
             new City
             {
                 Id = 1354,
                 DistrictId = 16,
                 NameEn = "Tamankaduwa"
             },
             new City
             {
                 Id = 1355,
                 DistrictId = 16,
                 NameEn = "Udasgiriya"
             },
             new City
             {
                 Id = 1356,
                 DistrictId = 16,
                 NameEn = "Udatenna"
             },
             new City
             {
                 Id = 1357,
                 DistrictId = 16,
                 NameEn = "Ukuwela"
             },
             new City
             {
                 Id = 1358,
                 DistrictId = 16,
                 NameEn = "Wahacotte"
             },
             new City
             {
                 Id = 1359,
                 DistrictId = 16,
                 NameEn = "Walawela"
             },
             new City
             {
                 Id = 1360,
                 DistrictId = 16,
                 NameEn = "Wehigala"
             },
             new City
             {
                 Id = 1361,
                 DistrictId = 16,
                 NameEn = "Welangahawatte"
             },
             new City
             {
                 Id = 1362,
                 DistrictId = 16,
                 NameEn = "Wewalawewa"
             },
             new City
             {
                 Id = 1363,
                 DistrictId = 16,
                 NameEn = "Yatawatta"
             },
             new City
             {
                 Id = 1364,
                 DistrictId = 17,
                 NameEn = "Akuressa"
             },
             new City
             {
                 Id = 1365,
                 DistrictId = 17,
                 NameEn = "Alapaladeniya"
             },
             new City
             {
                 Id = 1366,
                 DistrictId = 17,
                 NameEn = "Aparekka"
             },
             new City
             {
                 Id = 1367,
                 DistrictId = 17,
                 NameEn = "Athuraliya"
             },
             new City
             {
                 Id = 1368,
                 DistrictId = 17,
                 NameEn = "Bengamuwa"
             },
             new City
             {
                 Id = 1369,
                 DistrictId = 17,
                 NameEn = "Bopagoda"
             },
             new City
             {
                 Id = 1370,
                 DistrictId = 17,
                 NameEn = "Dampahala"
             },
             new City
             {
                 Id = 1371,
                 DistrictId = 17,
                 NameEn = "Deegala Lenama"
             },
             new City
             {
                 Id = 1372,
                 DistrictId = 17,
                 NameEn = "Deiyandara"
             },
             new City
             {
                 Id = 1373,
                 DistrictId = 17,
                 NameEn = "Denagama"
             },
             new City
             {
                 Id = 1374,
                 DistrictId = 17,
                 NameEn = "Denipitiya"
             },
             new City
             {
                 Id = 1375,
                 DistrictId = 17,
                 NameEn = "Deniyaya"
             },
             new City
             {
                 Id = 1376,
                 DistrictId = 17,
                 NameEn = "Derangala"
             },
             new City
             {
                 Id = 1377,
                 DistrictId = 17,
                 NameEn = "Devinuwara (Dondra)"
             },
             new City
             {
                 Id = 1378,
                 DistrictId = 17,
                 NameEn = "Dikwella"
             },
             new City
             {
                 Id = 1379,
                 DistrictId = 17,
                 NameEn = "Diyagaha"
             },
             new City
             {
                 Id = 1380,
                 DistrictId = 17,
                 NameEn = "Diyalape"
             },
             new City
             {
                 Id = 1381,
                 DistrictId = 17,
                 NameEn = "Gandara"
             },
             new City
             {
                 Id = 1382,
                 DistrictId = 17,
                 NameEn = "Godapitiya"
             },
             new City
             {
                 Id = 1383,
                 DistrictId = 17,
                 NameEn = "Gomilamawarala"
             },
             new City
             {
                 Id = 1384,
                 DistrictId = 17,
                 NameEn = "Hawpe"
             },
             new City
             {
                 Id = 1385,
                 DistrictId = 17,
                 NameEn = "Horapawita"
             },
             new City
             {
                 Id = 1386,
                 DistrictId = 17,
                 NameEn = "Kalubowitiyana"
             },
             new City
             {
                 Id = 1387,
                 DistrictId = 17,
                 NameEn = "Kamburugamuwa"
             },
             new City
             {
                 Id = 1388,
                 DistrictId = 17,
                 NameEn = "Kamburupitiya"
             },
             new City
             {
                 Id = 1389,
                 DistrictId = 17,
                 NameEn = "Karagoda Uyangoda"
             },
             new City
             {
                 Id = 1390,
                 DistrictId = 17,
                 NameEn = "Karaputugala"
             },
             new City
             {
                 Id = 1391,
                 DistrictId = 17,
                 NameEn = "Karatota"
             },
             new City
             {
                 Id = 1392,
                 DistrictId = 17,
                 NameEn = "Kekanadurra"
             },
             new City
             {
                 Id = 1393,
                 DistrictId = 17,
                 NameEn = "Kiriweldola"
             },
             new City
             {
                 Id = 1394,
                 DistrictId = 17,
                 NameEn = "Kiriwelkele"
             },
             new City
             {
                 Id = 1395,
                 DistrictId = 17,
                 NameEn = "Kolawenigama"
             },
             new City
             {
                 Id = 1396,
                 DistrictId = 17,
                 NameEn = "Kotapola"
             },
             new City
             {
                 Id = 1397,
                 DistrictId = 17,
                 NameEn = "Lankagama"
             },
             new City
             {
                 Id = 1398,
                 DistrictId = 17,
                 NameEn = "Makandura"
             },
             new City
             {
                 Id = 1399,
                 DistrictId = 17,
                 NameEn = "Maliduwa"
             },
             new City
             {
                 Id = 1400,
                 DistrictId = 17,
                 NameEn = "Maramba"
             },
             new City
             {
                 Id = 1401,
                 DistrictId = 17,
                 NameEn = "Matara"
             },
             new City
             {
                 Id = 1402,
                 DistrictId = 17,
                 NameEn = "Mediripitiya"
             },
             new City
             {
                 Id = 1403,
                 DistrictId = 17,
                 NameEn = "Miella"
             },
             new City
             {
                 Id = 1404,
                 DistrictId = 17,
                 NameEn = "Mirissa"
             },
             new City
             {
                 Id = 1405,
                 DistrictId = 17,
                 NameEn = "Morawaka"
             },
             new City
             {
                 Id = 1406,
                 DistrictId = 17,
                 NameEn = "Mulatiyana Junction"
             },
             new City
             {
                 Id = 1407,
                 DistrictId = 17,
                 NameEn = "Nadugala"
             },
             new City
             {
                 Id = 1408,
                 DistrictId = 17,
                 NameEn = "Naimana"
             },
             new City
             {
                 Id = 1409,
                 DistrictId = 17,
                 NameEn = "Palatuwa"
             },
             new City
             {
                 Id = 1410,
                 DistrictId = 17,
                 NameEn = "Parapamulla"
             },
             new City
             {
                 Id = 1411,
                 DistrictId = 17,
                 NameEn = "Pasgoda"
             },
             new City
             {
                 Id = 1412,
                 DistrictId = 17,
                 NameEn = "Penetiyana"
             },
             new City
             {
                 Id = 1413,
                 DistrictId = 17,
                 NameEn = "Pitabeddara"
             },
             new City
             {
                 Id = 1414,
                 DistrictId = 17,
                 NameEn = "Puhulwella"
             },
             new City
             {
                 Id = 1415,
                 DistrictId = 17,
                 NameEn = "Radawela"
             },
             new City
             {
                 Id = 1416,
                 DistrictId = 17,
                 NameEn = "Ransegoda"
             },
             new City
             {
                 Id = 1417,
                 DistrictId = 17,
                 NameEn = "Rotumba"
             },
             new City
             {
                 Id = 1418,
                 DistrictId = 17,
                 NameEn = "Sultanagoda"
             },
             new City
             {
                 Id = 1419,
                 DistrictId = 17,
                 NameEn = "Telijjawila"
             },
             new City
             {
                 Id = 1420,
                 DistrictId = 17,
                 NameEn = "Thihagoda"
             },
             new City
             {
                 Id = 1421,
                 DistrictId = 17,
                 NameEn = "Urubokka"
             },
             new City
             {
                 Id = 1422,
                 DistrictId = 17,
                 NameEn = "Urugamuwa"
             },
             new City
             {
                 Id = 1423,
                 DistrictId = 17,
                 NameEn = "Urumutta"
             },
             new City
             {
                 Id = 1424,
                 DistrictId = 17,
                 NameEn = "Viharahena"
             },
             new City
             {
                 Id = 1425,
                 DistrictId = 17,
                 NameEn = "Walakanda"
             },
             new City
             {
                 Id = 1426,
                 DistrictId = 17,
                 NameEn = "Walasgala"
             },
             new City
             {
                 Id = 1427,
                 DistrictId = 17,
                 NameEn = "Waralla"
             },
             new City
             {
                 Id = 1428,
                 DistrictId = 17,
                 NameEn = "Weligama"
             },
             new City
             {
                 Id = 1429,
                 DistrictId = 17,
                 NameEn = "Wilpita"
             },
             new City
             {
                 Id = 1430,
                 DistrictId = 17,
                 NameEn = "Yatiyana"
             },
             new City
             {
                 Id = 1431,
                 DistrictId = 18,
                 NameEn = "Ayiwela"
             },
             new City
             {
                 Id = 1432,
                 DistrictId = 18,
                 NameEn = "Badalkumbura"
             },
             new City
             {
                 Id = 1433,
                 DistrictId = 18,
                 NameEn = "Baduluwela"
             },
             new City
             {
                 Id = 1434,
                 DistrictId = 18,
                 NameEn = "Bakinigahawela"
             },
             new City
             {
                 Id = 1435,
                 DistrictId = 18,
                 NameEn = "Balaharuwa"
             },
             new City
             {
                 Id = 1436,
                 DistrictId = 18,
                 NameEn = "Bibile"
             },
             new City
             {
                 Id = 1437,
                 DistrictId = 18,
                 NameEn = "Buddama"
             },
             new City
             {
                 Id = 1438,
                 DistrictId = 18,
                 NameEn = "Buttala"
             },
             new City
             {
                 Id = 1439,
                 DistrictId = 18,
                 NameEn = "Dambagalla"
             },
             new City
             {
                 Id = 1440,
                 DistrictId = 18,
                 NameEn = "Diyakobala"
             },
             new City
             {
                 Id = 1441,
                 DistrictId = 18,
                 NameEn = "Dombagahawela"
             },
             new City
             {
                 Id = 1442,
                 DistrictId = 18,
                 NameEn = "Ethimalewewa"
             },
             new City
             {
                 Id = 1443,
                 DistrictId = 18,
                 NameEn = "Ettiliwewa"
             },
             new City
             {
                 Id = 1444,
                 DistrictId = 18,
                 NameEn = "Galabedda"
             },
             new City
             {
                 Id = 1445,
                 DistrictId = 18,
                 NameEn = "Gamewela"
             },
             new City
             {
                 Id = 1446,
                 DistrictId = 18,
                 NameEn = "Hambegamuwa"
             },
             new City
             {
                 Id = 1447,
                 DistrictId = 18,
                 NameEn = "Hingurukaduwa"
             },
             new City
             {
                 Id = 1448,
                 DistrictId = 18,
                 NameEn = "Hulandawa"
             },
             new City
             {
                 Id = 1449,
                 DistrictId = 18,
                 NameEn = "Inginiyagala"
             },
             new City
             {
                 Id = 1450,
                 DistrictId = 18,
                 NameEn = "Kandaudapanguwa"
             },
             new City
             {
                 Id = 1451,
                 DistrictId = 18,
                 NameEn = "Kandawinna"
             },
             new City
             {
                 Id = 1452,
                 DistrictId = 18,
                 NameEn = "Kataragama"
             },
             new City
             {
                 Id = 1453,
                 DistrictId = 18,
                 NameEn = "Kotagama"
             },
             new City
             {
                 Id = 1454,
                 DistrictId = 18,
                 NameEn = "Kotamuduna"
             },
             new City
             {
                 Id = 1455,
                 DistrictId = 18,
                 NameEn = "Kotawehera Mankada"
             },
             new City
             {
                 Id = 1456,
                 DistrictId = 18,
                 NameEn = "Kudawewa"
             },
             new City
             {
                 Id = 1457,
                 DistrictId = 18,
                 NameEn = "Kumbukkana"
             },
             new City
             {
                 Id = 1458,
                 DistrictId = 18,
                 NameEn = "Marawa"
             },
             new City
             {
                 Id = 1459,
                 DistrictId = 18,
                 NameEn = "Mariarawa"
             },
             new City
             {
                 Id = 1460,
                 DistrictId = 18,
                 NameEn = "Medagana"
             },
             new City
             {
                 Id = 1461,
                 DistrictId = 18,
                 NameEn = "Medawelagama"
             },
             new City
             {
                 Id = 1462,
                 DistrictId = 18,
                 NameEn = "Miyanakandura"
             },
             new City
             {
                 Id = 1463,
                 DistrictId = 18,
                 NameEn = "Monaragala"
             },
             new City
             {
                 Id = 1464,
                 DistrictId = 18,
                 NameEn = "Moretuwegama"
             },
             new City
             {
                 Id = 1465,
                 DistrictId = 18,
                 NameEn = "Nakkala"
             },
             new City
             {
                 Id = 1466,
                 DistrictId = 18,
                 NameEn = "Namunukula"
             },
             new City
             {
                 Id = 1467,
                 DistrictId = 18,
                 NameEn = "Nannapurawa"
             },
             new City
             {
                 Id = 1468,
                 DistrictId = 18,
                 NameEn = "Nelliyadda"
             },
             new City
             {
                 Id = 1469,
                 DistrictId = 18,
                 NameEn = "Nilgala"
             },
             new City
             {
                 Id = 1470,
                 DistrictId = 18,
                 NameEn = "Obbegoda"
             },
             new City
             {
                 Id = 1471,
                 DistrictId = 18,
                 NameEn = "Okkampitiya"
             },
             new City
             {
                 Id = 1472,
                 DistrictId = 18,
                 NameEn = "Pangura"
             },
             new City
             {
                 Id = 1473,
                 DistrictId = 18,
                 NameEn = "Pitakumbura"
             },
             new City
             {
                 Id = 1474,
                 DistrictId = 18,
                 NameEn = "Randeniya"
             },
             new City
             {
                 Id = 1475,
                 DistrictId = 18,
                 NameEn = "Ruwalwela"
             },
             new City
             {
                 Id = 1476,
                 DistrictId = 18,
                 NameEn = "Sella Kataragama"
             },
             new City
             {
                 Id = 1477,
                 DistrictId = 18,
                 NameEn = "Siyambalagune"
             },
             new City
             {
                 Id = 1478,
                 DistrictId = 18,
                 NameEn = "Siyambalanduwa"
             },
             new City
             {
                 Id = 1479,
                 DistrictId = 18,
                 NameEn = "Suriara"
             },
             new City
             {
                 Id = 1480,
                 DistrictId = 18,
                 NameEn = "Tanamalwila"
             },
             new City
             {
                 Id = 1481,
                 DistrictId = 18,
                 NameEn = "Uva Gangodagama"
             },
             new City
             {
                 Id = 1482,
                 DistrictId = 18,
                 NameEn = "Uva Kudaoya"
             },
             new City
             {
                 Id = 1483,
                 DistrictId = 18,
                 NameEn = "Uva Pelwatta"
             },
             new City
             {
                 Id = 1484,
                 DistrictId = 18,
                 NameEn = "Warunagama"
             },
             new City
             {
                 Id = 1485,
                 DistrictId = 18,
                 NameEn = "Wedikumbura"
             },
             new City
             {
                 Id = 1486,
                 DistrictId = 18,
                 NameEn = "Weherayaya Handapanagala"
             },
             new City
             {
                 Id = 1487,
                 DistrictId = 18,
                 NameEn = "Wellawaya"
             },
             new City
             {
                 Id = 1488,
                 DistrictId = 18,
                 NameEn = "Wilaoya"
             },
             new City
             {
                 Id = 1489,
                 DistrictId = 18,
                 NameEn = "Yudaganawa"
             },
             new City
             {
                 Id = 1490,
                 DistrictId = 19,
                 NameEn = "Mullativu"
             },
             new City
             {
                 Id = 1491,
                 DistrictId = 20,
                 NameEn = "Agarapathana"
             },
             new City
             {
                 Id = 1492,
                 DistrictId = 20,
                 NameEn = "Ambatalawa"
             },
             new City
             {
                 Id = 1493,
                 DistrictId = 20,
                 NameEn = "Ambewela"
             },
             new City
             {
                 Id = 1494,
                 DistrictId = 20,
                 NameEn = "Bogawantalawa"
             },
             new City
             {
                 Id = 1495,
                 DistrictId = 20,
                 NameEn = "Bopattalawa"
             },
             new City
             {
                 Id = 1496,
                 DistrictId = 20,
                 NameEn = "Dagampitiya"
             },
             new City
             {
                 Id = 1497,
                 DistrictId = 20,
                 NameEn = "Dayagama Bazaar"
             },
             new City
             {
                 Id = 1498,
                 DistrictId = 20,
                 NameEn = "Dikoya"
             },
             new City
             {
                 Id = 1499,
                 DistrictId = 20,
                 NameEn = "Doragala"
             },
             new City
             {
                 Id = 1500,
                 DistrictId = 20,
                 NameEn = "Dunukedeniya"
             },
             new City
             {
                 Id = 1501,
                 DistrictId = 20,
                 NameEn = "Egodawela"
             },
             new City
             {
                 Id = 1502,
                 DistrictId = 20,
                 NameEn = "Ekiriya"
             },
             new City
             {
                 Id = 1503,
                 DistrictId = 20,
                 NameEn = "Elamulla"
             },
             new City
             {
                 Id = 1504,
                 DistrictId = 20,
                 NameEn = "Ginigathena"
             },
             new City
             {
                 Id = 1505,
                 DistrictId = 20,
                 NameEn = "Gonakele"
             },
             new City
             {
                 Id = 1506,
                 DistrictId = 20,
                 NameEn = "Haggala"
             },
             new City
             {
                 Id = 1507,
                 DistrictId = 20,
                 NameEn = "Halgranoya"
             },
             new City
             {
                 Id = 1508,
                 DistrictId = 20,
                 NameEn = "Hangarapitiya"
             },
             new City
             {
                 Id = 1509,
                 DistrictId = 20,
                 NameEn = "Hapugastalawa"
             },
             new City
             {
                 Id = 1510,
                 DistrictId = 20,
                 NameEn = "Harasbedda"
             },
             new City
             {
                 Id = 1511,
                 DistrictId = 20,
                 NameEn = "Hatton"
             },
             new City
             {
                 Id = 1512,
                 DistrictId = 20,
                 NameEn = "Hewaheta"
             },
             new City
             {
                 Id = 1513,
                 DistrictId = 20,
                 NameEn = "Hitigegama"
             },
             new City
             {
                 Id = 1514,
                 DistrictId = 20,
                 NameEn = "Jangulla"
             },
             new City
             {
                 Id = 1515,
                 DistrictId = 20,
                 NameEn = "Kalaganwatta"
             },
             new City
             {
                 Id = 1516,
                 DistrictId = 20,
                 NameEn = "Kandapola"
             },
             new City
             {
                 Id = 1517,
                 DistrictId = 20,
                 NameEn = "Karandagolla"
             },
             new City
             {
                 Id = 1518,
                 DistrictId = 20,
                 NameEn = "Keerthi Bandarapura"
             },
             new City
             {
                 Id = 1519,
                 DistrictId = 20,
                 NameEn = "Kiribathkumbura"
             },
             new City
             {
                 Id = 1520,
                 DistrictId = 20,
                 NameEn = "Kotiyagala"
             },
             new City
             {
                 Id = 1521,
                 DistrictId = 20,
                 NameEn = "Kotmale"
             },
             new City
             {
                 Id = 1522,
                 DistrictId = 20,
                 NameEn = "Kottellena"
             },
             new City
             {
                 Id = 1523,
                 DistrictId = 20,
                 NameEn = "Kumbalgamuwa"
             },
             new City
             {
                 Id = 1524,
                 DistrictId = 20,
                 NameEn = "Kumbukwela"
             },
             new City
             {
                 Id = 1525,
                 DistrictId = 20,
                 NameEn = "Kurupanawela"
             },
             new City
             {
                 Id = 1526,
                 DistrictId = 20,
                 NameEn = "Labukele"
             },
             new City
             {
                 Id = 1527,
                 DistrictId = 20,
                 NameEn = "Laxapana"
             },
             new City
             {
                 Id = 1528,
                 DistrictId = 20,
                 NameEn = "Lindula"
             },
             new City
             {
                 Id = 1529,
                 DistrictId = 20,
                 NameEn = "Madulla"
             },
             new City
             {
                 Id = 1530,
                 DistrictId = 20,
                 NameEn = "Mandaram Nuwara"
             },
             new City
             {
                 Id = 1531,
                 DistrictId = 20,
                 NameEn = "Maskeliya"
             },
             new City
             {
                 Id = 1532,
                 DistrictId = 20,
                 NameEn = "Maswela"
             },
             new City
             {
                 Id = 1533,
                 DistrictId = 20,
                 NameEn = "Maturata"
             },
             new City
             {
                 Id = 1534,
                 DistrictId = 20,
                 NameEn = "Mipanawa"
             },
             new City
             {
                 Id = 1535,
                 DistrictId = 20,
                 NameEn = "Mipilimana"
             },
             new City
             {
                 Id = 1536,
                 DistrictId = 20,
                 NameEn = "Morahenagama"
             },
             new City
             {
                 Id = 1537,
                 DistrictId = 20,
                 NameEn = "Munwatta"
             },
             new City
             {
                 Id = 1538,
                 DistrictId = 20,
                 NameEn = "Nayapana Janapadaya"
             },
             new City
             {
                 Id = 1539,
                 DistrictId = 20,
                 NameEn = "Nildandahinna"
             },
             new City
             {
                 Id = 1540,
                 DistrictId = 20,
                 NameEn = "Nissanka Uyana"
             },
             new City
             {
                 Id = 1541,
                 DistrictId = 20,
                 NameEn = "Norwood"
             },
             new City
             {
                 Id = 1542,
                 DistrictId = 20,
                 NameEn = "Nuwara Eliya"
             },
             new City
             {
                 Id = 1543,
                 DistrictId = 20,
                 NameEn = "Padiyapelella"
             },
             new City
             {
                 Id = 1544,
                 DistrictId = 20,
                 NameEn = "Pallebowala"
             },
             new City
             {
                 Id = 1545,
                 DistrictId = 20,
                 NameEn = "Panvila"
             },
             new City
             {
                 Id = 1546,
                 DistrictId = 20,
                 NameEn = "Pitawala"
             },
             new City
             {
                 Id = 1547,
                 DistrictId = 20,
                 NameEn = "Pundaluoya"
             },
             new City
             {
                 Id = 1548,
                 DistrictId = 20,
                 NameEn = "Ramboda"
             },
             new City
             {
                 Id = 1549,
                 DistrictId = 20,
                 NameEn = "Rikillagaskada"
             },
             new City
             {
                 Id = 1550,
                 DistrictId = 20,
                 NameEn = "Rozella"
             },
             new City
             {
                 Id = 1551,
                 DistrictId = 20,
                 NameEn = "Rupaha"
             },
             new City
             {
                 Id = 1552,
                 DistrictId = 20,
                 NameEn = "Ruwaneliya"
             },
             new City
             {
                 Id = 1553,
                 DistrictId = 20,
                 NameEn = "Santhipura"
             },
             new City
             {
                 Id = 1554,
                 DistrictId = 20,
                 NameEn = "Talawakele"
             },
             new City
             {
                 Id = 1555,
                 DistrictId = 20,
                 NameEn = "Tawalantenna"
             },
             new City
             {
                 Id = 1556,
                 DistrictId = 20,
                 NameEn = "Teripeha"
             },
             new City
             {
                 Id = 1557,
                 DistrictId = 20,
                 NameEn = "Udamadura"
             },
             new City
             {
                 Id = 1558,
                 DistrictId = 20,
                 NameEn = "Udapussallawa"
             },
             new City
             {
                 Id = 1559,
                 DistrictId = 20,
                 NameEn = "Uva Deegalla"
             },
             new City
             {
                 Id = 1560,
                 DistrictId = 20,
                 NameEn = "Uva Uduwara"
             },
             new City
             {
                 Id = 1561,
                 DistrictId = 20,
                 NameEn = "Uvaparanagama"
             },
             new City
             {
                 Id = 1562,
                 DistrictId = 20,
                 NameEn = "Walapane"
             },
             new City
             {
                 Id = 1563,
                 DistrictId = 20,
                 NameEn = "Watawala"
             },
             new City
             {
                 Id = 1564,
                 DistrictId = 20,
                 NameEn = "Widulipura"
             },
             new City
             {
                 Id = 1565,
                 DistrictId = 20,
                 NameEn = "Wijebahukanda"
             },
             new City
             {
                 Id = 1566,
                 DistrictId = 21,
                 NameEn = "Attanakadawala"
             },
             new City
             {
                 Id = 1567,
                 DistrictId = 21,
                 NameEn = "Bakamuna"
             },
             new City
             {
                 Id = 1568,
                 DistrictId = 21,
                 NameEn = "Diyabeduma"
             },
             new City
             {
                 Id = 1569,
                 DistrictId = 21,
                 NameEn = "Elahera"
             },
             new City
             {
                 Id = 1570,
                 DistrictId = 21,
                 NameEn = "Giritale"
             },
             new City
             {
                 Id = 1571,
                 DistrictId = 21,
                 NameEn = "Hingurakdamana"
             },
             new City
             {
                 Id = 1572,
                 DistrictId = 21,
                 NameEn = "Hingurakgoda"
             },
             new City
             {
                 Id = 1573,
                 DistrictId = 21,
                 NameEn = "Jayanthipura"
             },
             new City
             {
                 Id = 1574,
                 DistrictId = 21,
                 NameEn = "Kalingaela"
             },
             new City
             {
                 Id = 1575,
                 DistrictId = 21,
                 NameEn = "Lakshauyana"
             },
             new City
             {
                 Id = 1576,
                 DistrictId = 21,
                 NameEn = "Mankemi"
             },
             new City
             {
                 Id = 1577,
                 DistrictId = 21,
                 NameEn = "Minneriya"
             },
             new City
             {
                 Id = 1578,
                 DistrictId = 21,
                 NameEn = "Onegama"
             },
             new City
             {
                 Id = 1579,
                 DistrictId = 21,
                 NameEn = "Orubendi Siyambalawa"
             },
             new City
             {
                 Id = 1580,
                 DistrictId = 21,
                 NameEn = "Palugasdamana"
             },
             new City
             {
                 Id = 1581,
                 DistrictId = 21,
                 NameEn = "Panichankemi"
             },
             new City
             {
                 Id = 1582,
                 DistrictId = 21,
                 NameEn = "Polonnaruwa"
             },
             new City
             {
                 Id = 1583,
                 DistrictId = 21,
                 NameEn = "Talpotha"
             },
             new City
             {
                 Id = 1584,
                 DistrictId = 21,
                 NameEn = "Tambala"
             },
             new City
             {
                 Id = 1585,
                 DistrictId = 21,
                 NameEn = "Unagalavehera"
             },
             new City
             {
                 Id = 1586,
                 DistrictId = 21,
                 NameEn = "Wijayabapura"
             },
             new City
             {
                 Id = 1587,
                 DistrictId = 22,
                 NameEn = "Adippala"
             },
             new City
             {
                 Id = 1588,
                 DistrictId = 22,
                 NameEn = "Alutgama"
             },
             new City
             {
                 Id = 1589,
                 DistrictId = 22,
                 NameEn = "Alutwewa"
             },
             new City
             {
                 Id = 1590,
                 DistrictId = 22,
                 NameEn = "Ambakandawila"
             },
             new City
             {
                 Id = 1591,
                 DistrictId = 22,
                 NameEn = "Anamaduwa"
             },
             new City
             {
                 Id = 1592,
                 DistrictId = 22,
                 NameEn = "Andigama"
             },
             new City
             {
                 Id = 1593,
                 DistrictId = 22,
                 NameEn = "Angunawila"
             },
             new City
             {
                 Id = 1594,
                 DistrictId = 22,
                 NameEn = "Attawilluwa"
             },
             new City
             {
                 Id = 1595,
                 DistrictId = 22,
                 NameEn = "Bangadeniya"
             },
             new City
             {
                 Id = 1596,
                 DistrictId = 22,
                 NameEn = "Baranankattuwa"
             },
             new City
             {
                 Id = 1597,
                 DistrictId = 22,
                 NameEn = "Battuluoya"
             },
             new City
             {
                 Id = 1598,
                 DistrictId = 22,
                 NameEn = "Bujjampola"
             },
             new City
             {
                 Id = 1599,
                 DistrictId = 22,
                 NameEn = "Chilaw"
             },
             new City
             {
                 Id = 1600,
                 DistrictId = 22,
                 NameEn = "Dalukana"
             },
             new City
             {
                 Id = 1601,
                 DistrictId = 22,
                 NameEn = "Dankotuwa"
             },
             new City
             {
                 Id = 1602,
                 DistrictId = 22,
                 NameEn = "Dewagala"
             },
             new City
             {
                 Id = 1603,
                 DistrictId = 22,
                 NameEn = "Dummalasuriya"
             },
             new City
             {
                 Id = 1604,
                 DistrictId = 22,
                 NameEn = "Dunkannawa"
             },
             new City
             {
                 Id = 1605,
                 DistrictId = 22,
                 NameEn = "Eluwankulama"
             },
             new City
             {
                 Id = 1606,
                 DistrictId = 22,
                 NameEn = "Ettale"
             },
             new City
             {
                 Id = 1607,
                 DistrictId = 22,
                 NameEn = "Galamuna"
             },
             new City
             {
                 Id = 1608,
                 DistrictId = 22,
                 NameEn = "Galmuruwa"
             },
             new City
             {
                 Id = 1609,
                 DistrictId = 22,
                 NameEn = "Hansayapalama"
             },
             new City
             {
                 Id = 1610,
                 DistrictId = 22,
                 NameEn = "Ihala Kottaramulla"
             },
             new City
             {
                 Id = 1611,
                 DistrictId = 22,
                 NameEn = "Ilippadeniya"
             },
             new City
             {
                 Id = 1612,
                 DistrictId = 22,
                 NameEn = "Inginimitiya"
             },
             new City
             {
                 Id = 1613,
                 DistrictId = 22,
                 NameEn = "Ismailpuram"
             },
             new City
             {
                 Id = 1614,
                 DistrictId = 22,
                 NameEn = "Jayasiripura"
             },
             new City
             {
                 Id = 1615,
                 DistrictId = 22,
                 NameEn = "Kakkapalliya"
             },
             new City
             {
                 Id = 1616,
                 DistrictId = 22,
                 NameEn = "Kalkudah"
             },
             new City
             {
                 Id = 1617,
                 DistrictId = 22,
                 NameEn = "Kalladiya"
             },
             new City
             {
                 Id = 1618,
                 DistrictId = 22,
                 NameEn = "Kandakuliya"
             },
             new City
             {
                 Id = 1619,
                 DistrictId = 22,
                 NameEn = "Karathivu"
             },
             new City
             {
                 Id = 1620,
                 DistrictId = 22,
                 NameEn = "Karawitagara"
             },
             new City
             {
                 Id = 1621,
                 DistrictId = 22,
                 NameEn = "Karuwalagaswewa"
             },
             new City
             {
                 Id = 1622,
                 DistrictId = 22,
                 NameEn = "Katuneriya"
             },
             new City
             {
                 Id = 1623,
                 DistrictId = 22,
                 NameEn = "Koswatta"
             },
             new City
             {
                 Id = 1624,
                 DistrictId = 22,
                 NameEn = "Kottantivu"
             },
             new City
             {
                 Id = 1625,
                 DistrictId = 22,
                 NameEn = "Kottapitiya"
             },
             new City
             {
                 Id = 1626,
                 DistrictId = 22,
                 NameEn = "Kottukachchiya"
             },
             new City
             {
                 Id = 1627,
                 DistrictId = 22,
                 NameEn = "Kumarakattuwa"
             },
             new City
             {
                 Id = 1628,
                 DistrictId = 22,
                 NameEn = "Kurinjanpitiya"
             },
             new City
             {
                 Id = 1629,
                 DistrictId = 22,
                 NameEn = "Kuruketiyawa"
             },
             new City
             {
                 Id = 1630,
                 DistrictId = 22,
                 NameEn = "Lunuwila"
             },
             new City
             {
                 Id = 1631,
                 DistrictId = 22,
                 NameEn = "Madampe"
             },
             new City
             {
                 Id = 1632,
                 DistrictId = 22,
                 NameEn = "Madurankuliya"
             },
             new City
             {
                 Id = 1633,
                 DistrictId = 22,
                 NameEn = "Mahakumbukkadawala"
             },
             new City
             {
                 Id = 1634,
                 DistrictId = 22,
                 NameEn = "Mahauswewa"
             },
             new City
             {
                 Id = 1635,
                 DistrictId = 22,
                 NameEn = "Mampitiya"
             },
             new City
             {
                 Id = 1636,
                 DistrictId = 22,
                 NameEn = "Mampuri"
             },
             new City
             {
                 Id = 1637,
                 DistrictId = 22,
                 NameEn = "Mangalaeliya"
             },
             new City
             {
                 Id = 1638,
                 DistrictId = 22,
                 NameEn = "Marawila"
             },
             new City
             {
                 Id = 1639,
                 DistrictId = 22,
                 NameEn = "Mudalakkuliya"
             },
             new City
             {
                 Id = 1640,
                 DistrictId = 22,
                 NameEn = "Mugunuwatawana"
             },
             new City
             {
                 Id = 1641,
                 DistrictId = 22,
                 NameEn = "Mukkutoduwawa"
             },
             new City
             {
                 Id = 1642,
                 DistrictId = 22,
                 NameEn = "Mundel"
             },
             new City
             {
                 Id = 1643,
                 DistrictId = 22,
                 NameEn = "Muttibendiwila"
             },
             new City
             {
                 Id = 1644,
                 DistrictId = 22,
                 NameEn = "Nainamadama"
             },
             new City
             {
                 Id = 1645,
                 DistrictId = 22,
                 NameEn = "Nalladarankattuwa"
             },
             new City
             {
                 Id = 1646,
                 DistrictId = 22,
                 NameEn = "Nattandiya"
             },
             new City
             {
                 Id = 1647,
                 DistrictId = 22,
                 NameEn = "Nawagattegama"
             },
             new City
             {
                 Id = 1648,
                 DistrictId = 22,
                 NameEn = "Nelumwewa"
             },
             new City
             {
                 Id = 1649,
                 DistrictId = 22,
                 NameEn = "Norachcholai"
             },
             new City
             {
                 Id = 1650,
                 DistrictId = 22,
                 NameEn = "Pallama"
             },
             new City
             {
                 Id = 1651,
                 DistrictId = 22,
                 NameEn = "Palliwasalturai"
             },
             new City
             {
                 Id = 1652,
                 DistrictId = 22,
                 NameEn = "Panirendawa"
             },
             new City
             {
                 Id = 1653,
                 DistrictId = 22,
                 NameEn = "Parakramasamudraya"
             },
             new City
             {
                 Id = 1654,
                 DistrictId = 22,
                 NameEn = "Pothuwatawana"
             },
             new City
             {
                 Id = 1655,
                 DistrictId = 22,
                 NameEn = "Puttalam"
             },
             new City
             {
                 Id = 1656,
                 DistrictId = 22,
                 NameEn = "Puttalam Cement Factory"
             },
             new City
             {
                 Id = 1657,
                 DistrictId = 22,
                 NameEn = "Rajakadaluwa"
             },
             new City
             {
                 Id = 1658,
                 DistrictId = 22,
                 NameEn = "Saliyawewa Junction"
             },
             new City
             {
                 Id = 1659,
                 DistrictId = 22,
                 NameEn = "Serukele"
             },
             new City
             {
                 Id = 1660,
                 DistrictId = 22,
                 NameEn = "Siyambalagashene"
             },
             new City
             {
                 Id = 1661,
                 DistrictId = 22,
                 NameEn = "Tabbowa"
             },
             new City
             {
                 Id = 1662,
                 DistrictId = 22,
                 NameEn = "Talawila Church"
             },
             new City
             {
                 Id = 1663,
                 DistrictId = 22,
                 NameEn = "Toduwawa"
             },
             new City
             {
                 Id = 1664,
                 DistrictId = 22,
                 NameEn = "Udappuwa"
             },
             new City
             {
                 Id = 1665,
                 DistrictId = 22,
                 NameEn = "Uridyawa"
             },
             new City
             {
                 Id = 1666,
                 DistrictId = 22,
                 NameEn = "Vanathawilluwa"
             },
             new City
             {
                 Id = 1667,
                 DistrictId = 22,
                 NameEn = "Waikkal"
             },
             new City
             {
                 Id = 1668,
                 DistrictId = 22,
                 NameEn = "Watugahamulla"
             },
             new City
             {
                 Id = 1669,
                 DistrictId = 22,
                 NameEn = "Wennappuwa"
             },
             new City
             {
                 Id = 1670,
                 DistrictId = 22,
                 NameEn = "Wijeyakatupotha"
             },
             new City
             {
                 Id = 1671,
                 DistrictId = 22,
                 NameEn = "Wilpotha"
             },
             new City
             {
                 Id = 1672,
                 DistrictId = 22,
                 NameEn = "Yodaela"
             },
             new City
             {
                 Id = 1673,
                 DistrictId = 22,
                 NameEn = "Yogiyana"
             },
             new City
             {
                 Id = 1674,
                 DistrictId = 23,
                 NameEn = "Akarella"
             },
             new City
             {
                 Id = 1675,
                 DistrictId = 23,
                 NameEn = "Amunumulla"
             },
             new City
             {
                 Id = 1676,
                 DistrictId = 23,
                 NameEn = "Atakalanpanna"
             },
             new City
             {
                 Id = 1677,
                 DistrictId = 23,
                 NameEn = "Ayagama"
             },
             new City
             {
                 Id = 1678,
                 DistrictId = 23,
                 NameEn = "Balangoda"
             },
             new City
             {
                 Id = 1679,
                 DistrictId = 23,
                 NameEn = "Batatota"
             },
             new City
             {
                 Id = 1680,
                 DistrictId = 23,
                 NameEn = "Beralapanathara"
             },
             new City
             {
                 Id = 1681,
                 DistrictId = 23,
                 NameEn = "Bogahakumbura"
             },
             new City
             {
                 Id = 1682,
                 DistrictId = 23,
                 NameEn = "Bolthumbe"
             },
             new City
             {
                 Id = 1683,
                 DistrictId = 23,
                 NameEn = "Bomluwageaina"
             },
             new City
             {
                 Id = 1684,
                 DistrictId = 23,
                 NameEn = "Bowalagama"
             },
             new City
             {
                 Id = 1685,
                 DistrictId = 23,
                 NameEn = "Bulutota"
             },
             new City
             {
                 Id = 1686,
                 DistrictId = 23,
                 NameEn = "Dambuluwana"
             },
             new City
             {
                 Id = 1687,
                 DistrictId = 23,
                 NameEn = "Daugala"
             },
             new City
             {
                 Id = 1688,
                 DistrictId = 23,
                 NameEn = "Dela"
             },
             new City
             {
                 Id = 1689,
                 DistrictId = 23,
                 NameEn = "Delwala"
             },
             new City
             {
                 Id = 1690,
                 DistrictId = 23,
                 NameEn = "Dodampe"
             },
             new City
             {
                 Id = 1691,
                 DistrictId = 23,
                 NameEn = "Doloswalakanda"
             },
             new City
             {
                 Id = 1692,
                 DistrictId = 23,
                 NameEn = "Dumbara Manana"
             },
             new City
             {
                 Id = 1693,
                 DistrictId = 23,
                 NameEn = "Eheliyagoda"
             },
             new City
             {
                 Id = 1694,
                 DistrictId = 23,
                 NameEn = "Ekamutugama"
             },
             new City
             {
                 Id = 1695,
                 DistrictId = 23,
                 NameEn = "Elapatha"
             },
             new City
             {
                 Id = 1696,
                 DistrictId = 23,
                 NameEn = "Ellagawa"
             },
             new City
             {
                 Id = 1697,
                 DistrictId = 23,
                 NameEn = "Ellaulla"
             },
             new City
             {
                 Id = 1698,
                 DistrictId = 23,
                 NameEn = "Ellawala"
             },
             new City
             {
                 Id = 1699,
                 DistrictId = 23,
                 NameEn = "Embilipitiya"
             },
             new City
             {
                 Id = 1700,
                 DistrictId = 23,
                 NameEn = "Eratna"
             },
             new City
             {
                 Id = 1701,
                 DistrictId = 23,
                 NameEn = "Erepola"
             },
             new City
             {
                 Id = 1702,
                 DistrictId = 23,
                 NameEn = "Gabbela"
             },
             new City
             {
                 Id = 1703,
                 DistrictId = 23,
                 NameEn = "Gangeyaya"
             },
             new City
             {
                 Id = 1704,
                 DistrictId = 23,
                 NameEn = "Gawaragiriya"
             },
             new City
             {
                 Id = 1705,
                 DistrictId = 23,
                 NameEn = "Gillimale"
             },
             new City
             {
                 Id = 1706,
                 DistrictId = 23,
                 NameEn = "Godakawela"
             },
             new City
             {
                 Id = 1707,
                 DistrictId = 23,
                 NameEn = "Gurubewilagama"
             },
             new City
             {
                 Id = 1708,
                 DistrictId = 23,
                 NameEn = "Halwinna"
             },
             new City
             {
                 Id = 1709,
                 DistrictId = 23,
                 NameEn = "Handagiriya"
             },
             new City
             {
                 Id = 1710,
                 DistrictId = 23,
                 NameEn = "Hatangala"
             },
             new City
             {
                 Id = 1711,
                 DistrictId = 23,
                 NameEn = "Hatarabage"
             },
             new City
             {
                 Id = 1712,
                 DistrictId = 23,
                 NameEn = "Hewanakumbura"
             },
             new City
             {
                 Id = 1713,
                 DistrictId = 23,
                 NameEn = "Hidellana"
             },
             new City
             {
                 Id = 1714,
                 DistrictId = 23,
                 NameEn = "Hiramadagama"
             },
             new City
             {
                 Id = 1715,
                 DistrictId = 23,
                 NameEn = "Horewelagoda"
             },
             new City
             {
                 Id = 1716,
                 DistrictId = 23,
                 NameEn = "Ittakanda"
             },
             new City
             {
                 Id = 1717,
                 DistrictId = 23,
                 NameEn = "Kahangama"
             },
             new City
             {
                 Id = 1718,
                 DistrictId = 23,
                 NameEn = "Kahawatta"
             },
             new City
             {
                 Id = 1719,
                 DistrictId = 23,
                 NameEn = "Kalawana"
             },
             new City
             {
                 Id = 1720,
                 DistrictId = 23,
                 NameEn = "Kaltota"
             },
             new City
             {
                 Id = 1721,
                 DistrictId = 23,
                 NameEn = "Kalubululanda"
             },
             new City
             {
                 Id = 1722,
                 DistrictId = 23,
                 NameEn = "Kananke Bazaar"
             },
             new City
             {
                 Id = 1723,
                 DistrictId = 23,
                 NameEn = "Kandepuhulpola"
             },
             new City
             {
                 Id = 1724,
                 DistrictId = 23,
                 NameEn = "Karandana"
             },
             new City
             {
                 Id = 1725,
                 DistrictId = 23,
                 NameEn = "Karangoda"
             },
             new City
             {
                 Id = 1726,
                 DistrictId = 23,
                 NameEn = "Kella Junction"
             },
             new City
             {
                 Id = 1727,
                 DistrictId = 23,
                 NameEn = "Keppetipola"
             },
             new City
             {
                 Id = 1728,
                 DistrictId = 23,
                 NameEn = "Kiriella"
             },
             new City
             {
                 Id = 1729,
                 DistrictId = 23,
                 NameEn = "Kiriibbanwewa"
             },
             new City
             {
                 Id = 1730,
                 DistrictId = 23,
                 NameEn = "Kolambageara"
             },
             new City
             {
                 Id = 1731,
                 DistrictId = 23,
                 NameEn = "Kolombugama"
             },
             new City
             {
                 Id = 1732,
                 DistrictId = 23,
                 NameEn = "Kolonna"
             },
             new City
             {
                 Id = 1733,
                 DistrictId = 23,
                 NameEn = "Kudawa"
             },
             new City
             {
                 Id = 1734,
                 DistrictId = 23,
                 NameEn = "Kuruwita"
             },
             new City
             {
                 Id = 1735,
                 DistrictId = 23,
                 NameEn = "Lellopitiya"
             },
             new City
             {
                 Id = 1736,
                 DistrictId = 23,
                 NameEn = "lmaduwa"
             },
             new City
             {
                 Id = 1737,
                 DistrictId = 23,
                 NameEn = "lmbulpe"
             },
             new City
             {
                 Id = 1738,
                 DistrictId = 23,
                 NameEn = "Mahagama Colony"
             },
             new City
             {
                 Id = 1739,
                 DistrictId = 23,
                 NameEn = "Mahawalatenna"
             },
             new City
             {
                 Id = 1740,
                 DistrictId = 23,
                 NameEn = "Makandura Sabara"
             },
             new City
             {
                 Id = 1741,
                 DistrictId = 23,
                 NameEn = "Malwala Junction"
             },
             new City
             {
                 Id = 1742,
                 DistrictId = 23,
                 NameEn = "Malwatta"
             },
             new City
             {
                 Id = 1743,
                 DistrictId = 23,
                 NameEn = "Matuwagalagama"
             },
             new City
             {
                 Id = 1744,
                 DistrictId = 23,
                 NameEn = "Medagalatur"
             },
             new City
             {
                 Id = 1745,
                 DistrictId = 23,
                 NameEn = "Meddekanda"
             },
             new City
             {
                 Id = 1746,
                 DistrictId = 23,
                 NameEn = "Minipura Dumbara"
             },
             new City
             {
                 Id = 1747,
                 DistrictId = 23,
                 NameEn = "Mitipola"
             },
             new City
             {
                 Id = 1748,
                 DistrictId = 23,
                 NameEn = "Moragala Kirillapone"
             },
             new City
             {
                 Id = 1749,
                 DistrictId = 23,
                 NameEn = "Morahela"
             },
             new City
             {
                 Id = 1750,
                 DistrictId = 23,
                 NameEn = "Mulendiyawala"
             },
             new City
             {
                 Id = 1751,
                 DistrictId = 23,
                 NameEn = "Mulgama"
             },
             new City
             {
                 Id = 1752,
                 DistrictId = 23,
                 NameEn = "Nawalakanda"
             },
             new City
             {
                 Id = 1753,
                 DistrictId = 23,
                 NameEn = "NawinnaPinnakanda"
             },
             new City
             {
                 Id = 1754,
                 DistrictId = 23,
                 NameEn = "Niralagama"
             },
             new City
             {
                 Id = 1755,
                 DistrictId = 23,
                 NameEn = "Nivitigala"
             },
             new City
             {
                 Id = 1756,
                 DistrictId = 23,
                 NameEn = "Omalpe"
             },
             new City
             {
                 Id = 1757,
                 DistrictId = 23,
                 NameEn = "Opanayaka"
             },
             new City
             {
                 Id = 1758,
                 DistrictId = 23,
                 NameEn = "Padalangala"
             },
             new City
             {
                 Id = 1759,
                 DistrictId = 23,
                 NameEn = "Pallebedda"
             },
             new City
             {
                 Id = 1760,
                 DistrictId = 23,
                 NameEn = "Pallekanda"
             },
             new City
             {
                 Id = 1761,
                 DistrictId = 23,
                 NameEn = "Pambagolla"
             },
             new City
             {
                 Id = 1762,
                 DistrictId = 23,
                 NameEn = "Panamura"
             },
             new City
             {
                 Id = 1763,
                 DistrictId = 23,
                 NameEn = "Panapola"
             },
             new City
             {
                 Id = 1764,
                 DistrictId = 23,
                 NameEn = "Paragala"
             },
             new City
             {
                 Id = 1765,
                 DistrictId = 23,
                 NameEn = "Parakaduwa"
             },
             new City
             {
                 Id = 1766,
                 DistrictId = 23,
                 NameEn = "Pebotuwa"
             },
             new City
             {
                 Id = 1767,
                 DistrictId = 23,
                 NameEn = "Pelmadulla"
             },
             new City
             {
                 Id = 1768,
                 DistrictId = 23,
                 NameEn = "Pinnawala"
             },
             new City
             {
                 Id = 1769,
                 DistrictId = 23,
                 NameEn = "Pothdeniya"
             },
             new City
             {
                 Id = 1770,
                 DistrictId = 23,
                 NameEn = "Rajawaka"
             },
             new City
             {
                 Id = 1771,
                 DistrictId = 23,
                 NameEn = "Ranwala"
             },
             new City
             {
                 Id = 1772,
                 DistrictId = 23,
                 NameEn = "Rassagala"
             },
             new City
             {
                 Id = 1773,
                 DistrictId = 23,
                 NameEn = "Ratgama"
             },
             new City
             {
                 Id = 1774,
                 DistrictId = 23,
                 NameEn = "Ratna Hangamuwa"
             },
             new City
             {
                 Id = 1775,
                 DistrictId = 23,
                 NameEn = "Ratnapura"
             },
             new City
             {
                 Id = 1776,
                 DistrictId = 23,
                 NameEn = "Sewanagala"
             },
             new City
             {
                 Id = 1777,
                 DistrictId = 23,
                 NameEn = "Sri Palabaddala"
             },
             new City
             {
                 Id = 1778,
                 DistrictId = 23,
                 NameEn = "Sudagala"
             },
             new City
             {
                 Id = 1779,
                 DistrictId = 23,
                 NameEn = "Talakolahinna"
             },
             new City
             {
                 Id = 1780,
                 DistrictId = 23,
                 NameEn = "Tanjantenna"
             },
             new City
             {
                 Id = 1781,
                 DistrictId = 23,
                 NameEn = "Teppanawa"
             },
             new City
             {
                 Id = 1782,
                 DistrictId = 23,
                 NameEn = "Tunkama"
             },
             new City
             {
                 Id = 1783,
                 DistrictId = 23,
                 NameEn = "Udakarawita"
             },
             new City
             {
                 Id = 1784,
                 DistrictId = 23,
                 NameEn = "Udaniriella"
             },
             new City
             {
                 Id = 1785,
                 DistrictId = 23,
                 NameEn = "Udawalawe"
             },
             new City
             {
                 Id = 1786,
                 DistrictId = 23,
                 NameEn = "Ullinduwawa"
             },
             new City
             {
                 Id = 1787,
                 DistrictId = 23,
                 NameEn = "Veddagala"
             },
             new City
             {
                 Id = 1788,
                 DistrictId = 23,
                 NameEn = "Vijeriya"
             },
             new City
             {
                 Id = 1789,
                 DistrictId = 23,
                 NameEn = "Waleboda"
             },
             new City
             {
                 Id = 1790,
                 DistrictId = 23,
                 NameEn = "Watapotha"
             },
             new City
             {
                 Id = 1791,
                 DistrictId = 23,
                 NameEn = "Waturawa"
             },
             new City
             {
                 Id = 1792,
                 DistrictId = 23,
                 NameEn = "Weligepola"
             },
             new City
             {
                 Id = 1793,
                 DistrictId = 23,
                 NameEn = "Welipathayaya"
             },
             new City
             {
                 Id = 1794,
                 DistrictId = 23,
                 NameEn = "Wikiliya"
             },
             new City
             {
                 Id = 1795,
                 DistrictId = 24,
                 NameEn = "Agbopura"
             },
             new City
             {
                 Id = 1796,
                 DistrictId = 24,
                 NameEn = "Buckmigama"
             },
             new City
             {
                 Id = 1797,
                 DistrictId = 24,
                 NameEn = "China Bay"
             },
             new City
             {
                 Id = 1798,
                 DistrictId = 24,
                 NameEn = "Dehiwatte"
             },
             new City
             {
                 Id = 1799,
                 DistrictId = 24,
                 NameEn = "Echchilampattai"
             },
             new City
             {
                 Id = 1800,
                 DistrictId = 24,
                 NameEn = "Galmetiyawa"
             },
             new City
             {
                 Id = 1801,
                 DistrictId = 24,
                 NameEn = "Gomarankadawala"
             },
             new City
             {
                 Id = 1802,
                 DistrictId = 24,
                 NameEn = "Kaddaiparichchan"
             },
             new City
             {
                 Id = 1803,
                 DistrictId = 24,
                 NameEn = "Kallar"
             },
             new City
             {
                 Id = 1804,
                 DistrictId = 24,
                 NameEn = "Kanniya"
             },
             new City
             {
                 Id = 1805,
                 DistrictId = 24,
                 NameEn = "Kantalai"
             },
             new City
             {
                 Id = 1806,
                 DistrictId = 24,
                 NameEn = "Kantalai Sugar Factory"
             },
             new City
             {
                 Id = 1807,
                 DistrictId = 24,
                 NameEn = "Kiliveddy"
             },
             new City
             {
                 Id = 1808,
                 DistrictId = 24,
                 NameEn = "Kinniya"
             },
             new City
             {
                 Id = 1809,
                 DistrictId = 24,
                 NameEn = "Kuchchaveli"
             },
             new City
             {
                 Id = 1810,
                 DistrictId = 24,
                 NameEn = "Kumburupiddy"
             },
             new City
             {
                 Id = 1811,
                 DistrictId = 24,
                 NameEn = "Kurinchakemy"
             },
             new City
             {
                 Id = 1812,
                 DistrictId = 24,
                 NameEn = "Lankapatuna"
             },
             new City
             {
                 Id = 1813,
                 DistrictId = 24,
                 NameEn = "Mahadivulwewa"
             },
             new City
             {
                 Id = 1814,
                 DistrictId = 24,
                 NameEn = "Maharugiramam"
             },
             new City
             {
                 Id = 1815,
                 DistrictId = 24,
                 NameEn = "Mallikativu"
             },
             new City
             {
                 Id = 1816,
                 DistrictId = 24,
                 NameEn = "Mawadichenai"
             },
             new City
             {
                 Id = 1817,
                 DistrictId = 24,
                 NameEn = "Mullipothana"
             },
             new City
             {
                 Id = 1818,
                 DistrictId = 24,
                 NameEn = "Mutur"
             },
             new City
             {
                 Id = 1819,
                 DistrictId = 24,
                 NameEn = "Neelapola"
             },
             new City
             {
                 Id = 1820,
                 DistrictId = 24,
                 NameEn = "Nilaveli"
             },
             new City
             {
                 Id = 1821,
                 DistrictId = 24,
                 NameEn = "Pankulam"
             },
             new City
             {
                 Id = 1822,
                 DistrictId = 24,
                 NameEn = "Pulmoddai"
             },
             new City
             {
                 Id = 1823,
                 DistrictId = 24,
                 NameEn = "Rottawewa"
             },
             new City
             {
                 Id = 1824,
                 DistrictId = 24,
                 NameEn = "Sampaltivu"
             },
             new City
             {
                 Id = 1825,
                 DistrictId = 24,
                 NameEn = "Sampoor"
             },
             new City
             {
                 Id = 1826,
                 DistrictId = 24,
                 NameEn = "Serunuwara"
             },
             new City
             {
                 Id = 1827,
                 DistrictId = 24,
                 NameEn = "Seruwila"
             },
             new City
             {
                 Id = 1828,
                 DistrictId = 24,
                 NameEn = "Sirajnagar"
             },
             new City
             {
                 Id = 1829,
                 DistrictId = 24,
                 NameEn = "Somapura"
             },
             new City
             {
                 Id = 1830,
                 DistrictId = 24,
                 NameEn = "Tampalakamam"
             },
             new City
             {
                 Id = 1831,
                 DistrictId = 24,
                 NameEn = "Thuraineelavanai"
             },
             new City
             {
                 Id = 1832,
                 DistrictId = 24,
                 NameEn = "Tiriyayi"
             },
             new City
             {
                 Id = 1833,
                 DistrictId = 24,
                 NameEn = "Toppur"
             },
             new City
             {
                 Id = 1834,
                 DistrictId = 24,
                 NameEn = "Trincomalee"
             },
             new City
             {
                 Id = 1835,
                 DistrictId = 24,
                 NameEn = "Wanela"
             },
             new City
             {
                 Id = 1836,
                 DistrictId = 25,
                 NameEn = "Vavuniya"
             },
             new City
             {
                 Id = 1837,
                 DistrictId = 5,
                 NameEn = "Colombo 1"
             },
             new City
             {
                 Id = 1838,
                 DistrictId = 5,
                 NameEn = "Colombo 3"
             },
             new City
             {
                 Id = 1839,
                 DistrictId = 5,
                 NameEn = "Colombo 4"
             },
             new City
             {
                 Id = 1840,
                 DistrictId = 5,
                 NameEn = "Colombo 5"
             },
             new City
             {
                 Id = 1841,
                 DistrictId = 5,
                 NameEn = "Colombo 7"
             },
             new City
             {
                 Id = 1842,
                 DistrictId = 5,
                 NameEn = "Colombo 9"
             },
             new City
             {
                 Id = 1843,
                 DistrictId = 5,
                 NameEn = "Colombo 10"
             },
             new City
             {
                 Id = 1844,
                 DistrictId = 5,
                 NameEn = "Colombo 11"
             },
             new City
             {
                 Id = 1845,
                 DistrictId = 5,
                 NameEn = "Colombo 12"
             },
             new City
             {
                 Id = 1846,
                 DistrictId = 5,
                 NameEn = "Colombo 14"
             }

            );
            #endregion
            #region Order Forms
            modelBuilder.Entity<Status>().HasData(
            new Status
            {
                Id = 1,
                StatusName = "New Order"
            },
            new Status
            {
                Id = 2,
                StatusName = "Pending"
            },
            new Status
            {
                Id = 3,
                StatusName = "Hold"
            },
            new Status
            {
                Id = 4,
                StatusName = "Complete"
            }
            );
              #endregion
          }
    }
}
