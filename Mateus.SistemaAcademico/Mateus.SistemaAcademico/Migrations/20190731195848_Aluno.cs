using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Aluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cpf_CpfId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Endereco_EnderecoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Nome_NomeId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsavel_Cpf_CpfId",
                table: "Responsavel");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsavel_Endereco_EnderecoId",
                table: "Responsavel");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsavel_Nome_NomeId",
                table: "Responsavel");

            migrationBuilder.DropTable(
                name: "Cpf");

            migrationBuilder.DropTable(
                name: "Nome");

            migrationBuilder.DropIndex(
                name: "IX_Responsavel_CpfId",
                table: "Responsavel");

            migrationBuilder.DropIndex(
                name: "IX_Responsavel_EnderecoId",
                table: "Responsavel");

            migrationBuilder.DropIndex(
                name: "IX_Responsavel_NomeId",
                table: "Responsavel");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_CpfId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_EnderecoId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_NomeId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "CpfId",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "NomeId",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "CpfId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "NomeId",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Telefone",
                newName: "Numero");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Endereco",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Endereco",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Alunos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ResponsavelId",
                table: "Endereco",
                column: "ResponsavelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Alunos_AlunoId",
                table: "Endereco",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Responsavel_ResponsavelId",
                table: "Endereco",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Alunos_AlunoId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Responsavel_ResponsavelId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_AlunoId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_ResponsavelId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Telefone",
                newName: "Valor");

            migrationBuilder.AddColumn<int>(
                name: "CpfId",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NomeId",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CpfId",
                table: "Alunos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Alunos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NomeId",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cpf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dados = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nome", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_CpfId",
                table: "Responsavel",
                column: "CpfId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_EnderecoId",
                table: "Responsavel",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_NomeId",
                table: "Responsavel",
                column: "NomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CpfId",
                table: "Alunos",
                column: "CpfId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EnderecoId",
                table: "Alunos",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_NomeId",
                table: "Alunos",
                column: "NomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cpf_CpfId",
                table: "Alunos",
                column: "CpfId",
                principalTable: "Cpf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Endereco_EnderecoId",
                table: "Alunos",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Nome_NomeId",
                table: "Alunos",
                column: "NomeId",
                principalTable: "Nome",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsavel_Cpf_CpfId",
                table: "Responsavel",
                column: "CpfId",
                principalTable: "Cpf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsavel_Endereco_EnderecoId",
                table: "Responsavel",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsavel_Nome_NomeId",
                table: "Responsavel",
                column: "NomeId",
                principalTable: "Nome",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
