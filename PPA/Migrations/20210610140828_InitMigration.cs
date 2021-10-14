using Microsoft.EntityFrameworkCore.Migrations;

namespace PPA.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eixo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaTematica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NPrograma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrada");
        }
    }
}
