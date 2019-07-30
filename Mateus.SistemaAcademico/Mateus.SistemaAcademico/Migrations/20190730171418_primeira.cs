using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPF",
                columns: table => new
                {
                    IdCpf = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPF", x => x.IdCpf);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    CEP = table.Column<int>(nullable: false),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Nome",
                columns: table => new
                {
                    IdNome = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dados = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nome", x => x.IdNome);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    IdResponsavel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdPessoa = table.Column<int>(nullable: false),
                    nomeIdNome = table.Column<int>(nullable: true),
                    enderecoIdEndereco = table.Column<int>(nullable: true),
                    cPFIdCpf = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.IdResponsavel);
                    table.ForeignKey(
                        name: "FK_Responsavel_CPF_cPFIdCpf",
                        column: x => x.cPFIdCpf,
                        principalTable: "CPF",
                        principalColumn: "IdCpf",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Responsavel_Endereco_enderecoIdEndereco",
                        column: x => x.enderecoIdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Responsavel_Nome_nomeIdNome",
                        column: x => x.nomeIdNome,
                        principalTable: "Nome",
                        principalColumn: "IdNome",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    IdAluno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdPessoa = table.Column<int>(nullable: false),
                    nomeIdNome = table.Column<int>(nullable: true),
                    enderecoIdEndereco = table.Column<int>(nullable: true),
                    cPFIdCpf = table.Column<int>(nullable: true),
                    RegistroDoAluno = table.Column<int>(nullable: false),
                    ResponsavelIdResponsavel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.IdAluno);
                    table.ForeignKey(
                        name: "FK_Alunos_Responsavel_ResponsavelIdResponsavel",
                        column: x => x.ResponsavelIdResponsavel,
                        principalTable: "Responsavel",
                        principalColumn: "IdResponsavel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_CPF_cPFIdCpf",
                        column: x => x.cPFIdCpf,
                        principalTable: "CPF",
                        principalColumn: "IdCpf",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_Endereco_enderecoIdEndereco",
                        column: x => x.enderecoIdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_Nome_nomeIdNome",
                        column: x => x.nomeIdNome,
                        principalTable: "Nome",
                        principalColumn: "IdNome",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    IdTelefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<int>(nullable: false),
                    AlunoIdAluno = table.Column<int>(nullable: true),
                    ResponsavelIdResponsavel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.IdTelefone);
                    table.ForeignKey(
                        name: "FK_Telefone_Alunos_AlunoIdAluno",
                        column: x => x.AlunoIdAluno,
                        principalTable: "Alunos",
                        principalColumn: "IdAluno",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefone_Responsavel_ResponsavelIdResponsavel",
                        column: x => x.ResponsavelIdResponsavel,
                        principalTable: "Responsavel",
                        principalColumn: "IdResponsavel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ResponsavelIdResponsavel",
                table: "Alunos",
                column: "ResponsavelIdResponsavel");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_cPFIdCpf",
                table: "Alunos",
                column: "cPFIdCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_enderecoIdEndereco",
                table: "Alunos",
                column: "enderecoIdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_nomeIdNome",
                table: "Alunos",
                column: "nomeIdNome");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_cPFIdCpf",
                table: "Responsavel",
                column: "cPFIdCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_enderecoIdEndereco",
                table: "Responsavel",
                column: "enderecoIdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_nomeIdNome",
                table: "Responsavel",
                column: "nomeIdNome");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_AlunoIdAluno",
                table: "Telefone",
                column: "AlunoIdAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_ResponsavelIdResponsavel",
                table: "Telefone",
                column: "ResponsavelIdResponsavel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropTable(
                name: "CPF");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Nome");
        }
    }
}
