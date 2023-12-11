using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class addIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leave_Type_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    st_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jt_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryTypeID = table.Column<int>(type: "int", nullable: false),
                    EmpoyeeEPF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpoyeerEPF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpoyeerETF = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitles_SalaryTypes_SalaryTypeID",
                        column: x => x.SalaryTypeID,
                        principalTable: "SalaryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emp_Cid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_job_title_id = table.Column<int>(type: "int", nullable: false),
                    Emp_Department_id = table.Column<int>(type: "int", nullable: false),
                    Emp_NIC = table.Column<int>(type: "int", nullable: false),
                    Emp_DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Emp_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emp_Gender_id = table.Column<int>(type: "int", nullable: false),
                    Emp_start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Emp_dp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_contact_info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Is_active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Emp_Department_id",
                        column: x => x.Emp_Department_id,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_Emp_Gender_id",
                        column: x => x.Emp_Gender_id,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_JobTitles_Emp_job_title_id",
                        column: x => x.Emp_job_title_id,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attendance_e_id = table.Column<int>(type: "int", nullable: false),
                    attendance_in_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    attendance_out_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attendance_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    attendance_in_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    attendance_out_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Employees_attendance_e_id",
                        column: x => x.attendance_e_id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employees_Id = table.Column<int>(type: "int", nullable: false),
                    Leave_Apply_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_Type_Id = table.Column<int>(type: "int", nullable: false),
                    Leave_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leave_Acommencement_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_Return_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number_of_Days = table.Column<int>(type: "int", nullable: false),
                    Leave_Approved_by = table.Column<int>(type: "int", nullable: false),
                    Leave_Approved_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leaves_Employees_Employees_Id",
                        column: x => x.Employees_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leaves_LeaveTypes_Leave_Type_Id",
                        column: x => x.Leave_Type_Id,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayRolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    PraperedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Allowances = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Advanced = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetBasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkDays = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ApprovedBy = table.Column<int>(type: "int", nullable: false),
                    PayedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayRolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayRolls_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Department_Name" },
                values: new object[,]
                {
                    { 1, "Legal" },
                    { 2, "Human Resources" },
                    { 3, "Training" },
                    { 4, "Accounting" },
                    { 5, "Sales" },
                    { 6, "Engineering" },
                    { 7, "Legal" },
                    { 8, "Sales" },
                    { 9, "Human Resources" },
                    { 10, "Research and Development" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "Leave_Type_Name" },
                values: new object[,]
                {
                    { 1, "Sick Leave" },
                    { 2, "Personal Leave" },
                    { 3, "Vacation Leave" },
                    { 4, "Other Leave" }
                });

            migrationBuilder.InsertData(
                table: "SalaryTypes",
                columns: new[] { "Id", "st_name" },
                values: new object[,]
                {
                    { 1, "Daily" },
                    { 2, "Monthly" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "BaseSalary", "EmpoyeeEPF", "EmpoyeerEPF", "EmpoyeerETF", "SalaryTypeID", "jt_name" },
                values: new object[,]
                {
                    { 1, 1500.00m, 0m, 0m, 0m, 1, "Job Title 1" },
                    { 2, 55000.00m, 4400.0000m, 6600.0000m, 1650.0000m, 2, "Job Title 2" },
                    { 3, 1600.00m, 0m, 0m, 0m, 1, "Job Title 3" },
                    { 4, 65000.00m, 5200.0000m, 7800.0000m, 1950.0000m, 2, "Job Title 4" },
                    { 5, 1700.00m, 0m, 0m, 0m, 1, "Job Title 5" },
                    { 6, 75000.00m, 6000.0000m, 9000.0000m, 2250.0000m, 2, "Job Title 6" },
                    { 7, 1800.00m, 0m, 0m, 0m, 1, "Job Title 7" },
                    { 8, 85000.00m, 6800.0000m, 10200.0000m, 2550.0000m, 2, "Job Title 8" },
                    { 9, 2900.00m, 0m, 0m, 0m, 1, "Job Title 9" },
                    { 10, 95000.00m, 7600.0000m, 11400.0000m, 2850.0000m, 2, "Job Title 10" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Emp_Address", "Emp_Cid", "Emp_DateOfBirth", "Emp_Department_id", "Emp_Gender_id", "Emp_Is_active", "Emp_NIC", "Emp_contact_info", "Emp_dp", "Emp_full_name", "Emp_job_title_id", "Emp_start_date" },
                values: new object[,]
                {
                    { 1, "20403 Bunker Hill Lane", "509280", new DateTime(1972, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 1, 654654646, "190-481-6403", "Crimson", "Jeanie Norrie", 7, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "05080 Village Place", "583367", new DateTime(1973, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 1, 654654646, "231-972-7579", "Red", "Arabele Millwater", 7, new DateTime(2016, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "81 Carioca Lane", "751033", new DateTime(1971, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 1, 654654646, "299-264-5583", "Mauv", "Karen Solomon", 1, new DateTime(2012, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "94 Towne Avenue", "239178", new DateTime(1966, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2, 654654646, "496-189-7339", "Blue", "Seamus Yeoman", 6, new DateTime(2012, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "59664 Gina Crossing", "663442", new DateTime(1988, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 654654646, "260-523-1239", "Goldenrod", "Vincenty Frankcombe", 10, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "9979 Vernon Street", "723826", new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2, 654654646, "773-437-6039", "Fuscia", "Tybalt Alldridge", 8, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "0 7th Place", "332886", new DateTime(1971, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2, 654654646, "250-398-3300", "Puce", "Amye Adcock", 4, new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "92 Pawling Alley", "681434", new DateTime(1988, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2, 654654646, "752-372-2010", "Aquamarine", "Frasier Shrigley", 2, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "63 Manley Terrace", "857369", new DateTime(1983, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, 2, 654654646, "512-765-9897", "Red", "Magda Spraberry", 4, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "9 Caliangt Pass", "637020", new DateTime(1961, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1, 654654646, "426-464-2982", "Purple", "Maressa Gheorghe", 10, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "114 Bonner Center", "685841", new DateTime(1967, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2, 654654646, "100-113-6495", "Fuscia", "Bambie Selbie", 6, new DateTime(2017, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "0658 Artisan Drive", "728440", new DateTime(1965, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 1, 654654646, "850-277-8474", "Aquamarine", "Darwin Callington", 8, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "2305 Stuart Drive", "672909", new DateTime(1998, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 654654646, "255-334-1273", "Yellow", "Basilio Longhi", 8, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "574 Gulseth Crossing", "275978", new DateTime(1983, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 654654646, "157-963-7726", "Violet", "Hewet Sorrell", 1, new DateTime(2016, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "06 Mayfield Junction", "466923", new DateTime(1964, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 654654646, "831-374-8100", "Violet", "Dorothea Cantera", 9, new DateTime(2015, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_attendance_e_id",
                table: "Attendances",
                column: "attendance_e_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Emp_Department_id",
                table: "Employees",
                column: "Emp_Department_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Emp_Gender_id",
                table: "Employees",
                column: "Emp_Gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Emp_job_title_id",
                table: "Employees",
                column: "Emp_job_title_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_SalaryTypeID",
                table: "JobTitles",
                column: "SalaryTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_Employees_Id",
                table: "Leaves",
                column: "Employees_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_Leave_Type_Id",
                table: "Leaves",
                column: "Leave_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PayRolls_EmployeeID",
                table: "PayRolls",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "PayRolls");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "SalaryTypes");
        }
    }
}
