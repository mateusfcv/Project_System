using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Seguna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Responsavel_ResponsavelId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_ResponsavelId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId1",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ResponsavelId1",
                table: "Alunos",
                column: "ResponsavelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Responsavel_ResponsavelId1",
                table: "Alunos",
                column: "ResponsavelId1",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Responsavel_ResponsavelId1",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_ResponsavelId1",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "ResponsavelId1",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Alunos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ResponsavelId",
                table: "Alunos",
                column: "ResponsavelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Responsavel_ResponsavelId",
                table: "Alunos",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
