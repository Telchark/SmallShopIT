using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallShopIT.Migrations
{
    public partial class RecommendedAddedInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Recommended",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Image",
                value: "/Images/desktop_pc.jpg");


            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Recommended",
                value: true);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 2,
               column: "Recommended",
               value: false);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 3,
               column: "Recommended",
               value: false);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 4,
               column: "Recommended",
               value: false);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 5,
               column: "Recommended",
               value: false);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 6,
               column: "Recommended",
               value: true);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 7,
               column: "Recommended",
               value: false);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 8,
               column: "Recommended",
               value: false);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 9,
               column: "Recommended",
               value: false);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 10,
               column: "Recommended",
               value: true);

            migrationBuilder.UpdateData(
               table: "Products",
               keyColumn: "ProductId",
               keyValue: 11,
               column: "Recommended",
               value: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recommended",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Image",
                value: "/Images/dektop_pc.jpg");
        }
    }
}
