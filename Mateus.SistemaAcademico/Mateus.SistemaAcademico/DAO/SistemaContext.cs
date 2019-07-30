﻿using Mateus.SistemaAcademico.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Cpf>()
               .HasKey(c => c.Id);

            modelBuilder.Entity<Endereco>()
               .HasKey(c => c.Id);

            modelBuilder.Entity<Nome>()
               .HasKey(c => c.Id);

            modelBuilder.Entity<Responsavel>()
               .HasKey(c => c.Id);

            modelBuilder.Entity<Telefone>()
               .HasKey(c => c.Id);
        }
    }
}
