using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class thirdStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
