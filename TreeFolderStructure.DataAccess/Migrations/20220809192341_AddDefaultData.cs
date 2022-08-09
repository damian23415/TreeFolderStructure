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
                values: new object[] { "Dokumenty", 20 }
                );

            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] { "Wideo", 20 }
                );

            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] {"Obrazki", 20 }
                );

            migrationBuilder.InsertData(
                table: "Folder",
                columns: new[] { "Name", "ParentId" },
                values: new object[] { "Moje zdjęcia", 23 }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
