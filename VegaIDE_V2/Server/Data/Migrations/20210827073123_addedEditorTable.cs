using Microsoft.EntityFrameworkCore.Migrations;

namespace VegaIDE_V2.Server.Data.Migrations
{
    public partial class addedEditorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Editors",
                columns: new[] { "Id", "Code", "Language" },
                values: new object[] { 1, "def test():\n    print(\"Hello, World\")", "Python" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Editors");
        }
    }
}
