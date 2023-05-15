using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallShopIT.Migrations
{
    public partial class PayPalReferenceAddedToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.AddColumn<string>(
                name: "PayPalReference",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayPalReference",
                table: "Orders");
        }
    }
}
