using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class InitializerForSeedDBP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistributionPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionPoints", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DistributionPoints",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "No 18, New Parliment Road, Pelawatta", "+94 112 589 268", "Pelawatta" },
                    { 2, "No 18, New Parliment Road, Pelawatta", "+94 112 589 268", "Weliweriya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistributionPoints");
        }
    }
}
