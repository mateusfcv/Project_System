using Mateus.SistemaAcademico.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mateus.SistemaAcademico.Models
{
    public class TipoDeAvaliacoes : EntityBase
    {
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataAvaliacao { get; set; }
        public float NotaAvaliacoes { get; set; }

        public float NotaSubstitutivas { get; set; }

        public float NotaExameFinal { get; set; }

        public TipoDeAvaliacoes()
        {

        }

        public TipoDeAvaliacoes(float notaAvaliacoes, float notaSubstitutivas, float notaExameFinal, DateTime dataAvaliacao)
        {
            NotaAvaliacoes = notaAvaliacoes;
            NotaSubstitutivas = notaSubstitutivas;
            NotaExameFinal = notaExameFinal;
            DataAvaliacao = dataAvaliacao;
        }
    }
}