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
        public DateTime Data { get; set; }

        public Disciplina Disciplina { get; set; }

        public Aluno Aluno { get; set; }

        public Frequencia ()
        {

        }

        public Frequencia(TipoFrequencia tipoFrequencia, DateTime data, Disciplina disciplina, Aluno aluno)
        {
            TipoFrequencia = tipoFrequencia;
            Data = data;
            Disciplina = disciplina;
            Aluno = aluno;
        }
    }
}