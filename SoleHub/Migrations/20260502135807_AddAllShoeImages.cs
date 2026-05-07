using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoleHub.Migrations
{
    /// <inheritdoc />
    public partial class AddAllShoeImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/alphafly.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/yeezy.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/crocs.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/aj1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/ultraboost.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/forum.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/vans.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/converse.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/dunk.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/on.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/images/asics1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "/images/samba.png");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 13, "Nike", "Running", "/images/nike16.png", "Nike Shoe 13", 4995.00m },
                    { 14, "Nike", "Running", "/images/nike17.png", "Nike Shoe 14", 5495.00m },
                    { 15, "Nike", "Running", "/images/nike18.png", "Nike Shoe 15", 5995.00m },
                    { 16, "Nike", "Running", "/images/nike20.png", "Nike Shoe 16", 6495.00m },
                    { 17, "Nike", "Running", "/images/nike21.png", "Nike Shoe 17", 6995.00m },
                    { 18, "Nike", "Running", "/images/nikke19.png", "Nike Shoe 18", 7495.00m },
                    { 19, "Adidas", "Lifestyle", "/images/ad1.png", "Adidas Shoe 19", 7995.00m },
                    { 20, "Adidas", "Lifestyle", "/images/ad2.png", "Adidas Shoe 20", 8495.00m },
                    { 21, "Adidas", "Lifestyle", "/images/ad3.png", "Adidas Shoe 21", 8995.00m },
                    { 22, "Adidas", "Lifestyle", "/images/ad4.png", "Adidas Shoe 22", 9495.00m },
                    { 23, "Adidas", "Lifestyle", "/images/ad5.png", "Adidas Shoe 23", 4995.00m },
                    { 24, "Adidas", "Lifestyle", "/images/ad6.png", "Adidas Shoe 24", 5495.00m },
                    { 25, "Adidas", "Lifestyle", "/images/ad7.png", "Adidas Shoe 25", 5995.00m },
                    { 26, "Adidas", "Lifestyle", "/images/ad8.png", "Adidas Shoe 26", 6495.00m },
                    { 27, "Adidas", "Lifestyle", "/images/ad9.png", "Adidas Shoe 27", 6995.00m },
                    { 28, "Adidas", "Lifestyle", "/images/ad10.png", "Adidas Shoe 28", 7495.00m },
                    { 29, "Adidas", "Lifestyle", "/images/ad11.png", "Adidas Shoe 29", 7995.00m },
                    { 30, "Adidas", "Lifestyle", "/images/ad12.png", "Adidas Shoe 30", 8495.00m },
                    { 31, "Adidas", "Lifestyle", "/images/ad14.png", "Adidas Shoe 31", 8995.00m },
                    { 32, "Adidas", "Lifestyle", "/images/ad15.png", "Adidas Shoe 32", 9495.00m },
                    { 33, "Adidas", "Lifestyle", "/images/ad16.png", "Adidas Shoe 33", 4995.00m },
                    { 34, "Adidas", "Lifestyle", "/images/ad17.png", "Adidas Shoe 34", 5495.00m },
                    { 35, "Adidas", "Lifestyle", "/images/ad18.png", "Adidas Shoe 35", 5995.00m },
                    { 36, "Adidas", "Lifestyle", "/images/ad19.png", "Adidas Shoe 36", 6495.00m },
                    { 37, "Adidas", "Lifestyle", "/images/ad20.png", "Adidas Shoe 37", 6995.00m },
                    { 38, "Adidas", "Lifestyle", "/images/ad22.png", "Adidas Shoe 38", 7495.00m },
                    { 39, "Adidas", "Lifestyle", "/images/ad23.png", "Adidas Shoe 39", 7995.00m },
                    { 40, "Adidas", "Lifestyle", "/images/ad24.png", "Adidas Shoe 40", 8495.00m },
                    { 41, "Adidas", "Lifestyle", "/images/ad25.png", "Adidas Shoe 41", 8995.00m },
                    { 42, "Adidas", "Lifestyle", "/images/ad26.png", "Adidas Shoe 42", 9495.00m },
                    { 43, "Adidas", "Lifestyle", "/images/ad27.png", "Adidas Shoe 43", 4995.00m },
                    { 44, "Adidas", "Lifestyle", "/images/ad28.png", "Adidas Shoe 44", 5495.00m },
                    { 45, "Adidas", "Lifestyle", "/images/ad29.png", "Adidas Shoe 45", 5995.00m },
                    { 46, "Adidas", "Lifestyle", "/images/ad30.png", "Adidas Shoe 46", 6495.00m },
                    { 47, "Adidas", "Lifestyle", "/images/ad31.png", "Adidas Shoe 47", 6995.00m },
                    { 48, "Adidas", "Lifestyle", "/images/ad32.png", "Adidas Shoe 48", 7495.00m },
                    { 49, "Adidas", "Lifestyle", "/images/ad33.png", "Adidas Shoe 49", 7995.00m },
                    { 50, "Adidas", "Lifestyle", "/images/ad34.png", "Adidas Shoe 50", 8495.00m },
                    { 51, "Adidas", "Lifestyle", "/images/ad35.png", "Adidas Shoe 51", 8995.00m },
                    { 52, "Adidas", "Lifestyle", "/images/ad36.png", "Adidas Shoe 52", 9495.00m },
                    { 53, "Nike", "Running", "/images/nike1.jpg", "Nike Shoe 53", 4995.00m },
                    { 54, "Nike", "Running", "/images/nike2.png", "Nike Shoe 54", 5495.00m },
                    { 55, "Nike", "Running", "/images/nike3.png", "Nike Shoe 55", 5995.00m },
                    { 56, "Nike", "Running", "/images/nike4.png", "Nike Shoe 56", 6495.00m },
                    { 57, "Nike", "Running", "/images/nike5.png", "Nike Shoe 57", 6995.00m },
                    { 58, "Nike", "Running", "/images/nike6.png", "Nike Shoe 58", 7495.00m },
                    { 59, "Nike", "Running", "/images/nike7.png", "Nike Shoe 59", 7995.00m },
                    { 60, "Nike", "Running", "/images/nike8.png", "Nike Shoe 60", 8495.00m },
                    { 61, "Nike", "Running", "/images/nike9.png", "Nike Shoe 61", 8995.00m },
                    { 62, "Nike", "Running", "/images/nike10.png", "Nike Shoe 62", 9495.00m },
                    { 63, "Nike", "Running", "/images/nike11.png", "Nike Shoe 63", 4995.00m },
                    { 64, "Nike", "Running", "/images/nike12.png", "Nike Shoe 64", 5495.00m },
                    { 65, "Nike", "Running", "/images/nike13.png", "Nike Shoe 65", 5995.00m },
                    { 66, "Nike", "Running", "/images/nike14.png", "Nike Shoe 66", 6495.00m },
                    { 67, "Nike", "Running", "/images/nike15.png", "Nike Shoe 67", 6995.00m },
                    { 68, "New Balance", "Running", "/images/nb.jpg", "New Balance Shoe 68", 7495.00m },
                    { 69, "New Balance", "Running", "/images/nb1.png", "New Balance Shoe 69", 7995.00m },
                    { 70, "New Balance", "Running", "/images/nb2.png", "New Balance Shoe 70", 8495.00m },
                    { 71, "New Balance", "Running", "/images/nb3.png", "New Balance Shoe 71", 8995.00m },
                    { 72, "New Balance", "Running", "/images/nb4.png", "New Balance Shoe 72", 9495.00m },
                    { 73, "New Balance", "Running", "/images/nb5.png", "New Balance Shoe 73", 4995.00m },
                    { 74, "New Balance", "Running", "/images/nb6.png", "New Balance Shoe 74", 5495.00m },
                    { 75, "New Balance", "Running", "/images/nb7.png", "New Balance Shoe 75", 5995.00m },
                    { 76, "New Balance", "Running", "/images/nb202rbl.png", "New Balance Shoe 76", 6495.00m },
                    { 77, "New Balance", "Running", "/images/nb530.jpg", "New Balance Shoe 77", 6995.00m },
                    { 78, "Hoka", "Running", "/images/hoka1.png", "Hoka Shoe 78", 7495.00m },
                    { 79, "Hoka", "Running", "/images/hoka2.png", "Hoka Shoe 79", 7995.00m },
                    { 80, "Hoka", "Running", "/images/hoka5.png", "Hoka Shoe 80", 8495.00m },
                    { 81, "Vans", "Skate", "/images/vans.jpg", "Vans Shoe 81", 8995.00m },
                    { 82, "Adidas", "Slides", "/images/yeezy.jpg", "Adidas Shoe 82", 9495.00m },
                    { 83, "Converse", "Lifestyle", "/images/c1.jpg", "Converse Shoe 83", 4995.00m },
                    { 84, "Converse", "Lifestyle", "/images/c2.png", "Converse Shoe 84", 5495.00m },
                    { 85, "Converse", "Lifestyle", "/images/c3.png", "Converse Shoe 85", 5995.00m },
                    { 86, "Converse", "Lifestyle", "/images/c4.png", "Converse Shoe 86", 6495.00m },
                    { 87, "Converse", "Lifestyle", "/images/c5.png", "Converse Shoe 87", 6995.00m },
                    { 88, "Converse", "Lifestyle", "/images/c6.png", "Converse Shoe 88", 7495.00m },
                    { 89, "Converse", "Lifestyle", "/images/c7.png", "Converse Shoe 89", 7995.00m },
                    { 90, "Converse", "Lifestyle", "/images/c8.png", "Converse Shoe 90", 8495.00m },
                    { 91, "Converse", "Lifestyle", "/images/c9.png", "Converse Shoe 91", 8995.00m },
                    { 92, "Converse", "Lifestyle", "/images/c10.png", "Converse Shoe 92", 9495.00m },
                    { 93, "Converse", "Lifestyle", "/images/c11.png", "Converse Shoe 93", 4995.00m },
                    { 94, "Converse", "Lifestyle", "/images/c12.png", "Converse Shoe 94", 5495.00m },
                    { 95, "Converse", "Lifestyle", "/images/c13.png", "Converse Shoe 95", 5995.00m },
                    { 96, "Converse", "Lifestyle", "/images/c14.png", "Converse Shoe 96", 6495.00m },
                    { 97, "Converse", "Lifestyle", "/images/c15.png", "Converse Shoe 97", 6995.00m },
                    { 98, "Converse", "Lifestyle", "/images/c16.png", "Converse Shoe 98", 7495.00m },
                    { 99, "Converse", "Lifestyle", "/images/c17.png", "Converse Shoe 99", 7995.00m },
                    { 100, "Converse", "Lifestyle", "/images/c18.png", "Converse Shoe 100", 8495.00m },
                    { 101, "Converse", "Lifestyle", "/images/c19.png", "Converse Shoe 101", 8995.00m },
                    { 102, "Converse", "Lifestyle", "/images/c20.png", "Converse Shoe 102", 9495.00m },
                    { 103, "Converse", "Lifestyle", "/images/c21.png", "Converse Shoe 103", 4995.00m },
                    { 104, "Converse", "Lifestyle", "/images/c23.png", "Converse Shoe 104", 5495.00m },
                    { 105, "Converse", "Lifestyle", "/images/c24.png", "Converse Shoe 105", 5995.00m },
                    { 106, "Converse", "Lifestyle", "/images/c25.png", "Converse Shoe 106", 6495.00m },
                    { 107, "Converse", "Lifestyle", "/images/c26.png", "Converse Shoe 107", 6995.00m },
                    { 108, "Converse", "Lifestyle", "/images/c27.png", "Converse Shoe 108", 7495.00m },
                    { 109, "Converse", "Lifestyle", "/images/c28.png", "Converse Shoe 109", 7995.00m },
                    { 110, "Converse", "Lifestyle", "/images/c29.png", "Converse Shoe 110", 8495.00m },
                    { 111, "Converse", "Lifestyle", "/images/c30.png", "Converse Shoe 111", 8995.00m },
                    { 112, "Converse", "Lifestyle", "/images/cr1.jpg", "Converse Shoe 112", 9495.00m },
                    { 113, "Puma", "Lifestyle", "/images/p1.png", "Puma Shoe 113", 4995.00m },
                    { 114, "Puma", "Lifestyle", "/images/p2.png", "Puma Shoe 114", 5495.00m },
                    { 115, "Puma", "Lifestyle", "/images/p3.png", "Puma Shoe 115", 5995.00m },
                    { 116, "Puma", "Lifestyle", "/images/p4.png", "Puma Shoe 116", 6495.00m },
                    { 117, "Puma", "Lifestyle", "/images/p5.png", "Puma Shoe 117", 6995.00m },
                    { 118, "Puma", "Lifestyle", "/images/p6.png", "Puma Shoe 118", 7495.00m },
                    { 119, "Puma", "Lifestyle", "/images/p7.png", "Puma Shoe 119", 7995.00m },
                    { 120, "Puma", "Lifestyle", "/images/p8.png", "Puma Shoe 120", 8495.00m },
                    { 121, "Puma", "Lifestyle", "/images/p9.png", "Puma Shoe 121", 8995.00m },
                    { 122, "Puma", "Lifestyle", "/images/p10.png", "Puma Shoe 122", 9495.00m },
                    { 123, "Puma", "Lifestyle", "/images/p11.png", "Puma Shoe 123", 4995.00m },
                    { 124, "Puma", "Lifestyle", "/images/p12.png", "Puma Shoe 124", 5495.00m },
                    { 125, "Puma", "Lifestyle", "/images/p13.png", "Puma Shoe 125", 5995.00m },
                    { 126, "Puma", "Lifestyle", "/images/p14.png", "Puma Shoe 126", 6495.00m },
                    { 127, "Puma", "Lifestyle", "/images/p15.png", "Puma Shoe 127", 6995.00m },
                    { 128, "Puma", "Lifestyle", "/images/p16.png", "Puma Shoe 128", 7495.00m },
                    { 129, "Puma", "Lifestyle", "/images/p17.png", "Puma Shoe 129", 7995.00m },
                    { 130, "Puma", "Lifestyle", "/images/p18.png", "Puma Shoe 130", 8495.00m },
                    { 131, "Puma", "Lifestyle", "/images/p19.png", "Puma Shoe 131", 8995.00m },
                    { 132, "Puma", "Lifestyle", "/images/p20.png", "Puma Shoe 132", 9495.00m },
                    { 133, "Puma", "Lifestyle", "/images/p21.png", "Puma Shoe 133", 4995.00m },
                    { 134, "Puma", "Lifestyle", "/images/p22.png", "Puma Shoe 134", 5495.00m },
                    { 135, "Puma", "Lifestyle", "/images/p23.png", "Puma Shoe 135", 5995.00m },
                    { 136, "Puma", "Lifestyle", "/images/p24.png", "Puma Shoe 136", 6495.00m },
                    { 137, "Puma", "Lifestyle", "/images/p25.png", "Puma Shoe 137", 6995.00m },
                    { 138, "Reebok", "Running", "/images/r1.jpg", "Reebok Shoe 138", 7495.00m },
                    { 139, "Reebok", "Running", "/images/r1.png", "Reebok Shoe 139", 7995.00m },
                    { 140, "Reebok", "Running", "/images/r2.png", "Reebok Shoe 140", 8495.00m },
                    { 141, "Reebok", "Running", "/images/r4.png", "Reebok Shoe 141", 8995.00m },
                    { 142, "Reebok", "Running", "/images/r5.png", "Reebok Shoe 142", 9495.00m },
                    { 143, "Reebok", "Running", "/images/r6.png", "Reebok Shoe 143", 4995.00m },
                    { 144, "Reebok", "Running", "/images/r7.png", "Reebok Shoe 144", 5495.00m },
                    { 145, "Reebok", "Running", "/images/r8.png", "Reebok Shoe 145", 5995.00m },
                    { 146, "Reebok", "Running", "/images/r9.png", "Reebok Shoe 146", 6495.00m },
                    { 147, "Reebok", "Running", "/images/r10.png", "Reebok Shoe 147", 6995.00m },
                    { 148, "Reebok", "Running", "/images/r11.png", "Reebok Shoe 148", 7495.00m },
                    { 149, "Reebok", "Running", "/images/r12.png", "Reebok Shoe 149", 7995.00m },
                    { 150, "Reebok", "Running", "/images/r13.png", "Reebok Shoe 150", 8495.00m },
                    { 151, "Reebok", "Running", "/images/r14.png", "Reebok Shoe 151", 8995.00m },
                    { 152, "Reebok", "Running", "/images/r15.png", "Reebok Shoe 152", 9495.00m },
                    { 153, "Reebok", "Running", "/images/r16.png", "Reebok Shoe 153", 4995.00m },
                    { 154, "Reebok", "Running", "/images/r17.png", "Reebok Shoe 154", 5495.00m },
                    { 155, "Skechers", "Lifestyle", "/images/s1.png", "Skechers Shoe 155", 5995.00m },
                    { 156, "Skechers", "Lifestyle", "/images/s2.png", "Skechers Shoe 156", 6495.00m },
                    { 157, "Skechers", "Lifestyle", "/images/s3.png", "Skechers Shoe 157", 6995.00m },
                    { 158, "Skechers", "Lifestyle", "/images/s4.png", "Skechers Shoe 158", 7495.00m },
                    { 159, "Skechers", "Lifestyle", "/images/s5.png", "Skechers Shoe 159", 7995.00m },
                    { 160, "Skechers", "Lifestyle", "/images/s6.png", "Skechers Shoe 160", 8495.00m },
                    { 161, "Skechers", "Lifestyle", "/images/s7.png", "Skechers Shoe 161", 8995.00m },
                    { 162, "Skechers", "Lifestyle", "/images/s8.png", "Skechers Shoe 162", 9495.00m },
                    { 163, "Skechers", "Lifestyle", "/images/s9.png", "Skechers Shoe 163", 4995.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/alphafly.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/yeezy.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/crocs.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/aj1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/ultraboost.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/forum.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/vans.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/converse.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/dunk.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/on.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/images/asics.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "/images/samba.jpg");
        }
    }
}
