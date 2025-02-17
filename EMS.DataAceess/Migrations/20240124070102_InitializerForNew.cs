﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class InitializerForNew : Migration
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
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color_Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
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
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameSi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
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
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
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
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameSi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
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
                    Emp_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "WhereHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Physical_Stock = table.Column<int>(type: "int", nullable: false),
                    Receive_stock = table.Column<int>(type: "int", nullable: false),
                    Depatch_Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhereHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhereHouses_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Shop_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Contact_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_CityId = table.Column<int>(type: "int", nullable: false),
                    Customer_Road = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_Customer_CityId",
                        column: x => x.Customer_CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    User_Employee_Id = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Employees_User_Employee_Id",
                        column: x => x.User_Employee_Id,
                        principalTable: "Employees",
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

            migrationBuilder.CreateTable(
                name: "SalesExecutives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Sale_Exe_Route = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesExecutives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesExecutives_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
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
                name: "OrderForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    OrderForm_No = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SalesExecutiveId = table.Column<int>(type: "int", nullable: false),
                    SubRoute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Road = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderForm_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderRequired_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderForm_EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderForms_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderForms_SalesExecutives_SalesExecutiveId",
                        column: x => x.SalesExecutiveId,
                        principalTable: "SalesExecutives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderForms_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderFormProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderForm_Id = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Required_Quantity = table.Column<int>(type: "int", nullable: false),
                    Check = table.Column<bool>(type: "bit", nullable: false),
                    Send_Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFormProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderFormProducts_OrderForms_OrderForm_Id",
                        column: x => x.OrderForm_Id,
                        principalTable: "OrderForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderFormProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Brand_Name" },
                values: new object[,]
                {
                    { 1, "Aquaseale" },
                    { 2, "Emultion" },
                    { 3, "Tile Motar" },
                    { 4, "Skim Coat" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Color_Code", "Color_Name" },
                values: new object[,]
                {
                    { 1, "#FF0000", "Red" },
                    { 2, "#FFFF00", "Yellow" },
                    { 3, "#00FF00", "Green" },
                    { 4, "#0000FF", "Blue" },
                    { 5, "#FFA500", "Orange" },
                    { 6, "#FFC0CB", "Pink" },
                    { 7, "#A52A2A", "Brown" },
                    { 8, "#00FFFF", "Cyan" },
                    { 9, "#FF00FF", "Magenta" },
                    { 10, "#00FF00", "Lime" },
                    { 11, "#008080", "Teal" },
                    { 12, "#4B0082", "Indigo" },
                    { 13, "#EE82EE", "Violet" },
                    { 14, "#800000", "Maroon" },
                    { 15, "#FFD700", "Gold" },
                    { 16, "#C0C0C0", "Silver" },
                    { 17, "#000080", "Navy" },
                    { 18, "#40E0D0", "Turquoise" },
                    { 19, "#808000", "Olive" },
                    { 20, "#FFE5B4", "Peach" },
                    { 21, "#FA8072", "Salmon" },
                    { 22, "#FF6347", "Tomato" },
                    { 23, "#DDA0DD", "Plum" },
                    { 24, "#F0E68C", "Khaki" }
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
                    { 7, "Shop" },
                    { 8, "Loading" },
                    { 9, "Distribution" },
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
                table: "Provinces",
                columns: new[] { "Id", "NameEn", "NameSi", "NameTa" },
                values: new object[,]
                {
                    { 1, "Western", "බස්නාහිර", "மேல்" },
                    { 2, "Central", "මධ්‍යම", "மத்திய" },
                    { 3, "Southern", "දකුණු", "தென்" },
                    { 4, "North Western", "වයඹ", "வட மேல்" },
                    { 5, "Sabaragamuwa", "සබරගමුව", "சபரகமுவ" },
                    { 6, "Eastern", "නැගෙනහිර", "கிழக்கு" },
                    { 7, "Uva", "ඌව", "ஊவா" },
                    { 8, "North Central", "උතුරු මැද", "வட மத்திய" },
                    { 9, "Northern", "උතුරු", "வட" }
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
                table: "Sizes",
                columns: new[] { "Id", "Size_Name" },
                values: new object[,]
                {
                    { 1, "500ML" },
                    { 2, "1L" },
                    { 3, "4L" },
                    { 4, "10L" },
                    { 5, "20L" },
                    { 6, "20KG" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 1, "New Order" },
                    { 2, "Pending" },
                    { 3, "Hold" },
                    { 4, "Complete" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "NameEn", "NameSi", "NameTa", "ProvinceId" },
                values: new object[,]
                {
                    { 1, "Ampara", "අම්පාර", "அம்பாறை", 6 },
                    { 2, "Anuradhapura", "අනුරාධපුරය", "அனுராதபுரம்", 8 },
                    { 3, "Badulla", "බදුල්ල", "பதுளை", 7 },
                    { 4, "Batticaloa", "මඩකලපුව", "மட்டக்களப்பு", 6 },
                    { 5, "Colombo", "කොළඹ", "கொழும்பு", 1 },
                    { 6, "Galle", "ගාල්ල", "காலி", 3 },
                    { 7, "Gampaha", "ගම්පහ", "கம்பஹா", 1 },
                    { 8, "Hambantota", "හම්බන්තොට", "அம்பாந்தோட்டை", 3 },
                    { 9, "Jaffna", "යාපනය", "யாழ்ப்பாணம்", 9 },
                    { 10, "Kalutara", "කළුතර", "களுத்துறை", 1 },
                    { 11, "Kandy", "මහනුවර", "கண்டி", 2 },
                    { 12, "Kegalle", "කෑගල්ල", "கேகாலை", 5 },
                    { 13, "Kilinochchi", "කිලිනොච්චිය", "கிளிநொச்சி", 9 },
                    { 14, "Kurunegala", "කුරුණෑගල", "குருணாகல்", 4 },
                    { 15, "Mannar", "මන්නාරම", "மன்னார்", 9 },
                    { 16, "Matale", "මාතලේ", "மாத்தளை", 2 },
                    { 17, "Matara", "මාතර", "மாத்தறை", 3 },
                    { 18, "Monaragala", "මොණරාගල", "மொணராகலை", 7 },
                    { 19, "Mullaitivu", "මුලතිව්", "முல்லைத்தீவு", 9 },
                    { 20, "Nuwara Eliya", "නුවර එළිය", "நுவரேலியா", 2 },
                    { 21, "Polonnaruwa", "පොළොන්නරුව", "பொலன்னறுவை", 8 },
                    { 22, "Puttalam", "පුත්තලම", "புத்தளம்", 4 },
                    { 23, "Ratnapura", "රත්නපුර", "இரத்தினபுரி", 5 },
                    { 24, "Trincomalee", "ත්‍රිකුණාමලය", "திருகோணமலை", 6 },
                    { 25, "Vavuniya", "වව්නියාව", "வவுனியா", 9 }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "BaseSalary", "EmpoyeeEPF", "EmpoyeerEPF", "EmpoyeerETF", "SalaryTypeID", "jt_name" },
                values: new object[,]
                {
                    { 1, 1500.00m, 0m, 0m, 0m, 1, "Software Engineer" },
                    { 2, 55000.00m, 4400.0000m, 6600.0000m, 1650.0000m, 2, "Chief Accountant" },
                    { 3, 1600.00m, 0m, 0m, 0m, 1, "Accountant" },
                    { 4, 65000.00m, 5200.0000m, 7800.0000m, 1950.0000m, 2, "Account Assistant" },
                    { 5, 1700.00m, 0m, 0m, 0m, 1, "Sales Executive" },
                    { 6, 75000.00m, 6000.0000m, 9000.0000m, 2250.0000m, 2, "Area Sales Manager" },
                    { 7, 1800.00m, 0m, 0m, 0m, 1, "Traninee Accountant" },
                    { 8, 85000.00m, 6800.0000m, 10200.0000m, 2550.0000m, 2, "Light Vehicle Driver" },
                    { 9, 2900.00m, 0m, 0m, 0m, 1, "Heavy Vehicle Driver" },
                    { 10, 95000.00m, 7600.0000m, 11400.0000m, 2850.0000m, 2, "Administrative" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "ColorId", "SizeId" },
                values: new object[,]
                {
                    { 1, 2, 2, 2 },
                    { 2, 1, 3, 3 },
                    { 3, 2, 4, 4 },
                    { 4, 1, 5, 5 },
                    { 5, 2, 6, 1 },
                    { 6, 1, 7, 2 },
                    { 7, 2, 8, 3 },
                    { 8, 1, 9, 4 },
                    { 9, 2, 10, 5 },
                    { 10, 1, 11, 1 },
                    { 11, 2, 12, 2 },
                    { 12, 1, 13, 3 },
                    { 13, 2, 14, 4 },
                    { 14, 1, 15, 5 },
                    { 15, 2, 16, 1 },
                    { 16, 1, 17, 2 },
                    { 17, 2, 18, 3 },
                    { 18, 1, 19, 4 },
                    { 19, 2, 20, 5 },
                    { 20, 1, 1, 1 },
                    { 21, 2, 2, 2 },
                    { 22, 1, 3, 3 },
                    { 23, 2, 4, 4 },
                    { 24, 1, 5, 5 },
                    { 25, 2, 6, 1 },
                    { 26, 1, 7, 2 },
                    { 27, 2, 8, 3 },
                    { 28, 1, 9, 4 },
                    { 29, 2, 10, 5 },
                    { 30, 1, 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "DistrictId", "NameEn" },
                values: new object[,]
                {
                    { 1, 1, "Akkaraipattu" },
                    { 2, 1, "Ambagahawatta" },
                    { 3, 1, "Ampara" },
                    { 4, 1, "Bakmitiyawa" },
                    { 5, 1, "Deegawapiya" },
                    { 6, 1, "Devalahinda" },
                    { 7, 1, "Digamadulla Weeragoda" },
                    { 8, 1, "Dorakumbura" },
                    { 9, 1, "Gonagolla" },
                    { 10, 1, "Hulannuge" },
                    { 11, 1, "Kalmunai" },
                    { 12, 1, "Kannakipuram" },
                    { 13, 1, "Karativu" },
                    { 14, 1, "Kekirihena" },
                    { 15, 1, "Koknahara" },
                    { 16, 1, "Kolamanthalawa" },
                    { 17, 1, "Komari" },
                    { 18, 1, "Lahugala" },
                    { 19, 1, "lmkkamam" },
                    { 20, 1, "Mahaoya" },
                    { 21, 1, "Marathamune" },
                    { 22, 1, "Namaloya" },
                    { 23, 1, "Navithanveli" },
                    { 24, 1, "Nintavur" },
                    { 25, 1, "Oluvil" },
                    { 26, 1, "Padiyatalawa" },
                    { 27, 1, "Pahalalanda" },
                    { 28, 1, "Panama" },
                    { 29, 1, "Pannalagama" },
                    { 30, 1, "Paragahakele" },
                    { 31, 1, "Periyaneelavanai" },
                    { 32, 1, "Polwaga Janapadaya" },
                    { 33, 1, "Pottuvil" },
                    { 34, 1, "Sainthamaruthu" },
                    { 35, 1, "Samanthurai" },
                    { 36, 1, "Serankada" },
                    { 37, 1, "Tempitiya" },
                    { 38, 1, "Thambiluvil" },
                    { 39, 1, "Tirukovil" },
                    { 40, 1, "Uhana" },
                    { 41, 1, "Wadinagala" },
                    { 42, 1, "Wanagamuwa" },
                    { 43, 2, "Angamuwa" },
                    { 44, 2, "Anuradhapura" },
                    { 45, 2, "Awukana" },
                    { 46, 2, "Bogahawewa" },
                    { 47, 2, "Dematawewa" },
                    { 48, 2, "Dimbulagala" },
                    { 49, 2, "Dutuwewa" },
                    { 50, 2, "Elayapattuwa" },
                    { 51, 2, "Ellewewa" },
                    { 52, 2, "Eppawala" },
                    { 53, 2, "Etawatunuwewa" },
                    { 54, 2, "Etaweeragollewa" },
                    { 55, 2, "Galapitagala" },
                    { 56, 2, "Galenbindunuwewa" },
                    { 57, 2, "Galkadawala" },
                    { 58, 2, "Galkiriyagama" },
                    { 59, 2, "Galkulama" },
                    { 60, 2, "Galnewa" },
                    { 61, 2, "Gambirigaswewa" },
                    { 62, 2, "Ganewalpola" },
                    { 63, 2, "Gemunupura" },
                    { 64, 2, "Getalawa" },
                    { 65, 2, "Gnanikulama" },
                    { 66, 2, "Gonahaddenawa" },
                    { 67, 2, "Habarana" },
                    { 68, 2, "Halmillawa Dambulla" },
                    { 69, 2, "Halmillawetiya" },
                    { 70, 2, "Hidogama" },
                    { 71, 2, "Horawpatana" },
                    { 72, 2, "Horiwila" },
                    { 73, 2, "Hurigaswewa" },
                    { 74, 2, "Hurulunikawewa" },
                    { 75, 2, "Ihala Puliyankulama" },
                    { 76, 2, "Kagama" },
                    { 77, 2, "Kahatagasdigiliya" },
                    { 78, 2, "Kahatagollewa" },
                    { 79, 2, "Kalakarambewa" },
                    { 80, 2, "Kalaoya" },
                    { 81, 2, "Kalawedi Ulpotha" },
                    { 82, 2, "Kallanchiya" },
                    { 83, 2, "Kalpitiya" },
                    { 84, 2, "Kalukele Badanagala" },
                    { 85, 2, "Kapugallawa" },
                    { 86, 2, "Karagahawewa" },
                    { 87, 2, "Kashyapapura" },
                    { 88, 2, "Kebithigollewa" },
                    { 89, 2, "Kekirawa" },
                    { 90, 2, "Kendewa" },
                    { 91, 2, "Kiralogama" },
                    { 92, 2, "Kirigalwewa" },
                    { 93, 2, "Kirimundalama" },
                    { 94, 2, "Kitulhitiyawa" },
                    { 95, 2, "Kurundankulama" },
                    { 96, 2, "Labunoruwa" },
                    { 97, 2, "Ihalagama" },
                    { 98, 2, "Ipologama" },
                    { 99, 2, "Madatugama" },
                    { 100, 2, "Maha Elagamuwa" },
                    { 101, 2, "Mahabulankulama" },
                    { 102, 2, "Mahailluppallama" },
                    { 103, 2, "Mahakanadarawa" },
                    { 104, 2, "Mahapothana" },
                    { 105, 2, "Mahasenpura" },
                    { 106, 2, "Mahawilachchiya" },
                    { 107, 2, "Mailagaswewa" },
                    { 108, 2, "Malwanagama" },
                    { 109, 2, "Maneruwa" },
                    { 110, 2, "Maradankadawala" },
                    { 111, 2, "Maradankalla" },
                    { 112, 2, "Medawachchiya" },
                    { 113, 2, "Megodawewa" },
                    { 114, 2, "Mihintale" },
                    { 115, 2, "Morakewa" },
                    { 116, 2, "Mulkiriyawa" },
                    { 117, 2, "Muriyakadawala" },
                    { 118, 5, "Colombo 15" },
                    { 119, 2, "Nachchaduwa" },
                    { 120, 2, "Namalpura" },
                    { 121, 2, "Negampaha" },
                    { 122, 2, "Nochchiyagama" },
                    { 123, 2, "Nuwaragala" },
                    { 124, 2, "Padavi Maithripura" },
                    { 125, 2, "Padavi Parakramapura" },
                    { 126, 2, "Padavi Sripura" },
                    { 127, 2, "Padavi Sritissapura" },
                    { 128, 2, "Padaviya" },
                    { 129, 2, "Padikaramaduwa" },
                    { 130, 2, "Pahala Halmillewa" },
                    { 131, 2, "Pahala Maragahawe" },
                    { 132, 2, "Pahalagama" },
                    { 133, 2, "Palugaswewa" },
                    { 134, 2, "Pandukabayapura" },
                    { 135, 2, "Pandulagama" },
                    { 136, 2, "Parakumpura" },
                    { 137, 2, "Parangiyawadiya" },
                    { 138, 2, "Parasangahawewa" },
                    { 139, 2, "Pelatiyawa" },
                    { 140, 2, "Pemaduwa" },
                    { 141, 2, "Perimiyankulama" },
                    { 142, 2, "Pihimbiyagolewa" },
                    { 143, 2, "Pubbogama" },
                    { 144, 2, "Punewa" },
                    { 145, 2, "Rajanganaya" },
                    { 146, 2, "Rambewa" },
                    { 147, 2, "Rampathwila" },
                    { 148, 2, "Rathmalgahawewa" },
                    { 149, 2, "Saliyapura" },
                    { 150, 2, "Seeppukulama" },
                    { 151, 2, "Senapura" },
                    { 152, 2, "Sivalakulama" },
                    { 153, 2, "Siyambalewa" },
                    { 154, 2, "Sravasthipura" },
                    { 155, 2, "Talawa" },
                    { 156, 2, "Tambuttegama" },
                    { 157, 2, "Tammennawa" },
                    { 158, 2, "Tantirimale" },
                    { 159, 2, "Telhiriyawa" },
                    { 160, 2, "Tirappane" },
                    { 161, 2, "Tittagonewa" },
                    { 162, 2, "Udunuwara Colony" },
                    { 163, 2, "Upuldeniya" },
                    { 164, 2, "Uttimaduwa" },
                    { 165, 2, "Vellamanal" },
                    { 166, 2, "Viharapalugama" },
                    { 167, 2, "Wahalkada" },
                    { 168, 2, "Wahamalgollewa" },
                    { 169, 2, "Walagambahuwa" },
                    { 170, 2, "Walahaviddawewa" },
                    { 171, 2, "Welimuwapotana" },
                    { 172, 2, "Welioya Project" },
                    { 173, 3, "Akkarasiyaya" },
                    { 174, 3, "Aluketiyawa" },
                    { 175, 3, "Aluttaramma" },
                    { 176, 3, "Ambadandegama" },
                    { 177, 3, "Ambagasdowa" },
                    { 178, 3, "Arawa" },
                    { 179, 3, "Arawakumbura" },
                    { 180, 3, "Arawatta" },
                    { 181, 3, "Atakiriya" },
                    { 182, 3, "Badulla" },
                    { 183, 3, "Baduluoya" },
                    { 184, 3, "Ballaketuwa" },
                    { 185, 3, "Bambarapana" },
                    { 186, 3, "Bandarawela" },
                    { 187, 3, "Beramada" },
                    { 188, 3, "Bibilegama" },
                    { 189, 3, "Boragas" },
                    { 190, 3, "Boralanda" },
                    { 191, 3, "Bowela" },
                    { 192, 3, "Central Camp" },
                    { 193, 3, "Damanewela" },
                    { 194, 3, "Dambana" },
                    { 195, 3, "Dehiattakandiya" },
                    { 196, 3, "Demodara" },
                    { 197, 3, "Diganatenna" },
                    { 198, 3, "Dikkapitiya" },
                    { 199, 3, "Dimbulana" },
                    { 200, 3, "Divulapelessa" },
                    { 201, 3, "Diyatalawa" },
                    { 202, 3, "Dulgolla" },
                    { 203, 3, "Ekiriyankumbura" },
                    { 204, 3, "Ella" },
                    { 205, 3, "Ettampitiya" },
                    { 206, 3, "Galauda" },
                    { 207, 3, "Galporuyaya" },
                    { 208, 3, "Gawarawela" },
                    { 209, 3, "Girandurukotte" },
                    { 210, 3, "Godunna" },
                    { 211, 3, "Gurutalawa" },
                    { 212, 3, "Haldummulla" },
                    { 213, 3, "Hali Ela" },
                    { 214, 3, "Hangunnawa" },
                    { 215, 3, "Haputale" },
                    { 216, 3, "Hebarawa" },
                    { 217, 3, "Heeloya" },
                    { 218, 3, "Helahalpe" },
                    { 219, 3, "Helapupula" },
                    { 220, 3, "Hopton" },
                    { 221, 3, "Idalgashinna" },
                    { 222, 3, "Kahataruppa" },
                    { 223, 3, "Kalugahakandura" },
                    { 224, 3, "Kalupahana" },
                    { 225, 3, "Kebillawela" },
                    { 226, 3, "Kendagolla" },
                    { 227, 3, "Keselpotha" },
                    { 228, 3, "Ketawatta" },
                    { 229, 3, "Kiriwanagama" },
                    { 230, 3, "Koslanda" },
                    { 231, 3, "Kuruwitenna" },
                    { 232, 3, "Kuttiyagolla" },
                    { 233, 3, "Landewela" },
                    { 234, 3, "Liyangahawela" },
                    { 235, 3, "Lunugala" },
                    { 236, 3, "Lunuwatta" },
                    { 237, 3, "Madulsima" },
                    { 238, 3, "Mahiyanganaya" },
                    { 239, 3, "Makulella" },
                    { 240, 3, "Malgoda" },
                    { 241, 3, "Mapakadawewa" },
                    { 242, 3, "Maspanna" },
                    { 243, 3, "Maussagolla" },
                    { 244, 3, "Mawanagama" },
                    { 245, 3, "Medawela Udukinda" },
                    { 246, 3, "Meegahakiula" },
                    { 247, 3, "Metigahatenna" },
                    { 248, 3, "Mirahawatta" },
                    { 249, 3, "Miriyabedda" },
                    { 250, 3, "Nawamedagama" },
                    { 251, 3, "Nelumgama" },
                    { 252, 3, "Nikapotha" },
                    { 253, 3, "Nugatalawa" },
                    { 254, 3, "Ohiya" },
                    { 255, 3, "Pahalarathkinda" },
                    { 256, 3, "Pallekiruwa" },
                    { 257, 3, "Passara" },
                    { 258, 3, "Pattiyagedara" },
                    { 259, 3, "Pelagahatenna" },
                    { 260, 3, "Perawella" },
                    { 261, 3, "Pitamaruwa" },
                    { 262, 3, "Pitapola" },
                    { 263, 3, "Puhulpola" },
                    { 264, 3, "Rajagalatenna" },
                    { 265, 3, "Ratkarawwa" },
                    { 266, 3, "Ridimaliyadda" },
                    { 267, 3, "Silmiyapura" },
                    { 268, 3, "Sirimalgoda" },
                    { 269, 3, "Siripura" },
                    { 270, 3, "Sorabora Colony" },
                    { 271, 3, "Soragune" },
                    { 272, 3, "Soranatota" },
                    { 273, 3, "Taldena" },
                    { 274, 3, "Timbirigaspitiya" },
                    { 275, 3, "Uduhawara" },
                    { 276, 3, "Uraniya" },
                    { 277, 3, "Uva Karandagolla" },
                    { 278, 3, "Uva Mawelagama" },
                    { 279, 3, "Uva Tenna" },
                    { 280, 3, "Uva Tissapura" },
                    { 281, 3, "Welimada" },
                    { 282, 3, "Werunketagoda" },
                    { 283, 3, "Wewatta" },
                    { 284, 3, "Wineethagama" },
                    { 285, 3, "Yalagamuwa" },
                    { 286, 3, "Yalwela" },
                    { 287, 4, "Addalaichenai" },
                    { 288, 4, "Ampilanthurai" },
                    { 289, 4, "Araipattai" },
                    { 290, 4, "Ayithiyamalai" },
                    { 291, 4, "Bakiella" },
                    { 292, 4, "Batticaloa" },
                    { 293, 4, "Cheddipalayam" },
                    { 294, 4, "Chenkaladi" },
                    { 295, 4, "Eravur" },
                    { 296, 4, "Kaluwanchikudi" },
                    { 297, 4, "Kaluwankemy" },
                    { 298, 4, "Kannankudah" },
                    { 299, 4, "Karadiyanaru" },
                    { 300, 4, "Kathiraveli" },
                    { 301, 4, "Kattankudi" },
                    { 302, 4, "Kiran" },
                    { 303, 4, "Kirankulam" },
                    { 304, 4, "Koddaikallar" },
                    { 305, 4, "Kokkaddichcholai" },
                    { 306, 4, "Kurukkalmadam" },
                    { 307, 4, "Mandur" },
                    { 308, 4, "Miravodai" },
                    { 309, 4, "Murakottanchanai" },
                    { 310, 4, "Navagirinagar" },
                    { 311, 4, "Navatkadu" },
                    { 312, 4, "Oddamavadi" },
                    { 313, 4, "Palamunai" },
                    { 314, 4, "Pankudavely" },
                    { 315, 4, "Periyaporativu" },
                    { 316, 4, "Periyapullumalai" },
                    { 317, 4, "Pillaiyaradi" },
                    { 318, 4, "Punanai" },
                    { 319, 4, "Thannamunai" },
                    { 320, 4, "Thettativu" },
                    { 321, 4, "Thikkodai" },
                    { 322, 4, "Thirupalugamam" },
                    { 323, 4, "Unnichchai" },
                    { 324, 4, "Vakaneri" },
                    { 325, 4, "Vakarai" },
                    { 326, 4, "Valaichenai" },
                    { 327, 4, "Vantharumoolai" },
                    { 328, 4, "Vellavely" },
                    { 329, 5, "Akarawita" },
                    { 330, 5, "Ambalangoda" },
                    { 331, 5, "Athurugiriya" },
                    { 332, 5, "Avissawella" },
                    { 333, 5, "Batawala" },
                    { 334, 5, "Battaramulla" },
                    { 335, 5, "Biyagama" },
                    { 336, 5, "Bope" },
                    { 337, 5, "Boralesgamuwa" },
                    { 338, 5, "Colombo 8" },
                    { 339, 5, "Dedigamuwa" },
                    { 340, 5, "Dehiwala" },
                    { 341, 5, "Deltara" },
                    { 342, 5, "Habarakada" },
                    { 343, 5, "Hanwella" },
                    { 344, 5, "Hiripitya" },
                    { 345, 5, "Hokandara" },
                    { 346, 5, "Homagama" },
                    { 347, 5, "Horagala" },
                    { 348, 5, "Kaduwela" },
                    { 349, 5, "Kaluaggala" },
                    { 350, 5, "Kapugoda" },
                    { 351, 5, "Kehelwatta" },
                    { 352, 5, "Kiriwattuduwa" },
                    { 353, 5, "Kolonnawa" },
                    { 354, 5, "Kosgama" },
                    { 355, 5, "Madapatha" },
                    { 356, 5, "Maharagama" },
                    { 357, 5, "Malabe" },
                    { 358, 5, "Moratuwa" },
                    { 359, 5, "Mount Lavinia" },
                    { 360, 5, "Mullegama" },
                    { 361, 5, "Napawela" },
                    { 362, 5, "Nugegoda" },
                    { 363, 5, "Padukka" },
                    { 364, 5, "Pannipitiya" },
                    { 365, 5, "Piliyandala" },
                    { 366, 5, "Pitipana Homagama" },
                    { 367, 5, "Polgasowita" },
                    { 368, 5, "Pugoda" },
                    { 369, 5, "Ranala" },
                    { 370, 5, "Siddamulla" },
                    { 371, 5, "Siyambalagoda" },
                    { 372, 5, "Sri Jayawardenepu" },
                    { 373, 5, "Talawatugoda" },
                    { 374, 5, "Tummodara" },
                    { 375, 5, "Waga" },
                    { 376, 5, "Colombo 6" },
                    { 377, 6, "Agaliya" },
                    { 378, 6, "Ahangama" },
                    { 379, 6, "Ahungalla" },
                    { 380, 6, "Akmeemana" },
                    { 381, 6, "Alawatugoda" },
                    { 382, 6, "Aluthwala" },
                    { 383, 6, "Ampegama" },
                    { 384, 6, "Amugoda" },
                    { 385, 6, "Anangoda" },
                    { 386, 6, "Angulugaha" },
                    { 387, 6, "Ankokkawala" },
                    { 388, 6, "Aselapura" },
                    { 389, 6, "Baddegama" },
                    { 390, 6, "Balapitiya" },
                    { 391, 6, "Banagala" },
                    { 392, 6, "Batapola" },
                    { 393, 6, "Bentota" },
                    { 394, 6, "Boossa" },
                    { 395, 6, "Dellawa" },
                    { 396, 6, "Dikkumbura" },
                    { 397, 6, "Dodanduwa" },
                    { 398, 6, "Ella Tanabaddegama" },
                    { 399, 6, "Elpitiya" },
                    { 400, 6, "Galle" },
                    { 401, 6, "Ginimellagaha" },
                    { 402, 6, "Gintota" },
                    { 403, 6, "Godahena" },
                    { 404, 6, "Gonamulla Junction" },
                    { 405, 6, "Gonapinuwala" },
                    { 406, 6, "Habaraduwa" },
                    { 407, 6, "Haburugala" },
                    { 408, 6, "Hikkaduwa" },
                    { 409, 6, "Hiniduma" },
                    { 410, 6, "Hiyare" },
                    { 411, 6, "Kahaduwa" },
                    { 412, 6, "Kahawa" },
                    { 413, 6, "Karagoda" },
                    { 414, 6, "Karandeniya" },
                    { 415, 6, "Kosgoda" },
                    { 416, 6, "Kottawagama" },
                    { 417, 6, "Kottegoda" },
                    { 418, 6, "Kuleegoda" },
                    { 419, 6, "Magedara" },
                    { 420, 6, "Mahawela Sinhapura" },
                    { 421, 6, "Mapalagama" },
                    { 422, 6, "Mapalagama Central" },
                    { 423, 6, "Mattaka" },
                    { 424, 6, "Meda-Keembiya" },
                    { 425, 6, "Meetiyagoda" },
                    { 426, 6, "Nagoda" },
                    { 427, 6, "Nakiyadeniya" },
                    { 428, 6, "Nawadagala" },
                    { 429, 6, "Neluwa" },
                    { 430, 6, "Nindana" },
                    { 431, 6, "Pahala Millawa" },
                    { 432, 6, "Panangala" },
                    { 433, 6, "Pannimulla Panagoda" },
                    { 434, 6, "Parana ThanaYamgoda" },
                    { 435, 6, "Patana" },
                    { 436, 6, "Pitigala" },
                    { 437, 6, "Poddala" },
                    { 438, 6, "Polgampola" },
                    { 439, 6, "Porawagama" },
                    { 440, 6, "Rantotuwila" },
                    { 441, 6, "Talagampola" },
                    { 442, 6, "Talgaspe" },
                    { 443, 6, "Talpe" },
                    { 444, 6, "Tawalama" },
                    { 445, 6, "Tiranagama" },
                    { 446, 6, "Udalamatta" },
                    { 447, 6, "Udugama" },
                    { 448, 6, "Uluvitike" },
                    { 449, 6, "Unawatuna" },
                    { 450, 6, "Unenwitiya" },
                    { 451, 6, "Uragaha" },
                    { 452, 6, "Uragasmanhandiya" },
                    { 453, 6, "Wakwella" },
                    { 454, 6, "Walahanduwa" },
                    { 455, 6, "Wanchawela" },
                    { 456, 6, "Wanduramba" },
                    { 457, 6, "Warukandeniya" },
                    { 458, 6, "Watugedara" },
                    { 459, 6, "Weihena" },
                    { 460, 6, "Welikanda" },
                    { 461, 6, "Wilanagama" },
                    { 462, 6, "Yakkalamulla" },
                    { 463, 6, "Yatalamatta" },
                    { 464, 7, "Akaragama" },
                    { 465, 7, "Ambagaspitiya" },
                    { 466, 7, "Ambepussa" },
                    { 467, 7, "Andiambalama" },
                    { 468, 7, "Attanagalla" },
                    { 469, 7, "Badalgama" },
                    { 470, 7, "Banduragoda" },
                    { 471, 7, "Batuwatta" },
                    { 472, 7, "Bemmulla" },
                    { 473, 7, "Biyagama IPZ" },
                    { 474, 7, "Bokalagama" },
                    { 475, 7, "Bollete (WP)" },
                    { 476, 7, "Bopagama" },
                    { 477, 7, "Buthpitiya" },
                    { 478, 7, "Dagonna" },
                    { 479, 7, "Danowita" },
                    { 480, 7, "Debahera" },
                    { 481, 7, "Dekatana" },
                    { 482, 7, "Delgoda" },
                    { 483, 7, "Delwagura" },
                    { 484, 7, "Demalagama" },
                    { 485, 7, "Demanhandiya" },
                    { 486, 7, "Dewalapola" },
                    { 487, 7, "Divulapitiya" },
                    { 488, 7, "Divuldeniya" },
                    { 489, 7, "Dompe" },
                    { 490, 7, "Dunagaha" },
                    { 491, 7, "Ekala" },
                    { 492, 7, "Ellakkala" },
                    { 493, 7, "Essella" },
                    { 494, 7, "Galedanda" },
                    { 495, 7, "Gampaha" },
                    { 496, 7, "Ganemulla" },
                    { 497, 7, "Giriulla" },
                    { 498, 7, "Gonawala" },
                    { 499, 7, "Halpe" },
                    { 500, 7, "Hapugastenna" },
                    { 501, 7, "Heiyanthuduwa" },
                    { 502, 7, "Hinatiyana Madawala" },
                    { 503, 7, "Hiswella" },
                    { 504, 7, "Horampella" },
                    { 505, 7, "Hunumulla" },
                    { 506, 7, "Hunupola" },
                    { 507, 7, "Ihala Madampella" },
                    { 508, 7, "Imbulgoda" },
                    { 509, 7, "Ja-Ela" },
                    { 510, 7, "Kadawatha" },
                    { 511, 7, "Kahatowita" },
                    { 512, 7, "Kalagedihena" },
                    { 513, 7, "Kaleliya" },
                    { 514, 7, "Kandana" },
                    { 515, 7, "Katana" },
                    { 516, 7, "Katudeniya" },
                    { 517, 7, "Katunayake" },
                    { 518, 7, "Katunayake Air Force Camp" },
                    { 519, 7, "Katunayake(FTZ)" },
                    { 520, 7, "Katuwellegama" },
                    { 521, 7, "Kelaniya" },
                    { 522, 7, "Kimbulapitiya" },
                    { 523, 7, "Kirindiwela" },
                    { 524, 7, "Kitalawalana" },
                    { 525, 7, "Kochchikade" },
                    { 526, 7, "Kotadeniyawa" },
                    { 527, 7, "Kotugoda" },
                    { 528, 7, "Kumbaloluwa" },
                    { 529, 7, "Loluwagoda" },
                    { 530, 7, "Mabodale" },
                    { 531, 7, "Madelgamuwa" },
                    { 532, 7, "Makewita" },
                    { 533, 7, "Makola" },
                    { 534, 7, "Malwana" },
                    { 535, 7, "Mandawala" },
                    { 536, 7, "Marandagahamula" },
                    { 537, 7, "Mellawagedara" },
                    { 538, 7, "Minuwangoda" },
                    { 539, 7, "Mirigama" },
                    { 540, 7, "Miriswatta" },
                    { 541, 7, "Mithirigala" },
                    { 542, 7, "Muddaragama" },
                    { 543, 7, "Mudungoda" },
                    { 544, 7, "Mulleriyawa New Town" },
                    { 545, 7, "Naranwala" },
                    { 546, 7, "Nawana" },
                    { 547, 7, "Nedungamuwa" },
                    { 548, 7, "Negombo" },
                    { 549, 7, "Nikadalupotha" },
                    { 550, 7, "Nikahetikanda" },
                    { 551, 7, "Nittambuwa" },
                    { 552, 7, "Niwandama" },
                    { 553, 7, "Opatha" },
                    { 554, 7, "Pamunugama" },
                    { 555, 7, "Pamunuwatta" },
                    { 556, 7, "Panawala" },
                    { 557, 7, "Pasyala" },
                    { 558, 7, "Peliyagoda" },
                    { 559, 7, "Pepiliyawala" },
                    { 560, 7, "Pethiyagoda" },
                    { 561, 7, "Polpithimukulana" },
                    { 562, 7, "Puwakpitiya" },
                    { 563, 7, "Radawadunna" },
                    { 564, 7, "Radawana" },
                    { 565, 7, "Raddolugama" },
                    { 566, 7, "Ragama" },
                    { 567, 7, "Ruggahawila" },
                    { 568, 7, "Seeduwa" },
                    { 569, 7, "Siyambalape" },
                    { 570, 7, "Talahena" },
                    { 571, 7, "Thambagalla" },
                    { 572, 7, "Thimbirigaskatuwa" },
                    { 573, 7, "Tittapattara" },
                    { 574, 7, "Udathuthiripitiya" },
                    { 575, 7, "Udugampola" },
                    { 576, 7, "Uggalboda" },
                    { 577, 7, "Urapola" },
                    { 578, 7, "Uswetakeiyawa" },
                    { 579, 7, "Veyangoda" },
                    { 580, 7, "Walgammulla" },
                    { 581, 7, "Walpita" },
                    { 582, 7, "Walpola (WP)" },
                    { 583, 7, "Wathurugama" },
                    { 584, 7, "Watinapaha" },
                    { 585, 7, "Wattala" },
                    { 586, 7, "Weboda" },
                    { 587, 7, "Wegowwa" },
                    { 588, 7, "Weweldeniya" },
                    { 589, 7, "Yakkala" },
                    { 590, 7, "Yatiyana" },
                    { 591, 8, "Ambalantota" },
                    { 592, 8, "Angunakolapelessa" },
                    { 593, 8, "Angunakolawewa" },
                    { 594, 8, "Bandagiriya Colony" },
                    { 595, 8, "Barawakumbuka" },
                    { 596, 8, "Beliatta" },
                    { 597, 8, "Beragama" },
                    { 598, 8, "Beralihela" },
                    { 599, 8, "Bundala" },
                    { 600, 8, "Ellagala" },
                    { 601, 8, "Gangulandeniya" },
                    { 602, 8, "Getamanna" },
                    { 603, 8, "Goda Koggalla" },
                    { 604, 8, "Gonagamuwa Uduwila" },
                    { 605, 8, "Gonnoruwa" },
                    { 606, 8, "Hakuruwela" },
                    { 607, 8, "Hambantota" },
                    { 608, 8, "Handugala" },
                    { 609, 8, "Hungama" },
                    { 610, 8, "Ihala Beligalla" },
                    { 611, 8, "Ittademaliya" },
                    { 612, 8, "Julampitiya" },
                    { 613, 8, "Kahandamodara" },
                    { 614, 8, "Kariyamaditta" },
                    { 615, 8, "Katuwana" },
                    { 616, 8, "Kawantissapura" },
                    { 617, 8, "Kirama" },
                    { 618, 8, "Kirinda" },
                    { 619, 8, "Lunama" },
                    { 620, 8, "Lunugamwehera" },
                    { 621, 8, "Magama" },
                    { 622, 8, "Mahagalwewa" },
                    { 623, 8, "Mamadala" },
                    { 624, 8, "Medamulana" },
                    { 625, 8, "Middeniya" },
                    { 626, 8, "Migahajandur" },
                    { 627, 8, "Modarawana" },
                    { 628, 8, "Mulkirigala" },
                    { 629, 8, "Nakulugamuwa" },
                    { 630, 8, "Netolpitiya" },
                    { 631, 8, "Nihiluwa" },
                    { 632, 8, "Padawkema" },
                    { 633, 8, "Pahala Andarawewa" },
                    { 634, 8, "Rammalawarapitiya" },
                    { 635, 8, "Ranakeliya" },
                    { 636, 8, "Ranmuduwewa" },
                    { 637, 8, "Ranna" },
                    { 638, 8, "Ratmalwala" },
                    { 639, 8, "Ridiyagama" },
                    { 640, 8, "Sooriyawewa Town" },
                    { 641, 8, "Tangalla" },
                    { 642, 8, "Tissamaharama" },
                    { 643, 8, "Uda Gomadiya" },
                    { 644, 8, "Udamattala" },
                    { 645, 8, "Uswewa" },
                    { 646, 8, "Vitharandeniya" },
                    { 647, 8, "Walasmulla" },
                    { 648, 8, "Weeraketiya" },
                    { 649, 8, "Weerawila" },
                    { 650, 8, "Weerawila NewTown" },
                    { 651, 8, "Wekandawela" },
                    { 652, 8, "Weligatta" },
                    { 653, 8, "Yatigala" },
                    { 654, 9, "Jaffna" },
                    { 655, 10, "Agalawatta" },
                    { 656, 10, "Alubomulla" },
                    { 657, 10, "Anguruwatota" },
                    { 658, 10, "Atale" },
                    { 659, 10, "Baduraliya" },
                    { 660, 10, "Bandaragama" },
                    { 661, 10, "Batugampola" },
                    { 662, 10, "Bellana" },
                    { 663, 10, "Beruwala" },
                    { 664, 10, "Bolossagama" },
                    { 665, 10, "Bombuwala" },
                    { 666, 10, "Boralugoda" },
                    { 667, 10, "Bulathsinhala" },
                    { 668, 10, "Danawala Thiniyawala" },
                    { 669, 10, "Delmella" },
                    { 670, 10, "Dharga Town" },
                    { 671, 10, "Diwalakada" },
                    { 672, 10, "Dodangoda" },
                    { 673, 10, "Dombagoda" },
                    { 674, 10, "Ethkandura" },
                    { 675, 10, "Galpatha" },
                    { 676, 10, "Gamagoda" },
                    { 677, 10, "Gonagalpura" },
                    { 678, 10, "Gonapola Junction" },
                    { 679, 10, "Govinna" },
                    { 680, 10, "Gurulubadda" },
                    { 681, 10, "Halkandawila" },
                    { 682, 10, "Haltota" },
                    { 683, 10, "Halvitigala Colony" },
                    { 684, 10, "Halwala" },
                    { 685, 10, "Halwatura" },
                    { 686, 10, "Handapangoda" },
                    { 687, 10, "Hedigalla Colony" },
                    { 688, 10, "Henegama" },
                    { 689, 10, "Hettimulla" },
                    { 690, 10, "Horana" },
                    { 691, 10, "Ittapana" },
                    { 692, 10, "Kahawala" },
                    { 693, 10, "Kalawila Kiranthidiya" },
                    { 694, 10, "Kalutara" },
                    { 695, 10, "Kananwila" },
                    { 696, 10, "Kandanagama" },
                    { 697, 10, "Kelinkanda" },
                    { 698, 10, "Kitulgoda" },
                    { 699, 10, "Koholana" },
                    { 700, 10, "Kuda Uduwa" },
                    { 701, 10, "Labbala" },
                    { 702, 10, "lhalahewessa" },
                    { 703, 10, "lnduruwa" },
                    { 704, 10, "lngiriya" },
                    { 705, 10, "Maggona" },
                    { 706, 10, "Mahagama" },
                    { 707, 10, "Mahakalupahana" },
                    { 708, 10, "Maharangalla" },
                    { 709, 10, "Malgalla Talangalla" },
                    { 710, 10, "Matugama" },
                    { 711, 10, "Meegahatenna" },
                    { 712, 10, "Meegama" },
                    { 713, 10, "Meegoda" },
                    { 714, 10, "Millaniya" },
                    { 715, 10, "Millewa" },
                    { 716, 10, "Miwanapalana" },
                    { 717, 10, "Molkawa" },
                    { 718, 10, "Morapitiya" },
                    { 719, 10, "Morontuduwa" },
                    { 720, 10, "Nawattuduwa" },
                    { 721, 10, "Neboda" },
                    { 722, 10, "Padagoda" },
                    { 723, 10, "Pahalahewessa" },
                    { 724, 10, "Paiyagala" },
                    { 725, 10, "Panadura" },
                    { 726, 10, "Pannala" },
                    { 727, 10, "Paragastota" },
                    { 728, 10, "Paragoda" },
                    { 729, 10, "Paraigama" },
                    { 730, 10, "Pelanda" },
                    { 731, 10, "Pelawatta" },
                    { 732, 10, "Pimbura" },
                    { 733, 10, "Pitagaldeniya" },
                    { 734, 10, "Pokunuwita" },
                    { 735, 10, "Poruwedanda" },
                    { 736, 10, "Ratmale" },
                    { 737, 10, "Remunagoda" },
                    { 738, 10, "Talgaswela" },
                    { 739, 10, "Tebuwana" },
                    { 740, 10, "Uduwara" },
                    { 741, 10, "Utumgama" },
                    { 742, 10, "Veyangalla" },
                    { 743, 10, "Wadduwa" },
                    { 744, 10, "Walagedara" },
                    { 745, 10, "Walallawita" },
                    { 746, 10, "Waskaduwa" },
                    { 747, 10, "Welipenna" },
                    { 748, 10, "Weliveriya" },
                    { 749, 10, "Welmilla Junction" },
                    { 750, 10, "Weragala" },
                    { 751, 10, "Yagirala" },
                    { 752, 10, "Yatadolawatta" },
                    { 753, 10, "Yatawara Junction" },
                    { 754, 11, "Aludeniya" },
                    { 755, 11, "Ambagahapelessa" },
                    { 756, 11, "Ambagamuwa Udabulathgama" },
                    { 757, 11, "Ambatenna" },
                    { 758, 11, "Ampitiya" },
                    { 759, 11, "Ankumbura" },
                    { 760, 11, "Atabage" },
                    { 761, 11, "Balana" },
                    { 762, 11, "Bambaragahaela" },
                    { 763, 11, "Batagolladeniya" },
                    { 764, 11, "Batugoda" },
                    { 765, 11, "Batumulla" },
                    { 766, 11, "Bawlana" },
                    { 767, 11, "Bopana" },
                    { 768, 11, "Danture" },
                    { 769, 11, "Dedunupitiya" },
                    { 770, 11, "Dekinda" },
                    { 771, 11, "Deltota" },
                    { 772, 11, "Divulankadawala" },
                    { 773, 11, "Dolapihilla" },
                    { 774, 11, "Dolosbage" },
                    { 775, 11, "Dunuwila" },
                    { 776, 11, "Etulgama" },
                    { 777, 11, "Galaboda" },
                    { 778, 11, "Galagedara" },
                    { 779, 11, "Galaha" },
                    { 780, 11, "Galhinna" },
                    { 781, 11, "Gampola" },
                    { 782, 11, "Gelioya" },
                    { 783, 11, "Godamunna" },
                    { 784, 11, "Gomagoda" },
                    { 785, 11, "Gonagantenna" },
                    { 786, 11, "Gonawalapatana" },
                    { 787, 11, "Gunnepana" },
                    { 788, 11, "Gurudeniya" },
                    { 789, 11, "Hakmana" },
                    { 790, 11, "Handaganawa" },
                    { 791, 11, "Handawalapitiya" },
                    { 792, 11, "Handessa" },
                    { 793, 11, "Hanguranketha" },
                    { 794, 11, "Harangalagama" },
                    { 795, 11, "Hataraliyadda" },
                    { 796, 11, "Hindagala" },
                    { 797, 11, "Hondiyadeniya" },
                    { 798, 11, "Hunnasgiriya" },
                    { 799, 11, "Inguruwatta" },
                    { 800, 11, "Jambugahapitiya" },
                    { 801, 11, "Kadugannawa" },
                    { 802, 11, "Kahataliyadda" },
                    { 803, 11, "Kalugala" },
                    { 804, 11, "Kandy" },
                    { 805, 11, "Kapuliyadde" },
                    { 806, 11, "Katugastota" },
                    { 807, 11, "Katukitula" },
                    { 808, 11, "Kelanigama" },
                    { 809, 11, "Kengalla" },
                    { 810, 11, "Ketaboola" },
                    { 811, 11, "Ketakumbura" },
                    { 812, 11, "Kobonila" },
                    { 813, 11, "Kolabissa" },
                    { 814, 11, "Kolongoda" },
                    { 815, 11, "Kulugammana" },
                    { 816, 11, "Kumbukkandura" },
                    { 817, 11, "Kumburegama" },
                    { 818, 11, "Kundasale" },
                    { 819, 11, "Leemagahakotuwa" },
                    { 820, 11, "lhala Kobbekaduwa" },
                    { 821, 11, "Lunugama" },
                    { 822, 11, "Lunuketiya Maditta" },
                    { 823, 11, "Madawala Bazaar" },
                    { 824, 11, "Madawalalanda" },
                    { 825, 11, "Madugalla" },
                    { 826, 11, "Madulkele" },
                    { 827, 11, "Mahadoraliyadda" },
                    { 828, 11, "Mahamedagama" },
                    { 829, 11, "Mahanagapura" },
                    { 830, 11, "Mailapitiya" },
                    { 831, 11, "Makkanigama" },
                    { 832, 11, "Makuldeniya" },
                    { 833, 11, "Mangalagama" },
                    { 834, 11, "Mapakanda" },
                    { 835, 11, "Marassana" },
                    { 836, 11, "Marymount Colony" },
                    { 837, 11, "Mawatura" },
                    { 838, 11, "Medamahanuwara" },
                    { 839, 11, "Medawala Harispattuwa" },
                    { 840, 11, "Meetalawa" },
                    { 841, 11, "Megoda Kalugamuwa" },
                    { 842, 11, "Menikdiwela" },
                    { 843, 11, "Menikhinna" },
                    { 844, 11, "Mimure" },
                    { 845, 11, "Minigamuwa" },
                    { 846, 11, "Minipe" },
                    { 847, 11, "Moragahapallama" },
                    { 848, 11, "Murutalawa" },
                    { 849, 11, "Muruthagahamulla" },
                    { 850, 11, "Nanuoya" },
                    { 851, 11, "Naranpanawa" },
                    { 852, 11, "Narawelpita" },
                    { 853, 11, "Nawalapitiya" },
                    { 854, 11, "Nawathispane" },
                    { 855, 11, "Nillambe" },
                    { 856, 11, "Nugaliyadda" },
                    { 857, 11, "Ovilikanda" },
                    { 858, 11, "Pallekotuwa" },
                    { 859, 11, "Panwilatenna" },
                    { 860, 11, "Paradeka" },
                    { 861, 11, "Pasbage" },
                    { 862, 11, "Pattitalawa" },
                    { 863, 11, "Peradeniya" },
                    { 864, 11, "Pilimatalawa" },
                    { 865, 11, "Poholiyadda" },
                    { 866, 11, "Pubbiliya" },
                    { 867, 11, "Pupuressa" },
                    { 868, 11, "Pussellawa" },
                    { 869, 11, "Putuhapuwa" },
                    { 870, 11, "Rajawella" },
                    { 871, 11, "Rambukpitiya" },
                    { 872, 11, "Rambukwella" },
                    { 873, 11, "Rangala" },
                    { 874, 11, "Rantembe" },
                    { 875, 11, "Sangarajapura" },
                    { 876, 11, "Senarathwela" },
                    { 877, 11, "Talatuoya" },
                    { 878, 11, "Teldeniya" },
                    { 879, 11, "Tennekumbura" },
                    { 880, 11, "Uda Peradeniya" },
                    { 881, 11, "Udahentenna" },
                    { 882, 11, "Udatalawinna" },
                    { 883, 11, "Udispattuwa" },
                    { 884, 11, "Ududumbara" },
                    { 885, 11, "Uduwahinna" },
                    { 886, 11, "Uduwela" },
                    { 887, 11, "Ulapane" },
                    { 888, 11, "Unuwinna" },
                    { 889, 11, "Velamboda" },
                    { 890, 11, "Watagoda" },
                    { 891, 11, "Watagoda Harispattuwa" },
                    { 892, 11, "Wattappola" },
                    { 893, 11, "Weligampola" },
                    { 894, 11, "Wendaruwa" },
                    { 895, 11, "Weragantota" },
                    { 896, 11, "Werapitya" },
                    { 897, 11, "Werellagama" },
                    { 898, 11, "Wettawa" },
                    { 899, 11, "Yahalatenna" },
                    { 900, 11, "Yatihalagala" },
                    { 901, 12, "Alawala" },
                    { 902, 12, "Alawatura" },
                    { 903, 12, "Alawwa" },
                    { 904, 12, "Algama" },
                    { 905, 12, "Alutnuwara" },
                    { 906, 12, "Ambalakanda" },
                    { 907, 12, "Ambulugala" },
                    { 908, 12, "Amitirigala" },
                    { 909, 12, "Ampagala" },
                    { 910, 12, "Anhandiya" },
                    { 911, 12, "Anhettigama" },
                    { 912, 12, "Aranayaka" },
                    { 913, 12, "Aruggammana" },
                    { 914, 12, "Batuwita" },
                    { 915, 12, "Beligala(Sab)" },
                    { 916, 12, "Belihuloya" },
                    { 917, 12, "Berannawa" },
                    { 918, 12, "Bopitiya" },
                    { 919, 12, "Bopitiya (SAB)" },
                    { 920, 12, "Boralankada" },
                    { 921, 12, "Bossella" },
                    { 922, 12, "Bulathkohupitiya" },
                    { 923, 12, "Damunupola" },
                    { 924, 12, "Debathgama" },
                    { 925, 12, "Dedugala" },
                    { 926, 12, "Deewala Pallegama" },
                    { 927, 12, "Dehiowita" },
                    { 928, 12, "Deldeniya" },
                    { 929, 12, "Deloluwa" },
                    { 930, 12, "Deraniyagala" },
                    { 931, 12, "Dewalegama" },
                    { 932, 12, "Dewanagala" },
                    { 933, 12, "Dombemada" },
                    { 934, 12, "Dorawaka" },
                    { 935, 12, "Dunumala" },
                    { 936, 12, "Galapitamada" },
                    { 937, 12, "Galatara" },
                    { 938, 12, "Galigamuwa Town" },
                    { 939, 12, "Gallella" },
                    { 940, 12, "Galpatha(Sab)" },
                    { 941, 12, "Gantuna" },
                    { 942, 12, "Getahetta" },
                    { 943, 12, "Godagampola" },
                    { 944, 12, "Gonagala" },
                    { 945, 12, "Hakahinna" },
                    { 946, 12, "Hakbellawaka" },
                    { 947, 12, "Halloluwa" },
                    { 948, 12, "Hedunuwewa" },
                    { 949, 12, "Hemmatagama" },
                    { 950, 12, "Hewadiwela" },
                    { 951, 12, "Hingula" },
                    { 952, 12, "Hinguralakanda" },
                    { 953, 12, "Hingurana" },
                    { 954, 12, "Hiriwadunna" },
                    { 955, 12, "Ihala Walpola" },
                    { 956, 12, "Ihalagama" },
                    { 957, 12, "Imbulana" },
                    { 958, 12, "Imbulgasdeniya" },
                    { 959, 12, "Kabagamuwa" },
                    { 960, 12, "Kahapathwala" },
                    { 961, 12, "Kandaketya" },
                    { 962, 12, "Kannattota" },
                    { 963, 12, "Karagahinna" },
                    { 964, 12, "Kegalle" },
                    { 965, 12, "Kehelpannala" },
                    { 966, 12, "Ketawala Leula" },
                    { 967, 12, "Kitulgala" },
                    { 968, 12, "Kondeniya" },
                    { 969, 12, "Kotiyakumbura" },
                    { 970, 12, "Lewangama" },
                    { 971, 12, "Mahabage" },
                    { 972, 12, "Makehelwala" },
                    { 973, 12, "Malalpola" },
                    { 974, 12, "Maldeniya" },
                    { 975, 12, "Maliboda" },
                    { 976, 12, "Maliyadda" },
                    { 977, 12, "Malmaduwa" },
                    { 978, 12, "Marapana" },
                    { 979, 12, "Mawanella" },
                    { 980, 12, "Meetanwala" },
                    { 981, 12, "Migastenna Sabara" },
                    { 982, 12, "Miyanawita" },
                    { 983, 12, "Molagoda" },
                    { 984, 12, "Morontota" },
                    { 985, 12, "Narangala" },
                    { 986, 12, "Narangoda" },
                    { 987, 12, "Nattarampotha" },
                    { 988, 12, "Nelundeniya" },
                    { 989, 12, "Niyadurupola" },
                    { 990, 12, "Noori" },
                    { 991, 12, "Pannila" },
                    { 992, 12, "Pattampitiya" },
                    { 993, 12, "Pilawala" },
                    { 994, 12, "Pothukoladeniya" },
                    { 995, 12, "Puswelitenna" },
                    { 996, 12, "Rambukkana" },
                    { 997, 12, "Rilpola" },
                    { 998, 12, "Rukmale" },
                    { 999, 12, "Ruwanwella" },
                    { 1000, 12, "Samanalawewa" },
                    { 1001, 12, "Seaforth Colony" },
                    { 1002, 5, "Colombo 2" },
                    { 1003, 12, "Spring Valley" },
                    { 1004, 12, "Talgaspitiya" },
                    { 1005, 12, "Teligama" },
                    { 1006, 12, "Tholangamuwa" },
                    { 1007, 12, "Thotawella" },
                    { 1008, 12, "Udaha Hawupe" },
                    { 1009, 12, "Udapotha" },
                    { 1010, 12, "Uduwa" },
                    { 1011, 12, "Undugoda" },
                    { 1012, 12, "Ussapitiya" },
                    { 1013, 12, "Wahakula" },
                    { 1014, 12, "Waharaka" },
                    { 1015, 12, "Wanaluwewa" },
                    { 1016, 12, "Warakapola" },
                    { 1017, 12, "Watura" },
                    { 1018, 12, "Weeoya" },
                    { 1019, 12, "Wegalla" },
                    { 1020, 12, "Weligalla" },
                    { 1021, 12, "Welihelatenna" },
                    { 1022, 12, "Wewelwatta" },
                    { 1023, 12, "Yatagama" },
                    { 1024, 12, "Yatapana" },
                    { 1025, 12, "Yatiyantota" },
                    { 1026, 12, "Yattogoda" },
                    { 1027, 13, "Kandavalai" },
                    { 1028, 13, "Karachchi" },
                    { 1029, 13, "Kilinochchi" },
                    { 1030, 13, "Pachchilaipalli" },
                    { 1031, 13, "Poonakary" },
                    { 1032, 14, "Akurana" },
                    { 1033, 14, "Alahengama" },
                    { 1034, 14, "Alahitiyawa" },
                    { 1035, 14, "Ambakote" },
                    { 1036, 14, "Ambanpola" },
                    { 1037, 14, "Andiyagala" },
                    { 1038, 14, "Anukkane" },
                    { 1039, 14, "Aragoda" },
                    { 1040, 14, "Ataragalla" },
                    { 1041, 14, "Awulegama" },
                    { 1042, 14, "Balalla" },
                    { 1043, 14, "Bamunukotuwa" },
                    { 1044, 14, "Bandara Koswatta" },
                    { 1045, 14, "Bingiriya" },
                    { 1046, 14, "Bogamulla" },
                    { 1047, 14, "Boraluwewa" },
                    { 1048, 14, "Boyagane" },
                    { 1049, 14, "Bujjomuwa" },
                    { 1050, 14, "Buluwala" },
                    { 1051, 14, "Dadayamtalawa" },
                    { 1052, 14, "Dambadeniya" },
                    { 1053, 14, "Daraluwa" },
                    { 1054, 14, "Deegalla" },
                    { 1055, 14, "Demataluwa" },
                    { 1056, 14, "Demuwatha" },
                    { 1057, 14, "Diddeniya" },
                    { 1058, 14, "Digannewa" },
                    { 1059, 14, "Divullegoda" },
                    { 1060, 14, "Diyasenpura" },
                    { 1061, 14, "Dodangaslanda" },
                    { 1062, 14, "Doluwa" },
                    { 1063, 14, "Doragamuwa" },
                    { 1064, 14, "Doratiyawa" },
                    { 1065, 14, "Dunumadalawa" },
                    { 1066, 14, "Dunuwilapitiya" },
                    { 1067, 14, "Ehetuwewa" },
                    { 1068, 14, "Elibichchiya" },
                    { 1069, 14, "Embogama" },
                    { 1070, 14, "Etungahakotuwa" },
                    { 1071, 14, "Galadivulwewa" },
                    { 1072, 14, "Galgamuwa" },
                    { 1073, 14, "Gallellagama" },
                    { 1074, 14, "Gallewa" },
                    { 1075, 14, "Ganegoda" },
                    { 1076, 14, "Girathalana" },
                    { 1077, 14, "Gokaralla" },
                    { 1078, 14, "Gonawila" },
                    { 1079, 14, "Halmillawewa" },
                    { 1080, 14, "Handungamuwa" },
                    { 1081, 14, "Harankahawa" },
                    { 1082, 14, "Helamada" },
                    { 1083, 14, "Hengamuwa" },
                    { 1084, 14, "Hettipola" },
                    { 1085, 14, "Hewainna" },
                    { 1086, 14, "Hilogama" },
                    { 1087, 14, "Hindagolla" },
                    { 1088, 14, "Hiriyala Lenawa" },
                    { 1089, 14, "Hiruwalpola" },
                    { 1090, 14, "Horambawa" },
                    { 1091, 14, "Hulogedara" },
                    { 1092, 14, "Hulugalla" },
                    { 1093, 14, "Ihala Gomugomuwa" },
                    { 1094, 14, "Ihala Katugampala" },
                    { 1095, 14, "Indulgodakanda" },
                    { 1096, 14, "Ithanawatta" },
                    { 1097, 14, "Kadigawa" },
                    { 1098, 14, "Kalankuttiya" },
                    { 1099, 14, "Kalatuwawa" },
                    { 1100, 14, "Kalugamuwa" },
                    { 1101, 14, "Kanadeniyawala" },
                    { 1102, 14, "Kanattewewa" },
                    { 1103, 14, "Kandegedara" },
                    { 1104, 14, "Karagahagedara" },
                    { 1105, 14, "Karambe" },
                    { 1106, 14, "Katiyawa" },
                    { 1107, 14, "Katupota" },
                    { 1108, 14, "Kawudulla" },
                    { 1109, 14, "Kawuduluwewa Stagell" },
                    { 1110, 14, "Kekunagolla" },
                    { 1111, 14, "Keppitiwalana" },
                    { 1112, 14, "Kimbulwanaoya" },
                    { 1113, 14, "Kirimetiyawa" },
                    { 1114, 14, "Kirindawa" },
                    { 1115, 14, "Kirindigalla" },
                    { 1116, 14, "Kithalawa" },
                    { 1117, 14, "Kitulwala" },
                    { 1118, 14, "Kobeigane" },
                    { 1119, 14, "Kohilagedara" },
                    { 1120, 14, "Konwewa" },
                    { 1121, 14, "Kosdeniya" },
                    { 1122, 14, "Kosgolla" },
                    { 1123, 14, "Kotagala" },
                    { 1124, 5, "Colombo 13" },
                    { 1125, 14, "Kotawehera" },
                    { 1126, 14, "Kudagalgamuwa" },
                    { 1127, 14, "Kudakatnoruwa" },
                    { 1128, 14, "Kuliyapitiya" },
                    { 1129, 14, "Kumaragama" },
                    { 1130, 14, "Kumbukgeta" },
                    { 1131, 14, "Kumbukwewa" },
                    { 1132, 14, "Kuratihena" },
                    { 1133, 14, "Kurunegala" },
                    { 1134, 14, "lbbagamuwa" },
                    { 1135, 14, "lhala Kadigamuwa" },
                    { 1136, 14, "Lihiriyagama" },
                    { 1137, 14, "lllagolla" },
                    { 1138, 14, "llukhena" },
                    { 1139, 14, "Lonahettiya" },
                    { 1140, 14, "Madahapola" },
                    { 1141, 14, "Madakumburumulla" },
                    { 1142, 14, "Madalagama" },
                    { 1143, 14, "Madawala Ulpotha" },
                    { 1144, 14, "Maduragoda" },
                    { 1145, 14, "Maeliya" },
                    { 1146, 14, "Magulagama" },
                    { 1147, 14, "Maha Ambagaswewa" },
                    { 1148, 14, "Mahagalkadawala" },
                    { 1149, 14, "Mahagirilla" },
                    { 1150, 14, "Mahamukalanyaya" },
                    { 1151, 14, "Mahananneriya" },
                    { 1152, 14, "Mahapallegama" },
                    { 1153, 14, "Maharachchimulla" },
                    { 1154, 14, "Mahatalakolawewa" },
                    { 1155, 14, "Mahawewa" },
                    { 1156, 14, "Maho" },
                    { 1157, 14, "Makulewa" },
                    { 1158, 14, "Makulpotha" },
                    { 1159, 14, "Makulwewa" },
                    { 1160, 14, "Malagane" },
                    { 1161, 14, "Mandapola" },
                    { 1162, 14, "Maspotha" },
                    { 1163, 14, "Mawathagama" },
                    { 1164, 14, "Medirigiriya" },
                    { 1165, 14, "Medivawa" },
                    { 1166, 14, "Meegalawa" },
                    { 1167, 14, "Meegaswewa" },
                    { 1168, 14, "Meewellawa" },
                    { 1169, 14, "Melsiripura" },
                    { 1170, 14, "Metikumbura" },
                    { 1171, 14, "Metiyagane" },
                    { 1172, 14, "Minhettiya" },
                    { 1173, 14, "Minuwangete" },
                    { 1174, 14, "Mirihanagama" },
                    { 1175, 14, "Monnekulama" },
                    { 1176, 14, "Moragane" },
                    { 1177, 14, "Moragollagama" },
                    { 1178, 14, "Morathiha" },
                    { 1179, 14, "Munamaldeniya" },
                    { 1180, 14, "Muruthenge" },
                    { 1181, 14, "Mutugala" },
                    { 1182, 14, "Nabadewa" },
                    { 1183, 14, "Nagollagama" },
                    { 1184, 14, "Nagollagoda" },
                    { 1185, 14, "Nakkawatta" },
                    { 1186, 14, "Narammala" },
                    { 1187, 14, "Nawasenapura" },
                    { 1188, 14, "Nawatalwatta" },
                    { 1189, 14, "Nelliya" },
                    { 1190, 14, "Nikaweratiya" },
                    { 1191, 14, "Nugagolla" },
                    { 1192, 14, "Nugawela" },
                    { 1193, 14, "Padeniya" },
                    { 1194, 14, "Padiwela" },
                    { 1195, 14, "Pahalagiribawa" },
                    { 1196, 14, "Pahamune" },
                    { 1197, 14, "Palagala" },
                    { 1198, 14, "Palapathwela" },
                    { 1199, 14, "Palaviya" },
                    { 1200, 14, "Pallewela" },
                    { 1201, 14, "Palukadawala" },
                    { 1202, 14, "Panadaragama" },
                    { 1203, 14, "Panagamuwa" },
                    { 1204, 14, "Panaliya" },
                    { 1205, 14, "Panapitiya" },
                    { 1206, 14, "Panliyadda" },
                    { 1207, 14, "Pansiyagama" },
                    { 1208, 14, "Parape" },
                    { 1209, 14, "Pathanewatta" },
                    { 1210, 14, "Pattiya Watta" },
                    { 1211, 14, "Perakanatta" },
                    { 1212, 14, "Periyakadneluwa" },
                    { 1213, 14, "Pihimbiya Ratmale" },
                    { 1214, 14, "Pihimbuwa" },
                    { 1215, 14, "Pilessa" },
                    { 1216, 14, "Polgahawela" },
                    { 1217, 14, "Polgolla" },
                    { 1218, 14, "Polpitigama" },
                    { 1219, 14, "Pothuhera" },
                    { 1220, 14, "Pothupitiya" },
                    { 1221, 14, "Pujapitiya" },
                    { 1222, 14, "Rakwana" },
                    { 1223, 14, "Ranorawa" },
                    { 1224, 14, "Rathukohodigala" },
                    { 1225, 14, "Ridibendiella" },
                    { 1226, 14, "Ridigama" },
                    { 1227, 14, "Saliya Asokapura" },
                    { 1228, 14, "Sandalankawa" },
                    { 1229, 14, "Sevanapitiya" },
                    { 1230, 14, "Sirambiadiya" },
                    { 1231, 14, "Sirisetagama" },
                    { 1232, 14, "Siyambalangamuwa" },
                    { 1233, 14, "Siyambalawewa" },
                    { 1234, 14, "Solepura" },
                    { 1235, 14, "Solewewa" },
                    { 1236, 14, "Sunandapura" },
                    { 1237, 14, "Talawattegedara" },
                    { 1238, 14, "Tambutta" },
                    { 1239, 14, "Tennepanguwa" },
                    { 1240, 14, "Thalahitimulla" },
                    { 1241, 14, "Thalakolawewa" },
                    { 1242, 14, "Thalwita" },
                    { 1243, 14, "Tharana Udawela" },
                    { 1244, 14, "Thimbiriyawa" },
                    { 1245, 14, "Tisogama" },
                    { 1246, 14, "Torayaya" },
                    { 1247, 14, "Tulhiriya" },
                    { 1248, 14, "Tuntota" },
                    { 1249, 14, "Tuttiripitigama" },
                    { 1250, 14, "Udagaldeniya" },
                    { 1251, 14, "Udahingulwala" },
                    { 1252, 14, "Udawatta" },
                    { 1253, 14, "Udubaddawa" },
                    { 1254, 14, "Udumulla" },
                    { 1255, 14, "Uhumiya" },
                    { 1256, 14, "Ulpotha Pallekele" },
                    { 1257, 14, "Ulpothagama" },
                    { 1258, 14, "Usgala Siyabmalangamuwa" },
                    { 1259, 14, "Vijithapura" },
                    { 1260, 14, "Wadakada" },
                    { 1261, 14, "Wadumunnegedara" },
                    { 1262, 14, "Walakumburumulla" },
                    { 1263, 14, "Wannigama" },
                    { 1264, 14, "Wannikudawewa" },
                    { 1265, 14, "Wannilhalagama" },
                    { 1266, 14, "Wannirasnayakapura" },
                    { 1267, 14, "Warawewa" },
                    { 1268, 14, "Wariyapola" },
                    { 1269, 14, "Watareka" },
                    { 1270, 14, "Wattegama" },
                    { 1271, 14, "Watuwatta" },
                    { 1272, 14, "Weerapokuna" },
                    { 1273, 14, "Welawa Juncton" },
                    { 1274, 14, "Welipennagahamulla" },
                    { 1275, 14, "Wellagala" },
                    { 1276, 14, "Wellarawa" },
                    { 1277, 14, "Wellawa" },
                    { 1278, 14, "Welpalla" },
                    { 1279, 14, "Wennoruwa" },
                    { 1280, 14, "Weuda" },
                    { 1281, 14, "Wewagama" },
                    { 1282, 14, "Wilgamuwa" },
                    { 1283, 14, "Yakwila" },
                    { 1284, 14, "Yatigaloluwa" },
                    { 1285, 15, "Mannar" },
                    { 1286, 15, "Puthukudiyiruppu" },
                    { 1287, 16, "Akuramboda" },
                    { 1288, 16, "Alawatuwala" },
                    { 1289, 16, "Alwatta" },
                    { 1290, 16, "Ambana" },
                    { 1291, 16, "Aralaganwila" },
                    { 1292, 16, "Ataragallewa" },
                    { 1293, 16, "Bambaragaswewa" },
                    { 1294, 16, "Barawardhana Oya" },
                    { 1295, 16, "Beligamuwa" },
                    { 1296, 16, "Damana" },
                    { 1297, 16, "Dambulla" },
                    { 1298, 16, "Damminna" },
                    { 1299, 16, "Dankanda" },
                    { 1300, 16, "Delwite" },
                    { 1301, 16, "Devagiriya" },
                    { 1302, 16, "Dewahuwa" },
                    { 1303, 16, "Divuldamana" },
                    { 1304, 16, "Dullewa" },
                    { 1305, 16, "Dunkolawatta" },
                    { 1306, 16, "Elkaduwa" },
                    { 1307, 16, "Erawula Junction" },
                    { 1308, 16, "Etanawala" },
                    { 1309, 16, "Galewela" },
                    { 1310, 16, "Galoya Junction" },
                    { 1311, 16, "Gammaduwa" },
                    { 1312, 16, "Gangala Puwakpitiya" },
                    { 1313, 16, "Hasalaka" },
                    { 1314, 16, "Hattota Amuna" },
                    { 1315, 16, "Imbulgolla" },
                    { 1316, 16, "Inamaluwa" },
                    { 1317, 16, "Iriyagolla" },
                    { 1318, 16, "Kaikawala" },
                    { 1319, 16, "Kalundawa" },
                    { 1320, 16, "Kandalama" },
                    { 1321, 16, "Kavudupelella" },
                    { 1322, 16, "Kibissa" },
                    { 1323, 16, "Kiwula" },
                    { 1324, 16, "Kongahawela" },
                    { 1325, 16, "Laggala Pallegama" },
                    { 1326, 16, "Leliambe" },
                    { 1327, 16, "Lenadora" },
                    { 1328, 16, "lhala Halmillewa" },
                    { 1329, 16, "lllukkumbura" },
                    { 1330, 16, "Madipola" },
                    { 1331, 16, "Maduruoya" },
                    { 1332, 16, "Mahawela" },
                    { 1333, 16, "Mananwatta" },
                    { 1334, 16, "Maraka" },
                    { 1335, 16, "Matale" },
                    { 1336, 16, "Melipitiya" },
                    { 1337, 16, "Metihakka" },
                    { 1338, 16, "Millawana" },
                    { 1339, 16, "Muwandeniya" },
                    { 1340, 16, "Nalanda" },
                    { 1341, 16, "Naula" },
                    { 1342, 16, "Opalgala" },
                    { 1343, 16, "Pallepola" },
                    { 1344, 16, "Pimburattewa" },
                    { 1345, 16, "Pulastigama" },
                    { 1346, 16, "Ranamuregama" },
                    { 1347, 16, "Rattota" },
                    { 1348, 16, "Selagama" },
                    { 1349, 16, "Sigiriya" },
                    { 1350, 16, "Sinhagama" },
                    { 1351, 16, "Sungavila" },
                    { 1352, 16, "Talagoda Junction" },
                    { 1353, 16, "Talakiriyagama" },
                    { 1354, 16, "Tamankaduwa" },
                    { 1355, 16, "Udasgiriya" },
                    { 1356, 16, "Udatenna" },
                    { 1357, 16, "Ukuwela" },
                    { 1358, 16, "Wahacotte" },
                    { 1359, 16, "Walawela" },
                    { 1360, 16, "Wehigala" },
                    { 1361, 16, "Welangahawatte" },
                    { 1362, 16, "Wewalawewa" },
                    { 1363, 16, "Yatawatta" },
                    { 1364, 17, "Akuressa" },
                    { 1365, 17, "Alapaladeniya" },
                    { 1366, 17, "Aparekka" },
                    { 1367, 17, "Athuraliya" },
                    { 1368, 17, "Bengamuwa" },
                    { 1369, 17, "Bopagoda" },
                    { 1370, 17, "Dampahala" },
                    { 1371, 17, "Deegala Lenama" },
                    { 1372, 17, "Deiyandara" },
                    { 1373, 17, "Denagama" },
                    { 1374, 17, "Denipitiya" },
                    { 1375, 17, "Deniyaya" },
                    { 1376, 17, "Derangala" },
                    { 1377, 17, "Devinuwara (Dondra)" },
                    { 1378, 17, "Dikwella" },
                    { 1379, 17, "Diyagaha" },
                    { 1380, 17, "Diyalape" },
                    { 1381, 17, "Gandara" },
                    { 1382, 17, "Godapitiya" },
                    { 1383, 17, "Gomilamawarala" },
                    { 1384, 17, "Hawpe" },
                    { 1385, 17, "Horapawita" },
                    { 1386, 17, "Kalubowitiyana" },
                    { 1387, 17, "Kamburugamuwa" },
                    { 1388, 17, "Kamburupitiya" },
                    { 1389, 17, "Karagoda Uyangoda" },
                    { 1390, 17, "Karaputugala" },
                    { 1391, 17, "Karatota" },
                    { 1392, 17, "Kekanadurra" },
                    { 1393, 17, "Kiriweldola" },
                    { 1394, 17, "Kiriwelkele" },
                    { 1395, 17, "Kolawenigama" },
                    { 1396, 17, "Kotapola" },
                    { 1397, 17, "Lankagama" },
                    { 1398, 17, "Makandura" },
                    { 1399, 17, "Maliduwa" },
                    { 1400, 17, "Maramba" },
                    { 1401, 17, "Matara" },
                    { 1402, 17, "Mediripitiya" },
                    { 1403, 17, "Miella" },
                    { 1404, 17, "Mirissa" },
                    { 1405, 17, "Morawaka" },
                    { 1406, 17, "Mulatiyana Junction" },
                    { 1407, 17, "Nadugala" },
                    { 1408, 17, "Naimana" },
                    { 1409, 17, "Palatuwa" },
                    { 1410, 17, "Parapamulla" },
                    { 1411, 17, "Pasgoda" },
                    { 1412, 17, "Penetiyana" },
                    { 1413, 17, "Pitabeddara" },
                    { 1414, 17, "Puhulwella" },
                    { 1415, 17, "Radawela" },
                    { 1416, 17, "Ransegoda" },
                    { 1417, 17, "Rotumba" },
                    { 1418, 17, "Sultanagoda" },
                    { 1419, 17, "Telijjawila" },
                    { 1420, 17, "Thihagoda" },
                    { 1421, 17, "Urubokka" },
                    { 1422, 17, "Urugamuwa" },
                    { 1423, 17, "Urumutta" },
                    { 1424, 17, "Viharahena" },
                    { 1425, 17, "Walakanda" },
                    { 1426, 17, "Walasgala" },
                    { 1427, 17, "Waralla" },
                    { 1428, 17, "Weligama" },
                    { 1429, 17, "Wilpita" },
                    { 1430, 17, "Yatiyana" },
                    { 1431, 18, "Ayiwela" },
                    { 1432, 18, "Badalkumbura" },
                    { 1433, 18, "Baduluwela" },
                    { 1434, 18, "Bakinigahawela" },
                    { 1435, 18, "Balaharuwa" },
                    { 1436, 18, "Bibile" },
                    { 1437, 18, "Buddama" },
                    { 1438, 18, "Buttala" },
                    { 1439, 18, "Dambagalla" },
                    { 1440, 18, "Diyakobala" },
                    { 1441, 18, "Dombagahawela" },
                    { 1442, 18, "Ethimalewewa" },
                    { 1443, 18, "Ettiliwewa" },
                    { 1444, 18, "Galabedda" },
                    { 1445, 18, "Gamewela" },
                    { 1446, 18, "Hambegamuwa" },
                    { 1447, 18, "Hingurukaduwa" },
                    { 1448, 18, "Hulandawa" },
                    { 1449, 18, "Inginiyagala" },
                    { 1450, 18, "Kandaudapanguwa" },
                    { 1451, 18, "Kandawinna" },
                    { 1452, 18, "Kataragama" },
                    { 1453, 18, "Kotagama" },
                    { 1454, 18, "Kotamuduna" },
                    { 1455, 18, "Kotawehera Mankada" },
                    { 1456, 18, "Kudawewa" },
                    { 1457, 18, "Kumbukkana" },
                    { 1458, 18, "Marawa" },
                    { 1459, 18, "Mariarawa" },
                    { 1460, 18, "Medagana" },
                    { 1461, 18, "Medawelagama" },
                    { 1462, 18, "Miyanakandura" },
                    { 1463, 18, "Monaragala" },
                    { 1464, 18, "Moretuwegama" },
                    { 1465, 18, "Nakkala" },
                    { 1466, 18, "Namunukula" },
                    { 1467, 18, "Nannapurawa" },
                    { 1468, 18, "Nelliyadda" },
                    { 1469, 18, "Nilgala" },
                    { 1470, 18, "Obbegoda" },
                    { 1471, 18, "Okkampitiya" },
                    { 1472, 18, "Pangura" },
                    { 1473, 18, "Pitakumbura" },
                    { 1474, 18, "Randeniya" },
                    { 1475, 18, "Ruwalwela" },
                    { 1476, 18, "Sella Kataragama" },
                    { 1477, 18, "Siyambalagune" },
                    { 1478, 18, "Siyambalanduwa" },
                    { 1479, 18, "Suriara" },
                    { 1480, 18, "Tanamalwila" },
                    { 1481, 18, "Uva Gangodagama" },
                    { 1482, 18, "Uva Kudaoya" },
                    { 1483, 18, "Uva Pelwatta" },
                    { 1484, 18, "Warunagama" },
                    { 1485, 18, "Wedikumbura" },
                    { 1486, 18, "Weherayaya Handapanagala" },
                    { 1487, 18, "Wellawaya" },
                    { 1488, 18, "Wilaoya" },
                    { 1489, 18, "Yudaganawa" },
                    { 1490, 19, "Mullativu" },
                    { 1491, 20, "Agarapathana" },
                    { 1492, 20, "Ambatalawa" },
                    { 1493, 20, "Ambewela" },
                    { 1494, 20, "Bogawantalawa" },
                    { 1495, 20, "Bopattalawa" },
                    { 1496, 20, "Dagampitiya" },
                    { 1497, 20, "Dayagama Bazaar" },
                    { 1498, 20, "Dikoya" },
                    { 1499, 20, "Doragala" },
                    { 1500, 20, "Dunukedeniya" },
                    { 1501, 20, "Egodawela" },
                    { 1502, 20, "Ekiriya" },
                    { 1503, 20, "Elamulla" },
                    { 1504, 20, "Ginigathena" },
                    { 1505, 20, "Gonakele" },
                    { 1506, 20, "Haggala" },
                    { 1507, 20, "Halgranoya" },
                    { 1508, 20, "Hangarapitiya" },
                    { 1509, 20, "Hapugastalawa" },
                    { 1510, 20, "Harasbedda" },
                    { 1511, 20, "Hatton" },
                    { 1512, 20, "Hewaheta" },
                    { 1513, 20, "Hitigegama" },
                    { 1514, 20, "Jangulla" },
                    { 1515, 20, "Kalaganwatta" },
                    { 1516, 20, "Kandapola" },
                    { 1517, 20, "Karandagolla" },
                    { 1518, 20, "Keerthi Bandarapura" },
                    { 1519, 20, "Kiribathkumbura" },
                    { 1520, 20, "Kotiyagala" },
                    { 1521, 20, "Kotmale" },
                    { 1522, 20, "Kottellena" },
                    { 1523, 20, "Kumbalgamuwa" },
                    { 1524, 20, "Kumbukwela" },
                    { 1525, 20, "Kurupanawela" },
                    { 1526, 20, "Labukele" },
                    { 1527, 20, "Laxapana" },
                    { 1528, 20, "Lindula" },
                    { 1529, 20, "Madulla" },
                    { 1530, 20, "Mandaram Nuwara" },
                    { 1531, 20, "Maskeliya" },
                    { 1532, 20, "Maswela" },
                    { 1533, 20, "Maturata" },
                    { 1534, 20, "Mipanawa" },
                    { 1535, 20, "Mipilimana" },
                    { 1536, 20, "Morahenagama" },
                    { 1537, 20, "Munwatta" },
                    { 1538, 20, "Nayapana Janapadaya" },
                    { 1539, 20, "Nildandahinna" },
                    { 1540, 20, "Nissanka Uyana" },
                    { 1541, 20, "Norwood" },
                    { 1542, 20, "Nuwara Eliya" },
                    { 1543, 20, "Padiyapelella" },
                    { 1544, 20, "Pallebowala" },
                    { 1545, 20, "Panvila" },
                    { 1546, 20, "Pitawala" },
                    { 1547, 20, "Pundaluoya" },
                    { 1548, 20, "Ramboda" },
                    { 1549, 20, "Rikillagaskada" },
                    { 1550, 20, "Rozella" },
                    { 1551, 20, "Rupaha" },
                    { 1552, 20, "Ruwaneliya" },
                    { 1553, 20, "Santhipura" },
                    { 1554, 20, "Talawakele" },
                    { 1555, 20, "Tawalantenna" },
                    { 1556, 20, "Teripeha" },
                    { 1557, 20, "Udamadura" },
                    { 1558, 20, "Udapussallawa" },
                    { 1559, 20, "Uva Deegalla" },
                    { 1560, 20, "Uva Uduwara" },
                    { 1561, 20, "Uvaparanagama" },
                    { 1562, 20, "Walapane" },
                    { 1563, 20, "Watawala" },
                    { 1564, 20, "Widulipura" },
                    { 1565, 20, "Wijebahukanda" },
                    { 1566, 21, "Attanakadawala" },
                    { 1567, 21, "Bakamuna" },
                    { 1568, 21, "Diyabeduma" },
                    { 1569, 21, "Elahera" },
                    { 1570, 21, "Giritale" },
                    { 1571, 21, "Hingurakdamana" },
                    { 1572, 21, "Hingurakgoda" },
                    { 1573, 21, "Jayanthipura" },
                    { 1574, 21, "Kalingaela" },
                    { 1575, 21, "Lakshauyana" },
                    { 1576, 21, "Mankemi" },
                    { 1577, 21, "Minneriya" },
                    { 1578, 21, "Onegama" },
                    { 1579, 21, "Orubendi Siyambalawa" },
                    { 1580, 21, "Palugasdamana" },
                    { 1581, 21, "Panichankemi" },
                    { 1582, 21, "Polonnaruwa" },
                    { 1583, 21, "Talpotha" },
                    { 1584, 21, "Tambala" },
                    { 1585, 21, "Unagalavehera" },
                    { 1586, 21, "Wijayabapura" },
                    { 1587, 22, "Adippala" },
                    { 1588, 22, "Alutgama" },
                    { 1589, 22, "Alutwewa" },
                    { 1590, 22, "Ambakandawila" },
                    { 1591, 22, "Anamaduwa" },
                    { 1592, 22, "Andigama" },
                    { 1593, 22, "Angunawila" },
                    { 1594, 22, "Attawilluwa" },
                    { 1595, 22, "Bangadeniya" },
                    { 1596, 22, "Baranankattuwa" },
                    { 1597, 22, "Battuluoya" },
                    { 1598, 22, "Bujjampola" },
                    { 1599, 22, "Chilaw" },
                    { 1600, 22, "Dalukana" },
                    { 1601, 22, "Dankotuwa" },
                    { 1602, 22, "Dewagala" },
                    { 1603, 22, "Dummalasuriya" },
                    { 1604, 22, "Dunkannawa" },
                    { 1605, 22, "Eluwankulama" },
                    { 1606, 22, "Ettale" },
                    { 1607, 22, "Galamuna" },
                    { 1608, 22, "Galmuruwa" },
                    { 1609, 22, "Hansayapalama" },
                    { 1610, 22, "Ihala Kottaramulla" },
                    { 1611, 22, "Ilippadeniya" },
                    { 1612, 22, "Inginimitiya" },
                    { 1613, 22, "Ismailpuram" },
                    { 1614, 22, "Jayasiripura" },
                    { 1615, 22, "Kakkapalliya" },
                    { 1616, 22, "Kalkudah" },
                    { 1617, 22, "Kalladiya" },
                    { 1618, 22, "Kandakuliya" },
                    { 1619, 22, "Karathivu" },
                    { 1620, 22, "Karawitagara" },
                    { 1621, 22, "Karuwalagaswewa" },
                    { 1622, 22, "Katuneriya" },
                    { 1623, 22, "Koswatta" },
                    { 1624, 22, "Kottantivu" },
                    { 1625, 22, "Kottapitiya" },
                    { 1626, 22, "Kottukachchiya" },
                    { 1627, 22, "Kumarakattuwa" },
                    { 1628, 22, "Kurinjanpitiya" },
                    { 1629, 22, "Kuruketiyawa" },
                    { 1630, 22, "Lunuwila" },
                    { 1631, 22, "Madampe" },
                    { 1632, 22, "Madurankuliya" },
                    { 1633, 22, "Mahakumbukkadawala" },
                    { 1634, 22, "Mahauswewa" },
                    { 1635, 22, "Mampitiya" },
                    { 1636, 22, "Mampuri" },
                    { 1637, 22, "Mangalaeliya" },
                    { 1638, 22, "Marawila" },
                    { 1639, 22, "Mudalakkuliya" },
                    { 1640, 22, "Mugunuwatawana" },
                    { 1641, 22, "Mukkutoduwawa" },
                    { 1642, 22, "Mundel" },
                    { 1643, 22, "Muttibendiwila" },
                    { 1644, 22, "Nainamadama" },
                    { 1645, 22, "Nalladarankattuwa" },
                    { 1646, 22, "Nattandiya" },
                    { 1647, 22, "Nawagattegama" },
                    { 1648, 22, "Nelumwewa" },
                    { 1649, 22, "Norachcholai" },
                    { 1650, 22, "Pallama" },
                    { 1651, 22, "Palliwasalturai" },
                    { 1652, 22, "Panirendawa" },
                    { 1653, 22, "Parakramasamudraya" },
                    { 1654, 22, "Pothuwatawana" },
                    { 1655, 22, "Puttalam" },
                    { 1656, 22, "Puttalam Cement Factory" },
                    { 1657, 22, "Rajakadaluwa" },
                    { 1658, 22, "Saliyawewa Junction" },
                    { 1659, 22, "Serukele" },
                    { 1660, 22, "Siyambalagashene" },
                    { 1661, 22, "Tabbowa" },
                    { 1662, 22, "Talawila Church" },
                    { 1663, 22, "Toduwawa" },
                    { 1664, 22, "Udappuwa" },
                    { 1665, 22, "Uridyawa" },
                    { 1666, 22, "Vanathawilluwa" },
                    { 1667, 22, "Waikkal" },
                    { 1668, 22, "Watugahamulla" },
                    { 1669, 22, "Wennappuwa" },
                    { 1670, 22, "Wijeyakatupotha" },
                    { 1671, 22, "Wilpotha" },
                    { 1672, 22, "Yodaela" },
                    { 1673, 22, "Yogiyana" },
                    { 1674, 23, "Akarella" },
                    { 1675, 23, "Amunumulla" },
                    { 1676, 23, "Atakalanpanna" },
                    { 1677, 23, "Ayagama" },
                    { 1678, 23, "Balangoda" },
                    { 1679, 23, "Batatota" },
                    { 1680, 23, "Beralapanathara" },
                    { 1681, 23, "Bogahakumbura" },
                    { 1682, 23, "Bolthumbe" },
                    { 1683, 23, "Bomluwageaina" },
                    { 1684, 23, "Bowalagama" },
                    { 1685, 23, "Bulutota" },
                    { 1686, 23, "Dambuluwana" },
                    { 1687, 23, "Daugala" },
                    { 1688, 23, "Dela" },
                    { 1689, 23, "Delwala" },
                    { 1690, 23, "Dodampe" },
                    { 1691, 23, "Doloswalakanda" },
                    { 1692, 23, "Dumbara Manana" },
                    { 1693, 23, "Eheliyagoda" },
                    { 1694, 23, "Ekamutugama" },
                    { 1695, 23, "Elapatha" },
                    { 1696, 23, "Ellagawa" },
                    { 1697, 23, "Ellaulla" },
                    { 1698, 23, "Ellawala" },
                    { 1699, 23, "Embilipitiya" },
                    { 1700, 23, "Eratna" },
                    { 1701, 23, "Erepola" },
                    { 1702, 23, "Gabbela" },
                    { 1703, 23, "Gangeyaya" },
                    { 1704, 23, "Gawaragiriya" },
                    { 1705, 23, "Gillimale" },
                    { 1706, 23, "Godakawela" },
                    { 1707, 23, "Gurubewilagama" },
                    { 1708, 23, "Halwinna" },
                    { 1709, 23, "Handagiriya" },
                    { 1710, 23, "Hatangala" },
                    { 1711, 23, "Hatarabage" },
                    { 1712, 23, "Hewanakumbura" },
                    { 1713, 23, "Hidellana" },
                    { 1714, 23, "Hiramadagama" },
                    { 1715, 23, "Horewelagoda" },
                    { 1716, 23, "Ittakanda" },
                    { 1717, 23, "Kahangama" },
                    { 1718, 23, "Kahawatta" },
                    { 1719, 23, "Kalawana" },
                    { 1720, 23, "Kaltota" },
                    { 1721, 23, "Kalubululanda" },
                    { 1722, 23, "Kananke Bazaar" },
                    { 1723, 23, "Kandepuhulpola" },
                    { 1724, 23, "Karandana" },
                    { 1725, 23, "Karangoda" },
                    { 1726, 23, "Kella Junction" },
                    { 1727, 23, "Keppetipola" },
                    { 1728, 23, "Kiriella" },
                    { 1729, 23, "Kiriibbanwewa" },
                    { 1730, 23, "Kolambageara" },
                    { 1731, 23, "Kolombugama" },
                    { 1732, 23, "Kolonna" },
                    { 1733, 23, "Kudawa" },
                    { 1734, 23, "Kuruwita" },
                    { 1735, 23, "Lellopitiya" },
                    { 1736, 23, "lmaduwa" },
                    { 1737, 23, "lmbulpe" },
                    { 1738, 23, "Mahagama Colony" },
                    { 1739, 23, "Mahawalatenna" },
                    { 1740, 23, "Makandura Sabara" },
                    { 1741, 23, "Malwala Junction" },
                    { 1742, 23, "Malwatta" },
                    { 1743, 23, "Matuwagalagama" },
                    { 1744, 23, "Medagalatur" },
                    { 1745, 23, "Meddekanda" },
                    { 1746, 23, "Minipura Dumbara" },
                    { 1747, 23, "Mitipola" },
                    { 1748, 23, "Moragala Kirillapone" },
                    { 1749, 23, "Morahela" },
                    { 1750, 23, "Mulendiyawala" },
                    { 1751, 23, "Mulgama" },
                    { 1752, 23, "Nawalakanda" },
                    { 1753, 23, "NawinnaPinnakanda" },
                    { 1754, 23, "Niralagama" },
                    { 1755, 23, "Nivitigala" },
                    { 1756, 23, "Omalpe" },
                    { 1757, 23, "Opanayaka" },
                    { 1758, 23, "Padalangala" },
                    { 1759, 23, "Pallebedda" },
                    { 1760, 23, "Pallekanda" },
                    { 1761, 23, "Pambagolla" },
                    { 1762, 23, "Panamura" },
                    { 1763, 23, "Panapola" },
                    { 1764, 23, "Paragala" },
                    { 1765, 23, "Parakaduwa" },
                    { 1766, 23, "Pebotuwa" },
                    { 1767, 23, "Pelmadulla" },
                    { 1768, 23, "Pinnawala" },
                    { 1769, 23, "Pothdeniya" },
                    { 1770, 23, "Rajawaka" },
                    { 1771, 23, "Ranwala" },
                    { 1772, 23, "Rassagala" },
                    { 1773, 23, "Ratgama" },
                    { 1774, 23, "Ratna Hangamuwa" },
                    { 1775, 23, "Ratnapura" },
                    { 1776, 23, "Sewanagala" },
                    { 1777, 23, "Sri Palabaddala" },
                    { 1778, 23, "Sudagala" },
                    { 1779, 23, "Talakolahinna" },
                    { 1780, 23, "Tanjantenna" },
                    { 1781, 23, "Teppanawa" },
                    { 1782, 23, "Tunkama" },
                    { 1783, 23, "Udakarawita" },
                    { 1784, 23, "Udaniriella" },
                    { 1785, 23, "Udawalawe" },
                    { 1786, 23, "Ullinduwawa" },
                    { 1787, 23, "Veddagala" },
                    { 1788, 23, "Vijeriya" },
                    { 1789, 23, "Waleboda" },
                    { 1790, 23, "Watapotha" },
                    { 1791, 23, "Waturawa" },
                    { 1792, 23, "Weligepola" },
                    { 1793, 23, "Welipathayaya" },
                    { 1794, 23, "Wikiliya" },
                    { 1795, 24, "Agbopura" },
                    { 1796, 24, "Buckmigama" },
                    { 1797, 24, "China Bay" },
                    { 1798, 24, "Dehiwatte" },
                    { 1799, 24, "Echchilampattai" },
                    { 1800, 24, "Galmetiyawa" },
                    { 1801, 24, "Gomarankadawala" },
                    { 1802, 24, "Kaddaiparichchan" },
                    { 1803, 24, "Kallar" },
                    { 1804, 24, "Kanniya" },
                    { 1805, 24, "Kantalai" },
                    { 1806, 24, "Kantalai Sugar Factory" },
                    { 1807, 24, "Kiliveddy" },
                    { 1808, 24, "Kinniya" },
                    { 1809, 24, "Kuchchaveli" },
                    { 1810, 24, "Kumburupiddy" },
                    { 1811, 24, "Kurinchakemy" },
                    { 1812, 24, "Lankapatuna" },
                    { 1813, 24, "Mahadivulwewa" },
                    { 1814, 24, "Maharugiramam" },
                    { 1815, 24, "Mallikativu" },
                    { 1816, 24, "Mawadichenai" },
                    { 1817, 24, "Mullipothana" },
                    { 1818, 24, "Mutur" },
                    { 1819, 24, "Neelapola" },
                    { 1820, 24, "Nilaveli" },
                    { 1821, 24, "Pankulam" },
                    { 1822, 24, "Pulmoddai" },
                    { 1823, 24, "Rottawewa" },
                    { 1824, 24, "Sampaltivu" },
                    { 1825, 24, "Sampoor" },
                    { 1826, 24, "Serunuwara" },
                    { 1827, 24, "Seruwila" },
                    { 1828, 24, "Sirajnagar" },
                    { 1829, 24, "Somapura" },
                    { 1830, 24, "Tampalakamam" },
                    { 1831, 24, "Thuraineelavanai" },
                    { 1832, 24, "Tiriyayi" },
                    { 1833, 24, "Toppur" },
                    { 1834, 24, "Trincomalee" },
                    { 1835, 24, "Wanela" },
                    { 1836, 25, "Vavuniya" },
                    { 1837, 5, "Colombo 1" },
                    { 1838, 5, "Colombo 3" },
                    { 1839, 5, "Colombo 4" },
                    { 1840, 5, "Colombo 5" },
                    { 1841, 5, "Colombo 7" },
                    { 1842, 5, "Colombo 9" },
                    { 1843, 5, "Colombo 10" },
                    { 1844, 5, "Colombo 11" },
                    { 1845, 5, "Colombo 12" },
                    { 1846, 5, "Colombo 14" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Emp_Address", "Emp_Cid", "Emp_DateOfBirth", "Emp_Department_id", "Emp_Email", "Emp_Gender_id", "Emp_Is_active", "Emp_NIC", "Emp_contact_info", "Emp_dp", "Emp_full_name", "Emp_job_title_id", "Emp_start_date" },
                values: new object[,]
                {
                    { 1, "20403 Bunker Hill Lane", "509280", new DateTime(1972, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "admin@gmail.com", 2, 1, 654654646, "190-481-6403", "Crimson", "Dinindu Kavinda", 7, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "05080 Village Place", "583367", new DateTime(1973, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 1, 1, 654654646, "231-972-7579", "Red", "Arabele Millwater", 7, new DateTime(2016, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "81 Carioca Lane", "751033", new DateTime(1971, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 2, 1, 654654646, "299-264-5583", "Mauv", "Karen Solomon", 1, new DateTime(2012, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "94 Towne Avenue", "239178", new DateTime(1966, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 1, 2, 654654646, "496-189-7339", "Blue", "Seamus Yeoman", 6, new DateTime(2012, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "59664 Gina Crossing", "663442", new DateTime(1988, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 1, 654654646, "260-523-1239", "Goldenrod", "Vincenty Frankcombe", 10, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "9979 Vernon Street", "723826", new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 1, 2, 654654646, "773-437-6039", "Fuscia", "Tybalt Alldridge", 8, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "0 7th Place", "332886", new DateTime(1971, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 1, 2, 654654646, "250-398-3300", "Puce", "Amye Adcock", 4, new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "92 Pawling Alley", "681434", new DateTime(1988, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, 2, 654654646, "752-372-2010", "Aquamarine", "Frasier Shrigley", 2, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "63 Manley Terrace", "857369", new DateTime(1983, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 2, 2, 654654646, "512-765-9897", "Red", "Magda Spraberry", 4, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "9 Caliangt Pass", "637020", new DateTime(1961, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, 1, 654654646, "426-464-2982", "Purple", "Maressa Gheorghe", 10, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "114 Bonner Center", "685841", new DateTime(1967, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, 2, 654654646, "100-113-6495", "Fuscia", "Bambie Selbie", 6, new DateTime(2017, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "0658 Artisan Drive", "728440", new DateTime(1965, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 2, 1, 654654646, "850-277-8474", "Aquamarine", "Darwin Callington", 8, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "2305 Stuart Drive", "672909", new DateTime(1998, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 1, 654654646, "255-334-1273", "Yellow", "Basilio Longhi", 8, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "574 Gulseth Crossing", "275978", new DateTime(1983, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 1, 654654646, "157-963-7726", "Violet", "Hewet Sorrell", 1, new DateTime(2016, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "06 Mayfield Junction", "466923", new DateTime(1964, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, 1, 654654646, "831-374-8100", "Violet", "Dorothea Cantera", 9, new DateTime(2015, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Customer_Address", "Customer_CityId", "Customer_Contact_No", "Customer_Name", "Customer_Road", "Customer_Shop_Name" },
                values: new object[,]
                {
                    { 1, "Address1", 1, "1234567890", "Customer1", "Road1", "Shop1" },
                    { 2, "Address2", 2, "2345678901", "Customer2", "Road2", "Shop2" },
                    { 3, "Address3", 3, "3456789012", "Customer3", "Road3", "Shop3" },
                    { 4, "Address4", 4, "4567890123", "Customer4", "Road4", "Shop4" },
                    { 5, "Address5", 5, "5678901234", "Customer5", "Road5", "Shop5" },
                    { 6, "Address6", 6, "6789012345", "Customer6", "Road6", "Shop6" },
                    { 7, "Address7", 7, "7890123456", "Customer7", "Road7", "Shop7" },
                    { 8, "Address8", 8, "8901234567", "Customer8", "Road8", "Shop8" },
                    { 9, "Address9", 9, "9012345678", "Customer9", "Road9", "Shop9" },
                    { 10, "Address10", 10, "0123456789", "Customer10", "Road10", "Shop10" }
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
                name: "IX_AspNetUsers_User_Employee_Id",
                table: "AspNetUsers",
                column: "User_Employee_Id");

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
                name: "IX_Cities_DistrictId",
                table: "Cities",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Customer_CityId",
                table: "Customers",
                column: "Customer_CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

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
                name: "IX_OrderFormProducts_OrderForm_Id",
                table: "OrderFormProducts",
                column: "OrderForm_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderFormProducts_ProductId",
                table: "OrderFormProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderForms_CustomerId",
                table: "OrderForms",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderForms_SalesExecutiveId",
                table: "OrderForms",
                column: "SalesExecutiveId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderForms_StatusId",
                table: "OrderForms",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PayRolls_EmployeeID",
                table: "PayRolls",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesExecutives_EmployeeId",
                table: "SalesExecutives",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WhereHouses_ProductId",
                table: "WhereHouses",
                column: "ProductId");
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
                name: "OrderFormProducts");

            migrationBuilder.DropTable(
                name: "PayRolls");

            migrationBuilder.DropTable(
                name: "WhereHouses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "OrderForms");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SalesExecutives");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "SalaryTypes");
        }
    }
}
