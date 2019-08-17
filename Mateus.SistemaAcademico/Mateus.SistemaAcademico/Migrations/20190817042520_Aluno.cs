using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Aluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Disciplinas_CursoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_CursoId1",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_CursoId1",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "CursoId1",
                table: "Alunos");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Alunos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CursoId1",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId1",
                table: "Alunos",
                column: "CursoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Disciplinas_CursoId",
                table: "Alunos",
                column: "CursoId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_CursoId1",
                table: "Alunos",
                column: "CursoId1",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
