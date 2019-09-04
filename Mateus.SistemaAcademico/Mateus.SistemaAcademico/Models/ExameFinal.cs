using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class ExameFinal : EntityBase
    {
        [Required]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        [Required]
        public float Nota { get; set; }

        [Required]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        [Required]
        [Display(Name = "Data")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Data { get; set; }


        public ExameFinal()
        {

        }

        public ExameFinal(int alunoId, Aluno aluno, float nota, int disciplinaId, Disciplina disciplina, DateTime data)
        {
            AlunoId = alunoId;
            Aluno = aluno;
            Nota = nota;
            DisciplinaId = disciplinaId;
            Disciplina = disciplina;
            Data = data;
        }
    }
}