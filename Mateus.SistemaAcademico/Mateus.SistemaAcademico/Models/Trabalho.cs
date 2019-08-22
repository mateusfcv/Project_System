using System;
using System.ComponentModel.DataAnnotations;

namespace Mateus.SistemaAcademico.Models
{
    public class Trabalho : EntityBase
    {
        [Required]
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        [Required]
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

        [Required]
        public float NotaDoTrabalho { get; set; }
        // data em que o professor lançou o trabalho
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDeInicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataDaEntrega { get; set; }

        public Trabalho()
        {

        }

        public Trabalho(int alunoId, Aluno aluno, int disciplinaId, Disciplina disciplina, float notaDoTrabalho, DateTime dataDeInicio,
            DateTime dataDaEntrega)
        {
            AlunoId = alunoId;
            Aluno = aluno;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
            NotaDoTrabalho = notaDoTrabalho;
            DataDeInicio = dataDeInicio;
            DataDaEntrega = dataDaEntrega;
        }
    }
}