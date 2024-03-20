using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class InitializerForVehiclesChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Service_By",
                table: "VehicleServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Maintain_By",
                table: "VehicleMaintains",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service_By",
                table: "VehicleServices");

            migrationBuilder.AlterColumn<int>(
                name: "Maintain_By",
                table: "VehicleMaintains",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
