using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class fithStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalCategory");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Animals");

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AnimalId",
                table: "Categories",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Animals_AnimalId",
                table: "Categories",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Animals_AnimalId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AnimalId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AnimalCategory",
                columns: table => new
                {
                    AnimalsAnimalId = table.Column<int>(type: "int", nullable: false),
                    CategoriescategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalCategory", x => new { x.AnimalsAnimalId, x.CategoriescategoryId });
                    table.ForeignKey(
                        name: "FK_AnimalCategory_Animals_AnimalsAnimalId",
                        column: x => x.AnimalsAnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalCategory_Categories_CategoriescategoryId",
                        column: x => x.CategoriescategoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalCategory_CategoriescategoryId",
                table: "AnimalCategory",
                column: "CategoriescategoryId");
        }
    }
}
