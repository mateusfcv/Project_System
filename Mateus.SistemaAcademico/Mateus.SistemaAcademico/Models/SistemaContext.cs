using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class SistemaContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

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
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SistemaAcademico;Trusted_Connection=true;");
            }
        }
    }
}