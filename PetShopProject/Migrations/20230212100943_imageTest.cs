using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class imageTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "ImageName",
                value: "\\Images\\Orca.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "ImageName",
                value: "/Images/Orca.jpg");
        }
    }
}
