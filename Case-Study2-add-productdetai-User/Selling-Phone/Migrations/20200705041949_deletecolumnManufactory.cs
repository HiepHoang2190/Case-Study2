using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Selling_Phone.Migrations
{
    public partial class deletecolumnManufactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufactory",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Processor",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 5, 11, 19, 48, 411, DateTimeKind.Local).AddTicks(5708));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Processor",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Manufactory",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 3, 14, 40, 9, 586, DateTimeKind.Local).AddTicks(3577));
        }
    }
}
