using Microsoft.EntityFrameworkCore.Migrations;

namespace VegaIDE_V2.Server.Data.Migrations
{
    public partial class addedSubmissionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Output = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Output", "Result" },
                values: new object[] { 1, "", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Submissions");
        }
    }
}
