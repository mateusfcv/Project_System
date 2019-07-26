using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPF",
                columns: table => new
                {
                    Valor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPF", x => x.Valor);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    CEP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    TelfoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunosMatricula = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.TelfoneId);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Matricula = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PessoaId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    EnderecoId = table.Column<int>(nullable: true),
                    cpfValor = table.Column<string>(nullable: true),
                    telefoneTelfoneId = table.Column<int>(nullable: true),
                    cPF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Matricula);
                    table.ForeignKey(
                        name: "FK_Alunos_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_CPF_cpfValor",
                        column: x => x.cpfValor,
                        principalTable: "CPF",
                        principalColumn: "Valor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_Telefones_telefoneTelfoneId",
                        column: x => x.telefoneTelfoneId,
                        principalTable: "Telefones",
                        principalColumn: "TelfoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EnderecoId",
                table: "Alunos",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_cpfValor",
                table: "Alunos",
                column: "cpfValor");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_telefoneTelfoneId",
                table: "Alunos",
                column: "telefoneTelfoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_AlunosMatricula",
                table: "Telefones",
                column: "AlunosMatricula");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Alunos_AlunosMatricula",
                table: "Telefones",
                column: "AlunosMatricula",
                principalTable: "Alunos",
                principalColumn: "Matricula",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Endereco_EnderecoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_CPF_cpfValor",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Telefones_telefoneTelfoneId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "CPF");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
