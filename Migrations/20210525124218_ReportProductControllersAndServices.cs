using Microsoft.EntityFrameworkCore.Migrations;

namespace bright_web_api.Migrations
{
    public partial class ReportProductControllersAndServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_Product_ProductId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_RepairedPart_Report_ReportId",
                table: "Report_RepairedPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_ReplacedPart_Report_ReportId",
                table: "Report_ReplacedPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Report",
                newName: "Reports");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Report_ProductId",
                table: "Reports",
                newName: "IX_Reports_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_RepairedPart_Reports_ReportId",
                table: "Report_RepairedPart",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ReplacedPart_Reports_ReportId",
                table: "Report_ReplacedPart",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Products_ProductId",
                table: "Reports",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_RepairedPart_Reports_ReportId",
                table: "Report_RepairedPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_ReplacedPart_Reports_ReportId",
                table: "Report_ReplacedPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Products_ProductId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Report");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ProductId",
                table: "Report",
                newName: "IX_Report_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report",
                table: "Report",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Product_ProductId",
                table: "Report",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_RepairedPart_Report_ReportId",
                table: "Report_RepairedPart",
                column: "ReportId",
                principalTable: "Report",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ReplacedPart_Report_ReportId",
                table: "Report_ReplacedPart",
                column: "ReportId",
                principalTable: "Report",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
