using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class eigthStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalComment");

            migrationBuilder.AddColumn<int>(
                name: "AnimalsAnimalId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnimalsAnimalId",
                table: "Comments",
                column: "AnimalsAnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalsAnimalId",
                table: "Comments",
                column: "AnimalsAnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalsAnimalId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AnimalsAnimalId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AnimalsAnimalId",
                table: "Comments");

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
                name: "IX_AnimalComment_CommentscommentId",
                table: "AnimalComment",
                column: "CommentscommentId");
        }
    }
}
