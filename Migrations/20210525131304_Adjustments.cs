using Microsoft.EntityFrameworkCore.Migrations;

namespace bright_web_api.Migrations
{
    public partial class Adjustments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_RepairedPart_RepairedPart_RepairedPartId",
                table: "Report_RepairedPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_RepairedPart_Reports_ReportId",
                table: "Report_RepairedPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_ReplacedPart_ReplacedPart_ReplacedPartId",
                table: "Report_ReplacedPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_ReplacedPart_Reports_ReportId",
                table: "Report_ReplacedPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report_ReplacedPart",
                table: "Report_ReplacedPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report_RepairedPart",
                table: "Report_RepairedPart");

            migrationBuilder.RenameTable(
                name: "Report_ReplacedPart",
                newName: "Reports_ReplacedParts");

            migrationBuilder.RenameTable(
                name: "Report_RepairedPart",
                newName: "Reports_RepairedParts");

            migrationBuilder.RenameIndex(
                name: "IX_Report_ReplacedPart_ReportId",
                table: "Reports_ReplacedParts",
                newName: "IX_Reports_ReplacedParts_ReportId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_ReplacedPart_ReplacedPartId",
                table: "Reports_ReplacedParts",
                newName: "IX_Reports_ReplacedParts_ReplacedPartId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_RepairedPart_ReportId",
                table: "Reports_RepairedParts",
                newName: "IX_Reports_RepairedParts_ReportId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_RepairedPart_RepairedPartId",
                table: "Reports_RepairedParts",
                newName: "IX_Reports_RepairedParts_RepairedPartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports_ReplacedParts",
                table: "Reports_ReplacedParts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports_RepairedParts",
                table: "Reports_RepairedParts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_RepairedParts_RepairedPart_RepairedPartId",
                table: "Reports_RepairedParts",
                column: "RepairedPartId",
                principalTable: "RepairedPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_RepairedParts_Reports_ReportId",
                table: "Reports_RepairedParts",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReplacedParts_ReplacedPart_ReplacedPartId",
                table: "Reports_ReplacedParts",
                column: "ReplacedPartId",
                principalTable: "ReplacedPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReplacedParts_Reports_ReportId",
                table: "Reports_ReplacedParts",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_RepairedParts_RepairedPart_RepairedPartId",
                table: "Reports_RepairedParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_RepairedParts_Reports_ReportId",
                table: "Reports_RepairedParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReplacedParts_ReplacedPart_ReplacedPartId",
                table: "Reports_ReplacedParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReplacedParts_Reports_ReportId",
                table: "Reports_ReplacedParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports_ReplacedParts",
                table: "Reports_ReplacedParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports_RepairedParts",
                table: "Reports_RepairedParts");

            migrationBuilder.RenameTable(
                name: "Reports_ReplacedParts",
                newName: "Report_ReplacedPart");

            migrationBuilder.RenameTable(
                name: "Reports_RepairedParts",
                newName: "Report_RepairedPart");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ReplacedParts_ReportId",
                table: "Report_ReplacedPart",
                newName: "IX_Report_ReplacedPart_ReportId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ReplacedParts_ReplacedPartId",
                table: "Report_ReplacedPart",
                newName: "IX_Report_ReplacedPart_ReplacedPartId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_RepairedParts_ReportId",
                table: "Report_RepairedPart",
                newName: "IX_Report_RepairedPart_ReportId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_RepairedParts_RepairedPartId",
                table: "Report_RepairedPart",
                newName: "IX_Report_RepairedPart_RepairedPartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report_ReplacedPart",
                table: "Report_ReplacedPart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report_RepairedPart",
                table: "Report_RepairedPart",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_RepairedPart_RepairedPart_RepairedPartId",
                table: "Report_RepairedPart",
                column: "RepairedPartId",
                principalTable: "RepairedPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_RepairedPart_Reports_ReportId",
                table: "Report_RepairedPart",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ReplacedPart_ReplacedPart_ReplacedPartId",
                table: "Report_ReplacedPart",
                column: "ReplacedPartId",
                principalTable: "ReplacedPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ReplacedPart_Reports_ReportId",
                table: "Report_ReplacedPart",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
