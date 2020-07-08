using Microsoft.EntityFrameworkCore.Migrations;

namespace Selling_Phone.Migrations
{
    public partial class SeedingProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvatarPatch", "Manufactory", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "images/iphone-11-pro-max.png", 0, "Apple iPhone 11 Pro Max-512GB", "36.790.000 đ" },
                    { 2, "images/iphone-11-pro.png", 0, "Apple iPhone 11 Pro-256GB", "30.490.000 đ" },
                    { 3, "images/note-10-p.png", 0, "Samsung Galaxy Note 10 Plus", "23.890.000 đ" },
                    { 4, "images/s20Ultra.png", 0, "Samsung Galaxy S20 Ultra ", "20.950.000 đ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
