using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoleHub.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFirst12Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Nike", "Running", "/images/alphafly.png", "Alphafly Next%", 15995.00m },
                    { 2, "Adidas", "Slides", "/images/yeezy.png", "Yeezy Slides", 3999.00m },
                    { 3, "Crocs", "Slides", "/images/crocs.png", "Classic All-Terrain", 3499.00m },
                    { 4, "Nike", "Lifestyle", "/images/aj1.png", "Air Jordan 1 Low", 6995.00m },
                    { 5, "Adidas", "Running", "/images/ultraboost.png", "Ultraboost Light", 9995.00m },
                    { 6, "Adidas", "Lifestyle", "/images/forum.png", "Forum Low", 5995.00m },
                    { 7, "Vans", "Skate", "/images/vans.png", "Old Skool", 4298.00m },
                    { 8, "Converse", "Lifestyle", "/images/converse.png", "Chuck Taylor 70", 3890.00m },
                    { 9, "Nike", "Lifestyle", "/images/dunk.png", "Dunk Low Retro", 6895.00m },
                    { 10, "On", "Running", "/images/on.png", "Cloudmonster", 10995.00m },
                    { 11, "ASICS", "Running", "/images/asics1.png", "Gel-Kayano 30", 9995.00m },
                    { 12, "Adidas", "Lifestyle", "/images/samba.png", "Samba OG", 5995.00m }
                });
        }
    }
}
