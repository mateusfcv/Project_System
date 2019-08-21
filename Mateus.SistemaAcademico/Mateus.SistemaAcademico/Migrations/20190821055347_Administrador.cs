using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mateus.SistemaAcademico.Migrations
{
    public partial class Administrador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Telefones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Administradores",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeNascimento",
                table: "Administradores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Administradores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Administradores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_AdministradorId",
                table: "Telefones",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_AdministradorId",
                table: "Enderecos",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Administradores_AdministradorId",
                table: "Enderecos",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Administradores_AdministradorId",
                table: "Telefones",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Administradores_AdministradorId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Administradores_AdministradorId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_AdministradorId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_AdministradorId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Administradores");

            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "Administradores");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Administradores");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Administradores");
        }
    }
}
