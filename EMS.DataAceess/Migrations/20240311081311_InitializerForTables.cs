using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class InitializerForTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sign_Image",
                table: "OrderForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sign_Image",
                table: "OrderForms");
        }
    }
}
