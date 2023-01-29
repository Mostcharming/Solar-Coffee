using Microsoft.EntityFrameworkCore.Migrations;

namespace Bean.Data.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "SalesOrders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_CustomerId",
                table: "SalesOrders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrders_CustomerId",
                table: "SalesOrders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "SalesOrders");
        }
    }
}
