using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class fourthstep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Categories_categoryId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_categoryId",
                table: "Animals");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_categoryId",
                table: "Animals",
                column: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Categories_categoryId",
                table: "Animals",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
