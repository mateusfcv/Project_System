using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Ultima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    TipoPerfil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    NumeroTel = table.Column<int>(nullable: false),
                    TipoTelefone = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    NomeRua = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Estados = table.Column<string>(nullable: false),
                    Cidades = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administradores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    NumeroTel = table.Column<int>(nullable: false),
                    TipoTelefone = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    NomeRua = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Estados = table.Column<string>(nullable: false),
                    Cidades = table.Column<string>(nullable: false),
                    Titulacao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professor_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    NumeroTel = table.Column<int>(nullable: false),
                    TipoTelefone = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    NomeRua = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Estados = table.Column<string>(nullable: false),
                    Cidades = table.Column<string>(nullable: false),
                    EstadoCivil = table.Column<int>(nullable: false),
                    Escolaridade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsavel_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Secretarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    NumeroTel = table.Column<int>(nullable: false),
                    TipoTelefone = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    NomeRua = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Estados = table.Column<string>(nullable: false),
                    Cidades = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secretarias_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfessorId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    CargaHoraria = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    DataDeInicio = table.Column<DateTime>(nullable: false),
                    DataDeFim = table.Column<DateTime>(nullable: false),
                    CoordenadorId = table.Column<int>(nullable: false),
                    SecretariaId = table.Column<int>(nullable: false),
                    TipoCurso = table.Column<int>(nullable: false),
                    Periodo = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Professor_CoordenadorId",
                        column: x => x.CoordenadorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cursos_Secretarias_SecretariaId",
                        column: x => x.SecretariaId,
                        principalTable: "Secretarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Conteudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    TipoConteudos = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conteudos_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    NumeroTel = table.Column<int>(nullable: false),
                    TipoTelefone = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    NomeRua = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Estados = table.Column<string>(nullable: false),
                    Cidades = table.Column<string>(nullable: false),
                    ResponsavelId1 = table.Column<int>(nullable: true),
                    CursoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Alunos_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_Responsavel_ResponsavelId1",
                        column: x => x.ResponsavelId1,
                        principalTable: "Responsavel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CursoDisciplina",
                columns: table => new
                {
                    CursoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoDisciplina", x => new { x.CursoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_CursoDisciplina_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CursoDisciplina_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorCurso",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorCurso", x => new { x.ProfessorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_ProfessorCurso_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProfessorCurso_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ExamesFinais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamesFinais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamesFinais_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExamesFinais_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Frequencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoFrequencia = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frequencias_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Frequencias_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisciplinaId = table.Column<int>(nullable: false),
                    Avaliacao = table.Column<float>(nullable: false),
                    Substitutivas = table.Column<float>(nullable: false),
                    Trabalho = table.Column<float>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Notas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Substitutivas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substitutivas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Substitutivas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Substitutivas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Trabalhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    DataDeInicio = table.Column<DateTime>(nullable: false),
                    DataDaEntrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabalhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trabalhos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Trabalhos_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administradores_UsuarioId",
                table: "Administradores",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_DisciplinaId",
                table: "Alunos",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ResponsavelId1",
                table: "Alunos",
                column: "ResponsavelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_UsuarioId",
                table: "Alunos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_AlunoId",
                table: "Avaliacoes",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_DisciplinaId",
                table: "Avaliacoes",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Conteudos_DisciplinaId",
                table: "Conteudos",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoDisciplina_DisciplinaId",
                table: "CursoDisciplina",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_CoordenadorId",
                table: "Cursos",
                column: "CoordenadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_SecretariaId",
                table: "Cursos",
                column: "SecretariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamesFinais_AlunoId",
                table: "ExamesFinais",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamesFinais_DisciplinaId",
                table: "ExamesFinais",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Frequencias_AlunoId",
                table: "Frequencias",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Frequencias_DisciplinaId",
                table: "Frequencias",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlunoId",
                table: "Notas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_DisciplinaId",
                table: "Notas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_UsuarioId",
                table: "Professor",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorCurso_CursoId",
                table: "ProfessorCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_UsuarioId",
                table: "Responsavel",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Secretarias_UsuarioId",
                table: "Secretarias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Substitutivas_AlunoId",
                table: "Substitutivas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Substitutivas_DisciplinaId",
                table: "Substitutivas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabalhos_AlunoId",
                table: "Trabalhos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabalhos_DisciplinaId",
                table: "Trabalhos",
                column: "DisciplinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Conteudos");

            migrationBuilder.DropTable(
                name: "CursoDisciplina");

            migrationBuilder.DropTable(
                name: "ExamesFinais");

            migrationBuilder.DropTable(
                name: "Frequencias");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "ProfessorCurso");

            migrationBuilder.DropTable(
                name: "Substitutivas");

            migrationBuilder.DropTable(
                name: "Trabalhos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropTable(
                name: "Secretarias");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
