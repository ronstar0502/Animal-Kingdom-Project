using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class commentUpgrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CommentDate",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 1,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 2,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 3,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 4,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 5,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 6,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 7,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 8,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 9,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 10,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 11,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 12,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 13,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 14,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 15,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 16,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 17,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 18,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 19,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 20,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 21,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 22,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 23,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 24,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 25,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 26,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 27,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 28,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 29,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 30,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 31,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 32,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 33,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 34,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 35,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 36,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 37,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 38,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 39,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 40,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 41,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 42,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 43,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 44,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 45,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 46,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 47,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 48,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 49,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 50,
                columns: new[] { "CommentDate", "Likes" },
                values: new object[] { null, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Comments");
        }
    }
}
