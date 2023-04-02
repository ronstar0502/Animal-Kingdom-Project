using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class eigth2Step : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalsAnimalId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "AnimalsAnimalId",
                table: "Comments",
                newName: "AnimalId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AnimalsAnimalId",
                table: "Comments",
                newName: "IX_Comments_AnimalId");

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

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "Comments",
                newName: "AnimalsAnimalId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AnimalId",
                table: "Comments",
                newName: "IX_Comments_AnimalsAnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalsAnimalId",
                table: "Comments",
                column: "AnimalsAnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId");
        }
    }
}
