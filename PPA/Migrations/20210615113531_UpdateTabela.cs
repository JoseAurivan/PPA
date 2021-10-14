using Microsoft.EntityFrameworkCore.Migrations;

namespace PPA.Migrations
{
    public partial class UpdateTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Entrada",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Entrada");
        }
    }
}
