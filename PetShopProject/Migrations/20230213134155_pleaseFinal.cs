using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class pleaseFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "ImageName",
                value: "Images\\PoisonDart.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                column: "ImageName",
                value: "Images\\LionFish.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12,
                column: "ImageName",
                value: "Images\\Alligator.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13,
                column: "ImageName",
                value: "Images\\FireSalamder.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "ImageName",
                value: "Images\\Poison-Dart.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                column: "ImageName",
                value: "Images\\Lion-Fish.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12,
                column: "ImageName",
                value: "Images\\American-Alligator.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13,
                column: "ImageName",
                value: "Images\\Fire-Salamder.jpg");
        }
    }
}
