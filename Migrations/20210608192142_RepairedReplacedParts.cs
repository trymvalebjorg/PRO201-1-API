using Microsoft.EntityFrameworkCore.Migrations;

namespace bright_web_api.Migrations
{
    public partial class RepairedReplacedParts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_RepairedParts_RepairedPart_RepairedPartId",
                table: "Reports_RepairedParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReplacedParts_ReplacedPart_ReplacedPartId",
                table: "Reports_ReplacedParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReplacedPart",
                table: "ReplacedPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairedPart",
                table: "RepairedPart");

            migrationBuilder.RenameTable(
                name: "ReplacedPart",
                newName: "ReplacedParts");

            migrationBuilder.RenameTable(
                name: "RepairedPart",
                newName: "RepairedParts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReplacedParts",
                table: "ReplacedParts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairedParts",
                table: "RepairedParts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_RepairedParts_RepairedParts_RepairedPartId",
                table: "Reports_RepairedParts",
                column: "RepairedPartId",
                principalTable: "RepairedParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReplacedParts_ReplacedParts_ReplacedPartId",
                table: "Reports_ReplacedParts",
                column: "ReplacedPartId",
                principalTable: "ReplacedParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_RepairedParts_RepairedParts_RepairedPartId",
                table: "Reports_RepairedParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReplacedParts_ReplacedParts_ReplacedPartId",
                table: "Reports_ReplacedParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReplacedParts",
                table: "ReplacedParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairedParts",
                table: "RepairedParts");

            migrationBuilder.RenameTable(
                name: "ReplacedParts",
                newName: "ReplacedPart");

            migrationBuilder.RenameTable(
                name: "RepairedParts",
                newName: "RepairedPart");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReplacedPart",
                table: "ReplacedPart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairedPart",
                table: "RepairedPart",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_RepairedParts_RepairedPart_RepairedPartId",
                table: "Reports_RepairedParts",
                column: "RepairedPartId",
                principalTable: "RepairedPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReplacedParts_ReplacedPart_ReplacedPartId",
                table: "Reports_ReplacedParts",
                column: "ReplacedPartId",
                principalTable: "ReplacedPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
