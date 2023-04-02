using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class imageContentDataChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "ImageName",
                value: "/Images/Orca.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "ImageName",
                value: "/Images/KomodoDragon.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "ImageName",
                value: "/Images/Zebra.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "ImageName", "Name" },
                values: new object[] { "/Images/Shark.jpg", "Great White Shark" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "ImageName",
                value: "/Images/Toucan.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "ImageName",
                value: "/Images/Poison-Dart.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "ImageName",
                value: "/Images/Cobra.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8,
                column: "ImageName",
                value: "/Images/Lion.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9,
                column: "ImageName",
                value: "/Images/Kangaroo.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                column: "ImageName",
                value: "/Images/Lion-Fish.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11,
                column: "ImageName",
                value: "/Images/Swan.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12,
                column: "ImageName",
                value: "/Images/America-Alligator.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13,
                column: "ImageName",
                value: "/Images/Fire-Salamder.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14,
                column: "ImageName",
                value: "/Images/mahi.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15,
                column: "ImageName",
                value: "/Images/Eagle.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16,
                column: "ImageName",
                value: "/Images/PolarBear.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17,
                column: "ImageName",
                value: "/Images/RedFox.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18,
                column: "ImageName",
                value: "/Images/FlyingLizard.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19,
                column: "ImageName",
                value: "/Images/BarnOwl.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20,
                column: "ImageName",
                value: "/Images/SwordFish.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "ImageName",
                value: "https://a-z-animals.com/media/killer-whale-1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "ImageName",
                value: "https://i.natgeofe.com/k/c02b35d2-bfd7-4ed9-aad4-8e25627cd481/komodo-dragon-head-on_3x2.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "ImageName",
                value: "https://cdn.mos.cms.futurecdn.net/HjFE8NKWuCmgfHCcndJ3rK-1200-80.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "ImageName", "Name" },
                values: new object[] { "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcTc2QoE1cN6MBfTWmmeTdmFQAUm0pXA_2vgCezyk5bi8kNcVX6AZ4MhC0Pwq3zpHB6RLo4c5dv3p_2f24w", "Great White Shar" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "ImageName",
                value: "https://animals.sandiegozoo.org/sites/default/files/2016-11/animals_hero_toucan.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "ImageName",
                value: "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcS4dWV3r50QUqmi3ZUAF_PJ49XTpe6LgjLC4R6btUyrB3EGwdUE9iV2sbCzJ2cCKnZJ6X9QliGjiVBI2gE");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "ImageName",
                value: "https://people.com/thmb/QhqeC2pJCGXFiBkBNMLd6WxF4Nk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(749x0:751x2)/cobra-file-pic--20b4ecc1b95c45abbf7d2ab31306ca24.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8,
                column: "ImageName",
                value: "https://cdn.britannica.com/29/150929-050-547070A1/lion-Kenya-Masai-Mara-National-Reserve.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9,
                column: "ImageName",
                value: "https://cdn.mos.cms.futurecdn.net/ETb2xLjvc62eb7PPLspSsU.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                column: "ImageName",
                value: "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcQJaFfIWJivdbQD7iRqyMmDkg0XvXQgubTOLWUl9jokDhLc4CXYvGts6FNV6FPG3BHJhJs60-FOCAEzrcE");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11,
                column: "ImageName",
                value: "https://upload.wikimedia.org/wikipedia/commons/3/35/Mute_swan_Vrhnika.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12,
                column: "ImageName",
                value: "https://upload.wikimedia.org/wikipedia/commons/0/03/American_Alligator.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13,
                column: "ImageName",
                value: "https://www.oceanario.pt/content/img/salamander_139419137_marek_r._swadzba.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14,
                column: "ImageName",
                value: "https://storage.googleapis.com/cdn-ioutdoor-com/2018/01/mahi.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15,
                column: "ImageName",
                value: "http://t1.gstatic.com/licensed-image?q=tbn:ANd9GcQ3McgT6kiyXN7vUlzF6tbQ-uT6d968ma3AA7CmnojzRZYQGTgd2Vw9JyaLu08R9Rh0ChDdW0fMnS84dtE");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16,
                column: "ImageName",
                value: "http://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSZRpCkMraxqmsgJ8wBU3YYuDaNSXoK-stzQENn4X_z1-SoZGlAl1w8xPPwZejpysDADu5dW7KPq3xH5wk");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17,
                column: "ImageName",
                value: "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcT-317dY4oiDRBLuIiKbUc0Lge82NCuT3f8O4IXn_9tB61AvUXiX-nEqXq9qcxGHRSdXGNLnYpKju9ZK1c");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18,
                column: "ImageName",
                value: "https://i.ytimg.com/vi/QeDir3p8WBs/maxresdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19,
                column: "ImageName",
                value: "https://cdn.download.ams.birds.cornell.edu/api/v1/asset/297342281/1800");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20,
                column: "ImageName",
                value: "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2023/01/640/320/iStock-1329438563.jpg?ve=1&tl=1");
        }
    }
}
