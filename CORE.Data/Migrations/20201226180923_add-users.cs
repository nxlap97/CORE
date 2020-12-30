using Microsoft.EntityFrameworkCore.Migrations;

namespace CORE.Data.Migrations
{
    public partial class addusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "MDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileNameDefault",
                table: "MDocuments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "MDocuments");

            migrationBuilder.DropColumn(
                name: "FileNameDefault",
                table: "MDocuments");
        }
    }
}
