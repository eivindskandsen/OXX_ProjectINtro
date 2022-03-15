using Microsoft.EntityFrameworkCore.Migrations;

namespace OXX_ProjectINtro.Migrations
{
    public partial class notesOnPie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "notes",
                table: "Pies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "notes",
                table: "Pies");
        }
    }
}
