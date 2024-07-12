using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessObjects.Migrations
{
    public partial class AddDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Order",
                newName: "TotalPrice");

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Order",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "FinalPrice",
                table: "Order",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "FinalPrice",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Order",
                newName: "Total");

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "OrderDetail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
