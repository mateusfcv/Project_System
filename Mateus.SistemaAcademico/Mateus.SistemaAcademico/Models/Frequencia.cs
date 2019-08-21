using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class Frequencia : EntityBase
    {
        [Required]
        public TipoFrequencia TipoFrequencia { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [Required]
        public virtual Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }
        [Required]
        public virtual Aluno Aluno { get; set; }
        public int AlunoId { get; set; }

        public Frequencia ()
        {

        }

        public Frequencia(TipoFrequencia tipoFrequencia, DateTime data, Disciplina disciplina, int disciplinaId,
            Aluno aluno, int alunoId)
        {
            TipoFrequencia = tipoFrequencia;
            Data = data;
            Disciplina = disciplina;
            DisciplinaId = disciplinaId;
            Aluno = aluno;
            AlunoId = alunoId;
        }
    }
}