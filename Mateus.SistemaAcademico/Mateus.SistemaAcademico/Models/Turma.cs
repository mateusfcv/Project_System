using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Turma : EntityBase
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        [Required]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        // Em qual ano do curso o aluno está
        [Required]
        public int Ano { get; set; }

        public virtual IEnumerable<Notas> Notas { get; set; }

        public Turma()
        {

        }

        public Turma(string nome, int alunoId, Aluno aluno, int disciplinaId, Disciplina disciplina, int ano, IEnumerable<Notas> notas)
        {
            Nome = nome;
            AlunoId = alunoId;
            Aluno = aluno;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
            Ano = ano;
            Notas = notas;
        }
    }
}