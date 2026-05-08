using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoleHub.Migrations
{
    /// <inheritdoc />
    public partial class RemovingJpg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: "/images/nike2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: "/images/nike3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: "/images/nike4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: "/images/nike5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: "/images/nike6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "/images/nike7.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: "/images/nike8.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "/images/nike9.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: "/images/nike10.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: "/images/nike11.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "/images/nike12.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: "/images/nike13.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: "/images/nike14.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: "/images/nike15.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "New Balance", "/images/nb1.png", "New Balance Shoe 66" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "ImageUrl",
                value: "/images/nb2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "ImageUrl",
                value: "/images/nb3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrl",
                value: "/images/nb4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "ImageUrl",
                value: "/images/nb5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "ImageUrl",
                value: "/images/nb6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "ImageUrl",
                value: "/images/nb7.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "ImageUrl",
                value: "/images/nb202rbl.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Hoka", "/images/hoka1.png", "Hoka Shoe 74" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Hoka", "/images/hoka2.png", "Hoka Shoe 75" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Hoka", "/images/hoka5.png", "Hoka Shoe 76" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Vans", "Skate", "/images/vans1.png", "Vans Shoe 77" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Vans", "Skate", "/images/vans2.png", "Vans Shoe 78" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Vans", "Skate", "/images/vans3.png", "Vans Shoe 79" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "Lifestyle", "/images/c2.png", "SoleHub Shoe 80" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "Lifestyle", "/images/c3.png", "SoleHub Shoe 81" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "Lifestyle", "/images/c4.png", "SoleHub Shoe 82" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "Lifestyle", "/images/c5.png", "SoleHub Shoe 83" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "Lifestyle", "/images/c6.png", "SoleHub Shoe 84" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c7.png", "SoleHub Shoe 85" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c8.png", "SoleHub Shoe 86" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c9.png", "SoleHub Shoe 87" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c10.png", "SoleHub Shoe 88" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c11.png", "SoleHub Shoe 89" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c12.png", "SoleHub Shoe 90" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c13.png", "SoleHub Shoe 91" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c14.png", "SoleHub Shoe 92" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c15.png", "SoleHub Shoe 93" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c16.png", "SoleHub Shoe 94" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c17.png", "SoleHub Shoe 95" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c18.png", "SoleHub Shoe 96" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c19.png", "SoleHub Shoe 97" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c20.png", "SoleHub Shoe 98" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c21.png", "SoleHub Shoe 99" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c23.png", "SoleHub Shoe 100" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c24.png", "SoleHub Shoe 101" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c25.png", "SoleHub Shoe 102" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c26.png", "SoleHub Shoe 103" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c27.png", "SoleHub Shoe 104" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c28.png", "SoleHub Shoe 105" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c29.png", "SoleHub Shoe 106" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "SoleHub", "/images/c30.png", "SoleHub Shoe 107" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Puma", "/images/p1.png", "Puma Shoe 108" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Puma", "/images/p2.png", "Puma Shoe 109" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Puma", "/images/p3.png", "Puma Shoe 110" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Puma", "/images/p4.png", "Puma Shoe 111" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Puma", "/images/p5.png", "Puma Shoe 112" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Puma", "/images/p6.png", "Puma Shoe 113" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Puma", "/images/p7.png", "Puma Shoe 114" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "ImageUrl",
                value: "/images/p8.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "ImageUrl",
                value: "/images/p9.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "ImageUrl",
                value: "/images/p10.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "ImageUrl",
                value: "/images/p11.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "ImageUrl",
                value: "/images/p12.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "ImageUrl",
                value: "/images/p13.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "ImageUrl",
                value: "/images/p14.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "ImageUrl",
                value: "/images/p15.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "ImageUrl",
                value: "/images/p16.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "ImageUrl",
                value: "/images/p17.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "ImageUrl",
                value: "/images/p18.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "ImageUrl",
                value: "/images/p19.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "ImageUrl",
                value: "/images/p20.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "ImageUrl",
                value: "/images/p21.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "ImageUrl",
                value: "/images/p22.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "ImageUrl",
                value: "/images/p23.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "ImageUrl",
                value: "/images/p24.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "ImageUrl",
                value: "/images/p25.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r1.png", "Reebok Shoe 133" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r2.png", "Reebok Shoe 134" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r4.png", "Reebok Shoe 135" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r5.png", "Reebok Shoe 136" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r6.png", "Reebok Shoe 137" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r7.png", "Reebok Shoe 138" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r8.png", "Reebok Shoe 139" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "ImageUrl",
                value: "/images/r9.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "ImageUrl",
                value: "/images/r10.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "ImageUrl",
                value: "/images/r11.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "ImageUrl",
                value: "/images/r12.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "ImageUrl",
                value: "/images/r13.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "ImageUrl",
                value: "/images/r14.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "ImageUrl",
                value: "/images/r15.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "ImageUrl",
                value: "/images/r16.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "ImageUrl",
                value: "/images/r17.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s1.png", "Skechers Shoe 149" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s2.png", "Skechers Shoe 150" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s3.png", "Skechers Shoe 151" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s4.png", "Skechers Shoe 152" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s5.png", "Skechers Shoe 153" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s6.png", "Skechers Shoe 154" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s7.png", "Skechers Shoe 155" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Skechers", "Lifestyle", "/images/s8.png", "Skechers Shoe 156" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "ImageUrl",
                value: "/images/s9.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: "/images/nike1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: "/images/nike2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: "/images/nike3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: "/images/nike4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: "/images/nike5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "/images/nike6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: "/images/nike7.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "/images/nike8.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: "/images/nike9.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: "/images/nike10.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "/images/nike11.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: "/images/nike12.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: "/images/nike13.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: "/images/nike14.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Nike", "/images/nike15.png", "Nike Shoe 66" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "ImageUrl",
                value: "/images/nb.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "ImageUrl",
                value: "/images/nb1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrl",
                value: "/images/nb2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "ImageUrl",
                value: "/images/nb3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "ImageUrl",
                value: "/images/nb4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "ImageUrl",
                value: "/images/nb5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "ImageUrl",
                value: "/images/nb6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "New Balance", "/images/nb7.png", "New Balance Shoe 74" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "New Balance", "/images/nb202rbl.png", "New Balance Shoe 75" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "New Balance", "/images/nb530.jpg", "New Balance Shoe 76" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Hoka", "Running", "/images/hoka1.png", "Hoka Shoe 77" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Hoka", "Running", "/images/hoka2.png", "Hoka Shoe 78" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Hoka", "Running", "/images/hoka5.png", "Hoka Shoe 79" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Vans", "Skate", "/images/vans.jpg", "Vans Shoe 80" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Vans", "Skate", "/images/vans1.jpg", "Vans Shoe 81" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Vans", "Skate", "/images/vans2.jpg", "Vans Shoe 82" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Vans", "Skate", "/images/vans3.jpg", "Vans Shoe 83" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Adidas", "Slides", "/images/yeezy.jpg", "Adidas Shoe 84" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c1.jpg", "Converse Shoe 85" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c2.png", "Converse Shoe 86" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c3.png", "Converse Shoe 87" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c4.png", "Converse Shoe 88" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c5.png", "Converse Shoe 89" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c6.png", "Converse Shoe 90" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c7.png", "Converse Shoe 91" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c8.png", "Converse Shoe 92" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c9.png", "Converse Shoe 93" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c10.png", "Converse Shoe 94" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c11.png", "Converse Shoe 95" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c12.png", "Converse Shoe 96" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c13.png", "Converse Shoe 97" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c14.png", "Converse Shoe 98" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c15.png", "Converse Shoe 99" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c16.png", "Converse Shoe 100" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c17.png", "Converse Shoe 101" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c18.png", "Converse Shoe 102" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c19.png", "Converse Shoe 103" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c20.png", "Converse Shoe 104" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c21.png", "Converse Shoe 105" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c23.png", "Converse Shoe 106" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c24.png", "Converse Shoe 107" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c25.png", "Converse Shoe 108" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c26.png", "Converse Shoe 109" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c27.png", "Converse Shoe 110" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c28.png", "Converse Shoe 111" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c29.png", "Converse Shoe 112" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/c30.png", "Converse Shoe 113" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Brand", "ImageUrl", "Name" },
                values: new object[] { "Converse", "/images/cr1.jpg", "Converse Shoe 114" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "ImageUrl",
                value: "/images/p1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "ImageUrl",
                value: "/images/p2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "ImageUrl",
                value: "/images/p3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "ImageUrl",
                value: "/images/p4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "ImageUrl",
                value: "/images/p5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "ImageUrl",
                value: "/images/p6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "ImageUrl",
                value: "/images/p7.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "ImageUrl",
                value: "/images/p8.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "ImageUrl",
                value: "/images/p9.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "ImageUrl",
                value: "/images/p10.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "ImageUrl",
                value: "/images/p11.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "ImageUrl",
                value: "/images/p12.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "ImageUrl",
                value: "/images/p13.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "ImageUrl",
                value: "/images/p14.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "ImageUrl",
                value: "/images/p15.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "ImageUrl",
                value: "/images/p16.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "ImageUrl",
                value: "/images/p17.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "ImageUrl",
                value: "/images/p18.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Puma", "Lifestyle", "/images/p19.png", "Puma Shoe 133" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Puma", "Lifestyle", "/images/p20.png", "Puma Shoe 134" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Puma", "Lifestyle", "/images/p21.png", "Puma Shoe 135" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Puma", "Lifestyle", "/images/p22.png", "Puma Shoe 136" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Puma", "Lifestyle", "/images/p23.png", "Puma Shoe 137" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Puma", "Lifestyle", "/images/p24.png", "Puma Shoe 138" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Puma", "Lifestyle", "/images/p25.png", "Puma Shoe 139" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "ImageUrl",
                value: "/images/r1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "ImageUrl",
                value: "/images/r1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "ImageUrl",
                value: "/images/r2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "ImageUrl",
                value: "/images/r4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "ImageUrl",
                value: "/images/r5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "ImageUrl",
                value: "/images/r6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "ImageUrl",
                value: "/images/r7.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "ImageUrl",
                value: "/images/r8.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "ImageUrl",
                value: "/images/r9.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r10.png", "Reebok Shoe 149" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r11.png", "Reebok Shoe 150" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r12.png", "Reebok Shoe 151" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r13.png", "Reebok Shoe 152" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r14.png", "Reebok Shoe 153" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r15.png", "Reebok Shoe 154" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r16.png", "Reebok Shoe 155" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Brand", "Category", "ImageUrl", "Name" },
                values: new object[] { "Reebok", "Running", "/images/r17.png", "Reebok Shoe 156" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "ImageUrl",
                value: "/images/s1.png");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 158, "Skechers", "Lifestyle", "/images/s2.png", "Skechers Shoe 158", 7495.00m },
                    { 159, "Skechers", "Lifestyle", "/images/s3.png", "Skechers Shoe 159", 7995.00m },
                    { 160, "Skechers", "Lifestyle", "/images/s4.png", "Skechers Shoe 160", 8495.00m },
                    { 161, "Skechers", "Lifestyle", "/images/s5.png", "Skechers Shoe 161", 8995.00m },
                    { 162, "Skechers", "Lifestyle", "/images/s6.png", "Skechers Shoe 162", 9495.00m },
                    { 163, "Skechers", "Lifestyle", "/images/s7.png", "Skechers Shoe 163", 4995.00m },
                    { 164, "Skechers", "Lifestyle", "/images/s8.png", "Skechers Shoe 164", 5495.00m },
                    { 165, "Skechers", "Lifestyle", "/images/s9.png", "Skechers Shoe 165", 5995.00m }
                });
        }
    }
}
