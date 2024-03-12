using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMS.DataAceess.Migrations
{
    /// <inheritdoc />
    public partial class InitializerForSeedOutlet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Outlets",
                columns: new[] { "Id", "Contact_number", "Email", "OpeningHours", "Outlet_Address", "Outlet_Name" },
                values: new object[,]
                {
                    { 1, "+94 112 589 268", "thamesdec@yahoo.com", "8.00 am - 5.30 pm", "No 18, New Parliment Road, Pelawatta", "Pelawatta" },
                    { 2, "+94 112 589 268", "thamesdec@yahoo.com", "8.00 am - 5.30 pm", "No 18, New Parliment Road, Pelawatta", "Kiribathgoda" },
                    { 3, "+94 112 589 268", "thamesdec@yahoo.com", "8.00 am - 5.30 pm", "No 18, New Parliment Road, Pelawatta", "Malabe" },
                    { 4, "+94 112 589 268", "thamesdec@yahoo.com", "8.00 am - 5.30 pm", "No 18, New Parliment Road, Pelawatta", "Kirindiwela" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Outlets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Outlets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Outlets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Outlets",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
