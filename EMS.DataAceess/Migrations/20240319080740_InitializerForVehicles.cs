using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class InitializerForVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleImage",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "VehicleInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Last_Insurance_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Next_Insurance_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Insurance_Cost = table.Column<int>(type: "int", nullable: false),
                    InsuranceImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleInsurances_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Last_License_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Next_License_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    License_Cost = table.Column<int>(type: "int", nullable: false),
                    LisenceImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleLicenses_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleMaintains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Maintain_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maintain_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Maintain_Cost = table.Column<int>(type: "int", nullable: false),
                    Maintain_Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maintain_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maintain_By = table.Column<int>(type: "int", nullable: false),
                    MaintainImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMaintains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleMaintains_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Next_Service_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Service_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Service_Cost = table.Column<int>(type: "int", nullable: false),
                    ServiceImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleServices_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInsurances_VehicleId",
                table: "VehicleInsurances",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLicenses_VehicleId",
                table: "VehicleLicenses",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaintains_VehicleId",
                table: "VehicleMaintains",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleServices_VehicleId",
                table: "VehicleServices",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleInsurances");

            migrationBuilder.DropTable(
                name: "VehicleLicenses");

            migrationBuilder.DropTable(
                name: "VehicleMaintains");

            migrationBuilder.DropTable(
                name: "VehicleServices");

            migrationBuilder.DropColumn(
                name: "VehicleImage",
                table: "Vehicles");
        }
    }
}
