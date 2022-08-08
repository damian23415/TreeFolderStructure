using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreeFolderStructure.DataAccess.Migrations
{
    public partial class AddChildren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Folder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FolderModelId",
                table: "Folder",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Folder_FolderModelId",
                table: "Folder",
                column: "FolderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Folder_Folder_FolderModelId",
                table: "Folder",
                column: "FolderModelId",
                principalTable: "Folder",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folder_Folder_FolderModelId",
                table: "Folder");

            migrationBuilder.DropIndex(
                name: "IX_Folder_FolderModelId",
                table: "Folder");

            migrationBuilder.DropColumn(
                name: "FolderModelId",
                table: "Folder");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Folder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
