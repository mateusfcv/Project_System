using Mateus.SistemaAcademico.Models;
using Mateus.SistemaAcademico.Models.JOINS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.DAO
{
    public class SistemaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Frequencia> Frequencias { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; } 
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Pessoa>()
            //    .HasKey(c => c.Id);
            modelBuilder
                .Entity<CursoDisciplina>()
                .HasKey(cd => new { cd.CursoId, cd.DisciplinaId });
            base.OnModelCreating(modelBuilder);
       
            //modelBuilder
            //    .Entity<ProfessorCurso>()
            //    .HasKey(pc => new { pc.ProfessorId, pc.CursoId });
            //base.OnModelCreating(modelBuilder);
        } 

        public SistemaContext()
        {

        }

        public SistemaContext(DbContextOptions<SistemaContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SistemaAcademico;Trusted_Connection=true;");
            }
            
        }
    }
}
