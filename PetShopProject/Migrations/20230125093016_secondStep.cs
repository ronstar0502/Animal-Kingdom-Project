using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class secondStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Animals");
        }
    }
}
