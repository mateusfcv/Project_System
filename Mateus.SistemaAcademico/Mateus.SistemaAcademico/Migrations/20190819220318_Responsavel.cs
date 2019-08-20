using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Responsavel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "Enderecos",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Enderecos",
                newName: "NomeRua");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Cidades",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estados",
                table: "Enderecos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidades",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Estados",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Enderecos",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "NomeRua",
                table: "Enderecos",
                newName: "Logradouro");

            migrationBuilder.AlterColumn<int>(
                name: "CEP",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
