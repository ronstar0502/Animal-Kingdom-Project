using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class finalStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "AnimalCategory");

            migrationBuilder.DropColumn(
                name: "Description",
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

            migrationBuilder.AddColumn<string>(
                name: "CommentText",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Categories_CategoryId",
                table: "Animals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Categories_CategoryId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "CommentText",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Animals_AnimalId",
                table: "Comments",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId");
        }
    }
}
