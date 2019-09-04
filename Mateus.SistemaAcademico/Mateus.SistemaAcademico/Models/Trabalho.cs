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
        public float Nota { get; set; }

        [Required]
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

        // data em que o professor lançou o trabalho
        [Required]
        [Display(Name = "Data de Inicío")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataDeInicio { get; set; }

        [Required]
        [Display(Name = "Data de Fim")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataDaEntrega { get; set; }

        public Trabalho()
        {

        }

        public Trabalho(int alunoId, Aluno aluno, float nota, int disciplinaId, Disciplina disciplina,
            DateTime dataDeInicio, DateTime dataDaEntrega)
        {
            AlunoId = alunoId;
            Aluno = aluno;
            Nota = nota;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
            DataDeInicio = dataDeInicio;
            DataDaEntrega = dataDaEntrega;
        }
    }
}