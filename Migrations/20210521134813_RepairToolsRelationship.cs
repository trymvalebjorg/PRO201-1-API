using Microsoft.EntityFrameworkCore.Migrations;

namespace bright_web_api.Migrations
{
    public partial class RepairToolsRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Tools_Repairs_RepairId",
                table: "Repair_Tools");

            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Tools_Tools_ToolId",
                table: "Repair_Tools");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Repair_Tools",
                table: "Repair_Tools");

            migrationBuilder.DropColumn(
                name: "Tools",
                table: "Repairs");

            migrationBuilder.RenameTable(
                name: "Repair_Tools",
                newName: "Repairs_Tools");

            migrationBuilder.RenameIndex(
                name: "IX_Repair_Tools_ToolId",
                table: "Repairs_Tools",
                newName: "IX_Repairs_Tools_ToolId");

            migrationBuilder.RenameIndex(
                name: "IX_Repair_Tools_RepairId",
                table: "Repairs_Tools",
                newName: "IX_Repairs_Tools_RepairId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repairs_Tools",
                table: "Repairs_Tools",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_Tools_Repairs_RepairId",
                table: "Repairs_Tools",
                column: "RepairId",
                principalTable: "Repairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_Tools_Tools_ToolId",
                table: "Repairs_Tools",
                column: "ToolId",
                principalTable: "Tools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_Tools_Repairs_RepairId",
                table: "Repairs_Tools");

            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_Tools_Tools_ToolId",
                table: "Repairs_Tools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Repairs_Tools",
                table: "Repairs_Tools");

            migrationBuilder.RenameTable(
                name: "Repairs_Tools",
                newName: "Repair_Tools");

            migrationBuilder.RenameIndex(
                name: "IX_Repairs_Tools_ToolId",
                table: "Repair_Tools",
                newName: "IX_Repair_Tools_ToolId");

            migrationBuilder.RenameIndex(
                name: "IX_Repairs_Tools_RepairId",
                table: "Repair_Tools",
                newName: "IX_Repair_Tools_RepairId");

            migrationBuilder.AddColumn<string>(
                name: "Tools",
                table: "Repairs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repair_Tools",
                table: "Repair_Tools",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ProductId",
                table: "Reports",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Repair_Tools_Repairs_RepairId",
                table: "Repair_Tools",
                column: "RepairId",
                principalTable: "Repairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repair_Tools_Tools_ToolId",
                table: "Repair_Tools",
                column: "ToolId",
                principalTable: "Tools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
