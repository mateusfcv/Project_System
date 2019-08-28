using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Secretarias",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Secretarias",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Professor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Professor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Administradores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Administradores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Secretarias");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Secretarias");

            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Administradores");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Administradores");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }
    }
}
