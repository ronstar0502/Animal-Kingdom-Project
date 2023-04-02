using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class seventhStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Animals_AnimalId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AnimalId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AnimalId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "CommentId",
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

            migrationBuilder.CreateTable(
                name: "AnimalComment",
                columns: table => new
                {
                    AnimalsAnimalId = table.Column<int>(type: "int", nullable: false),
                    CommentscommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalComment", x => new { x.AnimalsAnimalId, x.CommentscommentId });
                    table.ForeignKey(
                        name: "FK_AnimalComment_Animals_AnimalsAnimalId",
                        column: x => x.AnimalsAnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalComment_Comments_CommentscommentId",
                        column: x => x.CommentscommentId,
                        principalTable: "Comments",
                        principalColumn: "commentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalCategory_CategoriescategoryId",
                table: "AnimalCategory",
                column: "CategoriescategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalComment_CommentscommentId",
                table: "AnimalComment",
                column: "CommentscommentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalCategory");

            migrationBuilder.DropTable(
                name: "AnimalComment");

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnimalId",
                table: "Comments",
                column: "AnimalId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId");
        }
    }
}
