using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Aluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Alunos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Alunos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Alunos");
        }
    }
}
