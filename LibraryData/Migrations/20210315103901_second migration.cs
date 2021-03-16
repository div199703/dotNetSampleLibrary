using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Branches_BranchId",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Assets",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_BranchId",
                table: "Assets",
                newName: "IX_Assets_LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Branches_LocationId",
                table: "Assets",
                column: "LocationId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Branches_LocationId",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Assets",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_LocationId",
                table: "Assets",
                newName: "IX_Assets_BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Branches_BranchId",
                table: "Assets",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
