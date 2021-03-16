using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Branches_LocationId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_LocationId",
                table: "Assets");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_BranchId",
                table: "Assets",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Branches_BranchId",
                table: "Assets",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Branches_BranchId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_BranchId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Assets");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Assets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_LocationId",
                table: "Assets",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Branches_LocationId",
                table: "Assets",
                column: "LocationId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
