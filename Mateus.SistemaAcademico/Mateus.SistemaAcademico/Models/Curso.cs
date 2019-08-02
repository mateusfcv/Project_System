using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;
using Mateus.SistemaAcademico.Models.JOINS;

namespace Mateus.SistemaAcademico.Models
{
    public class Curso : EntityBase
    {
        public string Nome { get; set; }
        public float Duracao { get; set; }
        public Professor Coordenador { get; set; }
        public List<Aluno> Aluno { get; set; }
        public IList<CursoDisciplina> Disciplina { get; set; }
        public TipoCurso TipoCurso { get; set; }

        public Curso ()
        {

        }

        public Curso(string nome, float duracao, Professor coordenador, List<Aluno> aluno, IList<CursoDisciplina> disciplina, TipoCurso tipoCurso)
        {
            Nome = nome;
            Duracao = duracao;
            Coordenador = coordenador;
            Aluno = aluno;
            Disciplina = disciplina;
            TipoCurso = tipoCurso;
        }
    }
}