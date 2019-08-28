using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Id);
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
                    Titulacao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
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
                    EstadoCivil = table.Column<int>(nullable: false),
                    Escolaridade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.Id);
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
                    DataDeNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretarias", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfessorId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    CargaHoraria = table.Column<TimeSpan>(nullable: false)
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
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<string>(nullable: true),
                    NomeRua = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Estados = table.Column<string>(nullable: true),
                    Cidades = table.Column<string>(nullable: true),
                    AdministradorId = table.Column<int>(nullable: true),
                    AlunoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: true),
                    ResponsavelId = table.Column<int>(nullable: true),
                    SecretariaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Administradores_AdministradorId",
                        column: x => x.AdministradorId,
                        principalTable: "Administradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enderecos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enderecos_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enderecos_Responsavel_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalTable: "Responsavel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enderecos_Secretarias_SecretariaId",
                        column: x => x.SecretariaId,
                        principalTable: "Secretarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(nullable: false),
                    TipoTelefone = table.Column<int>(nullable: false),
                    AdministradorId = table.Column<int>(nullable: true),
                    AlunoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: true),
                    ResponsavelId = table.Column<int>(nullable: true),
                    SecretariaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Administradores_AdministradorId",
                        column: x => x.AdministradorId,
                        principalTable: "Administradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefones_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefones_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefones_Responsavel_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalTable: "Responsavel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefones_Secretarias_SecretariaId",
                        column: x => x.SecretariaId,
                        principalTable: "Secretarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisciplinaId = table.Column<int>(nullable: false),
                    AvaliacaoId = table.Column<int>(nullable: true),
                    SubstitutivasId = table.Column<int>(nullable: true),
                    TrabalhoId = table.Column<int>(nullable: true),
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
                        name: "FK_Notas_Avaliacoes_AvaliacaoId",
                        column: x => x.AvaliacaoId,
                        principalTable: "Avaliacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Notas_Substitutivas_SubstitutivasId",
                        column: x => x.SubstitutivasId,
                        principalTable: "Substitutivas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Trabalhos_TrabalhoId",
                        column: x => x.TrabalhoId,
                        principalTable: "Trabalhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Enderecos_AdministradorId",
                table: "Enderecos",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_AlunoId",
                table: "Enderecos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ProfessorId",
                table: "Enderecos",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ResponsavelId",
                table: "Enderecos",
                column: "ResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_SecretariaId",
                table: "Enderecos",
                column: "SecretariaId");

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
                name: "IX_Notas_AvaliacaoId",
                table: "Notas",
                column: "AvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_DisciplinaId",
                table: "Notas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_SubstitutivasId",
                table: "Notas",
                column: "SubstitutivasId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_TrabalhoId",
                table: "Notas",
                column: "TrabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorCurso_CursoId",
                table: "ProfessorCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Substitutivas_AlunoId",
                table: "Substitutivas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Substitutivas_DisciplinaId",
                table: "Substitutivas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_AdministradorId",
                table: "Telefones",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_AlunoId",
                table: "Telefones",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ProfessorId",
                table: "Telefones",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ResponsavelId",
                table: "Telefones",
                column: "ResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_SecretariaId",
                table: "Telefones",
                column: "SecretariaId");

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
                name: "Conteudos");

            migrationBuilder.DropTable(
                name: "CursoDisciplina");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "ExamesFinais");

            migrationBuilder.DropTable(
                name: "Frequencias");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "ProfessorCurso");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Substitutivas");

            migrationBuilder.DropTable(
                name: "Trabalhos");

            migrationBuilder.DropTable(
                name: "Administradores");

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
        }
    }
}
