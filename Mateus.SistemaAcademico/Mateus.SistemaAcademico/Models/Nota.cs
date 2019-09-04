using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Nota : EntityBase
    {
        [Required]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        public float Avaliacao { get; set; }

        public float Substitutivas { get; set; }

        public float Trabalho { get; set; }

        [Required]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        public Nota()
        {

        }

        public Nota(int disciplinaId, Disciplina disciplina, float avaliacao, float substitutivas, float trabalho, 
            int alunoId, Aluno aluno)
        {
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
            Avaliacao = avaliacao;
            Substitutivas = substitutivas;
            Trabalho = trabalho;
            AlunoId = alunoId;
            Aluno = aluno;
        }
    }
}