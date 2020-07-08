using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Selling_Phone.Migrations
{
    public partial class updateViewHOmemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 6, 16, 26, 57, 746, DateTimeKind.Local).AddTicks(28));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 5, 11, 19, 48, 411, DateTimeKind.Local).AddTicks(5708));
        }
    }
}
