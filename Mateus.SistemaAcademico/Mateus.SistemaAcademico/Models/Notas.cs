using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mateus.SistemaAcademico.Models.Enums;

namespace Mateus.SistemaAcademico.Models
{
    public class Notas : EntityBase
    {
        [Required]
        public int AlunosId { get; set; }
        public virtual Aluno Aluno { get; set; }

        [Required]
        public int DisciplinasId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        [Required]
        public int TurmasId { get; set; }
        public virtual Turma Turma { get; set; }

        [Required]
        public float Avaliacao { get; set; }
        public float Trabalho  { get; set; }


        public Notas()
        {

        }

        public Notas(int alunosId, Aluno aluno, int disciplinasId, Disciplina disciplina, int turmasId, Turma turma, float avaliacao,
            float trabalho)
        {
            AlunosId = alunosId;
            Aluno = aluno;
            DisciplinasId = disciplinasId;
            Disciplina = disciplina;
            TurmasId = turmasId;
            Turma = turma;
            Avaliacao = avaliacao;
            Trabalho = trabalho;
        }
    }
}