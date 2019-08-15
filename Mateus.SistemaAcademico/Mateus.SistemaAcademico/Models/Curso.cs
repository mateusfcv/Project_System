using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;
using Mateus.SistemaAcademico.Models.JOINS;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mateus.SistemaAcademico.Models
{
    public class Curso : EntityBase
    {
        public IList<CursoDisciplina> Disciplina { get; set; }
        //public IList<ProfessorCurso> Professor { get; set; }

        [Required]
        public string Nome { get; set; }
        [NotMapped]
        public TimeSpan Duracao {
            get
            {
                return DataDeFim.Subtract(DataDeInicio);
            }

        }
        [Required]
        public DateTime DataDeInicio { get; set; }
        [Required]
        public DateTime DataDeFim { get; set; }

        [Required]
        public int CoordenadorId { get; set; }
        public Professor Coordenador { get; set; }
        [Required]
        public List<Aluno> Alunos { get; set; }
        [Required]
        public TipoCurso TipoCurso { get; set; }

        public Curso ()
        {

        }

        public Curso(IList<CursoDisciplina> disciplina, string nome, DateTime dataDeInicio, DateTime dataDeFim,
            Professor coordenador, List<Aluno> alunos, TipoCurso tipoCurso)
        {
            Disciplina = disciplina;
            Nome = nome;
            DataDeInicio = dataDeInicio;
            DataDeFim = dataDeFim;
            Coordenador = coordenador;
            Alunos = alunos;
            TipoCurso = tipoCurso;
        }
    }
}