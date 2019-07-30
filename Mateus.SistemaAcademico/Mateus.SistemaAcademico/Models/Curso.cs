using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Models
{
    public class Curso : EntityBase
    {
        public string Nome { get; set; }
        public float Duracao { get; set; }
        public Professor Coordenador { get; set; }
        public List<Aluno> Aluno { get; set; }
        public List<Disciplina> Disciplina { get; set; }
        public TipoCurso TipoCurso { get; set; }

        public Curso ()
        {

        }

        public Curso(string nome, float duracao, Professor coordenador, List<Aluno> aluno, List<Disciplina> disciplina, TipoCurso tipoCurso)
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