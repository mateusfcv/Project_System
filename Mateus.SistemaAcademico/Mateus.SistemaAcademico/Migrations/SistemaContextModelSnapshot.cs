﻿// <auto-generated />
using System;
using Mateus.SistemaAcademico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mateus.SistemaAcademico.Migrations
{
    [DbContext(typeof(SistemaContext))]
    partial class SistemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Alunos", b =>
                {
                    b.Property<int>("Matricula")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome");

                    b.Property<int>("PessoaId");

                    b.Property<string>("cPF");

                    b.Property<string>("cpfValor");

                    b.Property<int?>("telefoneTelfoneId");

                    b.HasKey("Matricula");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("cpfValor");

                    b.HasIndex("telefoneTelfoneId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.CPF", b =>
                {
                    b.Property<string>("Valor")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Valor");

                    b.ToTable("CPF");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<int>("CEP");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Telefones", b =>
                {
                    b.Property<int>("TelfoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunosMatricula");

                    b.HasKey("TelfoneId");

                    b.HasIndex("AlunosMatricula");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Alunos", b =>
                {
                    b.HasOne("Mateus.SistemaAcademico.Models.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Mateus.SistemaAcademico.Models.CPF", "cpf")
                        .WithMany()
                        .HasForeignKey("cpfValor");

                    b.HasOne("Mateus.SistemaAcademico.Models.Telefones", "telefone")
                        .WithMany()
                        .HasForeignKey("telefoneTelfoneId");
                });

            modelBuilder.Entity("Mateus.SistemaAcademico.Models.Telefones", b =>
                {
                    b.HasOne("Mateus.SistemaAcademico.Models.Alunos")
                        .WithMany("telefones")
                        .HasForeignKey("AlunosMatricula");
                });
#pragma warning restore 612, 618
        }
    }
}
