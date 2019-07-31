﻿// <auto-generated />
using System;
using Mateus.SistemaAcademico.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mateus.SistemaAcademico.Migrations
{
    [DbContext(typeof(SistemaContext))]
    [Migration("20190731165317_Teste")]
    partial class Teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CpfId");

                    b.Property<int?>("EnderecoId");

                    b.Property<int?>("NomeId");

                    b.Property<int>("RegistroDoAluno");

                    b.Property<int?>("ResponsavelId");

                    b.HasKey("Id");

                    b.HasIndex("CpfId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("NomeId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Cpf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Cpf");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<int>("CEP");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<int>("Numero");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Nome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dados");

                    b.HasKey("Id");

                    b.ToTable("Nome");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CpfId");

                    b.Property<int?>("EnderecoId");

                    b.Property<int?>("NomeId");

                    b.HasKey("Id");

                    b.HasIndex("CpfId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("NomeId");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunoId");

                    b.Property<int?>("ResponsavelId");

                    b.Property<int>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Aluno", b =>
                {
                    b.HasOne("Mateus.SistemaAcademico.Models.Cpf", "Cpf")
                        .WithMany()
                        .HasForeignKey("CpfId");

                    b.HasOne("Mateus.SistemaAcademico.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Mateus.SistemaAcademico.Models.Nome", "Nome")
                        .WithMany()
                        .HasForeignKey("NomeId");

                    b.HasOne("Mateus.SistemaAcademico.Models.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Responsavel", b =>
                {
                    b.HasOne("Mateus.SistemaAcademico.Models.Cpf", "Cpf")
                        .WithMany()
                        .HasForeignKey("CpfId");

                    b.HasOne("Mateus.SistemaAcademico.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Mateus.SistemaAcademico.Models.Nome", "Nome")
                        .WithMany()
                        .HasForeignKey("NomeId");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Telefone", b =>
                {
                    b.HasOne("Mateus.SistemaAcademico.Models.Aluno")
                        .WithMany("Telefone")
                        .HasForeignKey("AlunoId");

                    b.HasOne("Mateus.SistemaAcademico.Models.Responsavel")
                        .WithMany("Telefone")
                        .HasForeignKey("ResponsavelId");
                });
#pragma warning restore 612, 618
        }
    }
}