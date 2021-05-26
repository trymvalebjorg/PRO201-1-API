using Microsoft.EntityFrameworkCore.Migrations;

namespace bright_web_api.Migrations
{
    public partial class ProductRepairRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Repairs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Repairs_ProductId",
                table: "Repairs",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_Products_ProductId",
                table: "Repairs",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_Products_ProductId",
                table: "Repairs");

            migrationBuilder.DropIndex(
                name: "IX_Repairs_ProductId",
                table: "Repairs");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Repairs");
        }
    }
}
