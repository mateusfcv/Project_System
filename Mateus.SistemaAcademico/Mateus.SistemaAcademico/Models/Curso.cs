using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mateus.SistemaAcademico.Models.Joins;
using Mateus.SistemaAcademico.Bussines;

namespace Mateus.SistemaAcademico.Models
{
    public class Curso : EntityBase
    {
        public IList<CursoDisciplina> Disciplina { get; set; }
        public IList<ProfessorCurso> Professor { get; set; }

        [Required]
        public string Nome { get; set; }
        [NotMapped]
        //  FAZER A FUNÇÃO PARA EXIBIR A DURAÇÃO
        public TimeSpan Duracao
        {
            get
            {
                return DataDeFim.Subtract(DataDeInicio);
            }

        }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeInicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeFim { get; set; }
        [Required]
        public int CoordenadorId { get; set; }
        public Professor Coordenador { get; set; }
        [Required]
        public List<Aluno> Alunos { get; set; }
        [Required]
        public int SecretariaId { get; set; }
        public Secretaria Secretaria { get; set; }
        [Required]
        public TipoCurso TipoCurso { get; set; }
        [Required]
        public Periodo Periodo { get; set; }
        [Required]
        public Area Area { get; set; }

        public Curso()
        {

        }

        public Curso(IList<CursoDisciplina> disciplina, IList<ProfessorCurso> professor, string nome, DateTime dataDeInicio, 
            DateTime dataDeFim, int coordenadorId, Professor coordenador, List<Aluno> alunos, int secretariaId, 
            Secretaria secretaria, TipoCurso tipoCurso, Periodo periodo, Area area)
        {
            Disciplina = disciplina;
            Professor = professor;
            Nome = nome;
            DataDeInicio = dataDeInicio;
            DataDeFim = dataDeFim;
            CoordenadorId = coordenadorId;
            Coordenador = coordenador;
            Alunos = alunos;
            SecretariaId = secretariaId;
            Secretaria = secretaria;
            TipoCurso = tipoCurso;
            Periodo = periodo;
            Area = area;
        }
    }
}