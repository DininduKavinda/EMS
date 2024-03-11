using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class InitializerForOutlet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Outlets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Outlet_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Outlet_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outlets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Outlets");
        }
    }
}
