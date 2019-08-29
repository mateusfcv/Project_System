using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Pessoas_AlunoId",
                table: "Avaliacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Pessoas_CoordenadorId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Pessoas_SecretariaId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Pessoas_ProfessorId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamesFinais_Pessoas_AlunoId",
                table: "ExamesFinais");

            migrationBuilder.DropForeignKey(
                name: "FK_Frequencias_Pessoas_AlunoId",
                table: "Frequencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Pessoas_AlunoId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Cursos_CursoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Disciplinas_DisciplinaId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Pessoas_ResponsavelId1",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorCurso_Pessoas_ProfessorId",
                table: "ProfessorCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_Substitutivas_Pessoas_AlunoId",
                table: "Substitutivas");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabalhos_Pessoas_AlunoId",
                table: "Trabalhos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pessoas_PessoaId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_CursoId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_DisciplinaId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_ResponsavelId1",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "ResponsavelId1",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Titulacao",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Escolaridade",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Secretarias");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Usuarios",
                newName: "SecretariaId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PessoaId",
                table: "Usuarios",
                newName: "IX_Usuarios_SecretariaId");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Telefones",
                newName: "SecretariaId");

            migrationBuilder.RenameIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                newName: "IX_Telefones_SecretariaId");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Enderecos",
                newName: "SecretariaId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos",
                newName: "IX_Enderecos_SecretariaId");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Telefones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Telefones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Telefones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Telefones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Secretarias",
                table: "Secretarias",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AlunoId",
                table: "Usuarios",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ProfessorId",
                table: "Usuarios",
                column: "ProfessorId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Alunos_AlunoId",
                table: "Avaliacoes",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Professor_CoordenadorId",
                table: "Cursos",
                column: "CoordenadorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Secretarias_SecretariaId",
                table: "Cursos",
                column: "SecretariaId",
                principalTable: "Secretarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Professor_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Administradores_AdministradorId",
                table: "Enderecos",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Alunos_AlunoId",
                table: "Enderecos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Professor_ProfessorId",
                table: "Enderecos",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Responsavel_ResponsavelId",
                table: "Enderecos",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Secretarias_SecretariaId",
                table: "Enderecos",
                column: "SecretariaId",
                principalTable: "Secretarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamesFinais_Alunos_AlunoId",
                table: "ExamesFinais",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Frequencias_Alunos_AlunoId",
                table: "Frequencias",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Alunos_AlunoId",
                table: "Notas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorCurso_Professor_ProfessorId",
                table: "ProfessorCurso",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Substitutivas_Alunos_AlunoId",
                table: "Substitutivas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Administradores_AdministradorId",
                table: "Telefones",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Alunos_AlunoId",
                table: "Telefones",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Professor_ProfessorId",
                table: "Telefones",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Responsavel_ResponsavelId",
                table: "Telefones",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Secretarias_SecretariaId",
                table: "Telefones",
                column: "SecretariaId",
                principalTable: "Secretarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabalhos_Alunos_AlunoId",
                table: "Trabalhos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Alunos_AlunoId",
                table: "Usuarios",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Professor_ProfessorId",
                table: "Usuarios",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Secretarias_SecretariaId",
                table: "Usuarios",
                column: "SecretariaId",
                principalTable: "Secretarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Alunos_AlunoId",
                table: "Avaliacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Professor_CoordenadorId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Secretarias_SecretariaId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Professor_ProfessorId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Administradores_AdministradorId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Alunos_AlunoId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Professor_ProfessorId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Responsavel_ResponsavelId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Secretarias_SecretariaId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamesFinais_Alunos_AlunoId",
                table: "ExamesFinais");

            migrationBuilder.DropForeignKey(
                name: "FK_Frequencias_Alunos_AlunoId",
                table: "Frequencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Alunos_AlunoId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorCurso_Professor_ProfessorId",
                table: "ProfessorCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_Substitutivas_Alunos_AlunoId",
                table: "Substitutivas");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Administradores_AdministradorId",
                table: "Telefones");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Alunos_AlunoId",
                table: "Telefones");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Professor_ProfessorId",
                table: "Telefones");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Responsavel_ResponsavelId",
                table: "Telefones");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Secretarias_SecretariaId",
                table: "Telefones");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabalhos_Alunos_AlunoId",
                table: "Trabalhos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Alunos_AlunoId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Professor_ProfessorId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Secretarias_SecretariaId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_AlunoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ProfessorId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_AdministradorId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_AlunoId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_ProfessorId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_ResponsavelId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_AdministradorId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_AlunoId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_ProfessorId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_ResponsavelId",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Secretarias",
                table: "Secretarias");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Secretarias",
                newName: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "SecretariaId",
                table: "Usuarios",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_SecretariaId",
                table: "Usuarios",
                newName: "IX_Usuarios_PessoaId");

            migrationBuilder.RenameColumn(
                name: "SecretariaId",
                table: "Telefones",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Telefones_SecretariaId",
                table: "Telefones",
                newName: "IX_Telefones_PessoaId");

            migrationBuilder.RenameColumn(
                name: "SecretariaId",
                table: "Enderecos",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_SecretariaId",
                table: "Enderecos",
                newName: "IX_Enderecos_PessoaId");

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId1",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulacao",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Escolaridade",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_CursoId",
                table: "Pessoas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_DisciplinaId",
                table: "Pessoas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_ResponsavelId1",
                table: "Pessoas",
                column: "ResponsavelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Pessoas_AlunoId",
                table: "Avaliacoes",
                column: "AlunoId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Pessoas_CoordenadorId",
                table: "Cursos",
                column: "CoordenadorId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Pessoas_SecretariaId",
                table: "Cursos",
                column: "SecretariaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Pessoas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamesFinais_Pessoas_AlunoId",
                table: "ExamesFinais",
                column: "AlunoId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Frequencias_Pessoas_AlunoId",
                table: "Frequencias",
                column: "AlunoId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Pessoas_AlunoId",
                table: "Notas",
                column: "AlunoId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Cursos_CursoId",
                table: "Pessoas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Disciplinas_DisciplinaId",
                table: "Pessoas",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Pessoas_ResponsavelId1",
                table: "Pessoas",
                column: "ResponsavelId1",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorCurso_Pessoas_ProfessorId",
                table: "ProfessorCurso",
                column: "ProfessorId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Substitutivas_Pessoas_AlunoId",
                table: "Substitutivas",
                column: "AlunoId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabalhos_Pessoas_AlunoId",
                table: "Trabalhos",
                column: "AlunoId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pessoas_PessoaId",
                table: "Usuarios",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
