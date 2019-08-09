﻿using Mateus.SistemaAcademico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;
using Mateus.SistemaAcademico.Models.JOINS;
using System.ComponentModel.DataAnnotations;

namespace Mateus.SistemaAcademico.Models
{
    public class Curso : EntityBase
    {
        public IList<CursoDisciplina> Disciplina { get; set; }
        public IList<ProfessorCurso> Professor { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public float Duracao { get; set; }
        [Required]
        public DateTime DataDeInicio { get; set; }
        [Required]
        public DateTime DataDeFim { get; set; }
        [Required]
        public Professor Coordenador { get; set; }
        [Required]
        public List<Aluno> Alunos { get; set; }
        [Required]
        public TipoCurso TipoCurso { get; set; }

        public Curso ()
        {

        }

        public Curso(List<CursoDisciplina> disciplina, IList<ProfessorCurso> professor, string nome, float duracao, Professor coordenador, List<Aluno> alunos, TipoCurso tipoCurso)
        {
            Disciplina = disciplina;
            Professor = professor;
            Nome = nome;
            Duracao = duracao;
            Coordenador = coordenador;
            Alunos = alunos;
            TipoCurso = tipoCurso;
        }
    }
}