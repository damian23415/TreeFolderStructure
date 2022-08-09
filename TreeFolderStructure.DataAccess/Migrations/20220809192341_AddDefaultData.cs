using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreeFolderStructure.DataAccess.Migrations
{
    public partial class AddDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] { "Root", null }
                );

            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] { "Dokumenty", 1 }
                );

            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] { "Wideo", 1 }
                );

            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] {"Obrazki", 1 }
                );

            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] { "Moje zdjęcia", 3 }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
