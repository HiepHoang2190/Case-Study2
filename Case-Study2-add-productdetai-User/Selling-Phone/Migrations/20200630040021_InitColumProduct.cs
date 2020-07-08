using Microsoft.EntityFrameworkCore.Migrations;

namespace Selling_Phone.Migrations
{
    public partial class InitColumProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BatteryCapacity",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrontCamera",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Graphics",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HardDrive",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memory",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingSystem",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Processor",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RearCamera",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Screen",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sim",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryCapacity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FrontCamera",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Graphics",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HardDrive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Memory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OperatingSystem",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Processor",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RearCamera",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Screen",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Sim",
                table: "Products");
        }
    }
}
