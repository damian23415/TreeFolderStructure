using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreeFolderStructure.DataAccess.Migrations
{
    public partial class AddedParentIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Folder",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Folder");
        }
    }
}
