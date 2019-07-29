using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Models
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public float Duracao { get; set; }
        public Professor Coordenador { get; set; }
        public List<Aluno> Aluno { get; set; }
        public TipoCurso TipoCurso { get; set; }

        public Curso ()
        {

        }

        public Curso(int idCurso, string nome, float duracao, Professor coordenador, List<Aluno> aluno, TipoCurso tipoCurso)
        {
            IdCurso = idCurso;
            Nome = nome;
            Duracao = duracao;
            Coordenador = coordenador;
            Aluno = aluno;
            TipoCurso = tipoCurso;
        }
    }
}